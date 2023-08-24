using BAR.Core.Models;
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
        public ActivityModal(QuizletModel model)
        {
            InitializeComponent();
            _instance = this;

            nvForm = new NonVoice(model.NonVoice);
            vForm = new Voice(model.Voice);
            rcForm = new ReadingCompre();

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
    }
}
