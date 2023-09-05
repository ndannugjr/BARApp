using BAR.Core.Models;
using BAR.Factory;
using BARApp.uc;
using BARApp.Views.ActivityPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARApp.Views.Modal
{
    public partial class ActivityModal : Form
    {
        private static ActivityModal _instance;

        private NonVoice nvForm;
        private Voice vForm;
        private ReadingCompre rcForm;
        private int PageNumber;
        QuizletModel _model;
        QuizletFactory factory;
        public ActivityModal(QuizletModel model)
        {
            InitializeComponent();
            factory = new QuizletFactory();
            _instance = this;
            _model = model;

            nvForm = new NonVoice(model.NonVoice);
            vForm = new Voice(model.Voice);
            rcForm = new ReadingCompre(model.ReadingComprehension);

            PageNumber = 1;
            DisplayForm(nvForm);

            
        }

        private void DisplayPage(int pageNumber)
        {
            btnChangeVoice.Visible = false;
            if (pageNumber == 1)
            {
                btnChangeVoice.Visible = true;
                DisplayForm(nvForm);
            }
            else if (pageNumber == 2)
                DisplayForm(vForm);
            else if (pageNumber == 3)
                DisplayForm(rcForm);
            else
            {
                if (PageNumber == 0)
                {
                    DisplayForm(rcForm);
                    PageNumber = 3;

                }
                else
                {
                    PageNumber = 1;
                    btnChangeVoice.Visible = true;
                    DisplayForm(nvForm);
                }
            }

            lblPageNo.Text = string.Format("Page {0} of 3", PageNumber);
        }

        public static void DisplayForm(Form frm)
        {
            foreach (var pnl in _instance.pnlContent.Controls.OfType<Panel>())
            {
                pnl.Visible = false;
            }

            _instance.lblFormTitle.Text = frm.Tag.ToString();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _instance.pnlContent.Controls.Clear();
            _instance.pnlContent.Controls.Add(frm);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PageNumber += 1;
            DisplayPage(PageNumber);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PageNumber -= 1;
            DisplayPage(PageNumber);
        }

        private void btnChangeVoice_Click(object sender, EventArgs e)
        {

            foreach (var pnl in nvForm.Controls.OfType<Panel>())
            {
                foreach (var tlpContent in pnl.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (var ucNv in tlpContent.Controls.OfType<ucNonVoiceCard>())
                    {
                        foreach (var tlp in ucNv.Controls.OfType<TableLayoutPanel>())
                        {
                            foreach (var ucSc in tlp.Controls.OfType<ucSpeechControl>())
                            {
                                ucSc.IsMaleVoice = !ucSc.IsMaleVoice;
                            }
                        }
                    }
                }
            }
        }

        private void ActivityModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Unable to close the form until the test is finished.", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // e.Cancel = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool hasBlankAnswer = false;
            List<QuestionAnswer> nvAnswers = new List<QuestionAnswer>();
            foreach (var pnl in nvForm.Controls.OfType<Panel>())
            {
                foreach (var tlp in pnl.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (var ucNvCard in tlp.Controls.OfType<ucNonVoiceCard>())
                    {
                        var m = ucNvCard.Model;
                        nvAnswers.Add(m);
                        if (string.IsNullOrEmpty(m.StudentAnswer))
                            hasBlankAnswer = true;
                    }
                }
            }

            List<QuestionAnswer> vAnswers = new List<QuestionAnswer>();
            foreach (var pnl in vForm.Controls.OfType<Panel>())
            {
                foreach (var tlp in pnl.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (var ucVCard in tlp.Controls.OfType<ucVoiceCard>())
                    {
                        var m = ucVCard.Model;
                        vAnswers.Add(m);
                        if (string.IsNullOrEmpty(m.StudentAnswer))
                            hasBlankAnswer = true;
                    }
                }
            }

            List<QuestionaireModel> rcAnswers = new List<QuestionaireModel>();
            foreach (var pnl in rcForm.Controls.OfType<Panel>())
            {
                foreach (var tlp in pnl.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (var ucRcCard in tlp.Controls.OfType<ucReadingCompreQuestionCard>())
                    {
                        var m = ucRcCard.Model;
                        rcAnswers.Add(m);
                        if (string.IsNullOrEmpty(m.StudentAnswer))
                            hasBlankAnswer = true;
                    }
                }
            }

            _model.Voice = vAnswers;
            _model.NonVoice = nvAnswers;
            _model.ReadingComprehension.Questions = rcAnswers;

            if (hasBlankAnswer)
            {
                var res = MessageBox.Show("One or more questions are not answered. \n\n Do you wish to continue?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    factory.SaveAnswerSheet(_model);
                }
            }
            else
            {
                factory.SaveAnswerSheet(_model);
            }
        }
    }
}
