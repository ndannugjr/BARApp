using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using BARApp.uc;
using BARApp.Views.Modal;
using BAR.Core.Models;
using BAR.Core.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using BAR.Factory;
using BAR.Data.Migrations;

namespace BARApp.Views
{
    public partial class Quizlet : Form
    {
        private bool isPlaceholder1Active = true;
        private bool isPlaceholder2Active = true;
        private bool isPlaceholder3Active = true;
        private string nonVoicePlaceHolderText = "Please input words in a Semicolon-Separated format (e.g. Chair; Climbing; Zebra)";
        private string voicePlaceHolderText = "Please input words/sentence in a Semicolon-Separated format (e.g. Maricris went to a birthday party on Saturday; The boats are floating along the lakeshore; Island)";

        private string readingComprePlaceHolderText = "Please input text here... ";

        private List<QuestionaireModel> questionaire;
        private int pnlReadingCompreInitialHeight = 500;

        int ucMultipleChoiceInitialHeight = 256;

        QuizletFactory factory;
        public Quizlet()
        {
            InitializeComponent();
            questionaire = new List<QuestionaireModel>();
            factory = new QuizletFactory();

            rtbNonVoice.Text = nonVoicePlaceHolderText;
            rtbNonVoice.ForeColor = SystemColors.GrayText;

            rtbVoice.Text = voicePlaceHolderText;
            rtbVoice.ForeColor = SystemColors.GrayText;

            rtbReadingCompre.Text = readingComprePlaceHolderText;
            rtbReadingCompre.ForeColor = SystemColors.GrayText;

            ucSpeechControlVoice1.TextList = voicePlaceHolderText.Split(";").ToList();
            ucSpeechControlNonVoice1.TextList = nonVoicePlaceHolderText.Split(";").ToList();
            ucSpeechControlReadingCompre1.TextList = readingComprePlaceHolderText.Split(";").ToList();

            cbType.DisplayMember = "Description";
            cbType.ValueMember = "Value";
            cbType.DataSource = Enum.GetValues(typeof(ActivityType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType()
                    .GetField(value.ToString()), typeof(DescriptionAttribute))
                    as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();

            cbGrade.DataSource = Enum.GetValues(typeof(Grade));

            cbSchoolYear.DisplayMember = "Description";
            cbSchoolYear.ValueMember = "Value";
            cbSchoolYear.DataSource = Enum.GetValues(typeof(SchoolYear))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType()
                    .GetField(value.ToString()), typeof(DescriptionAttribute))
                    as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();


            //factory.GetQuiz(7);
        }

        public List<string> GetEnumDescriptions<TEnum>() where TEnum : Enum
        {
            List<string> descriptions = new List<string>();

            foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
            {
                string description = EnumHelper.GetEnumDescription(value);
                descriptions.Add(description);
            }

            return descriptions;
        }

        private void rtbNonVoice_Enter(object sender, EventArgs e)
        {
            if (isPlaceholder1Active)
            {
                rtbNonVoice.Text = "";
                rtbNonVoice.ForeColor = SystemColors.ControlText;
                rtbNonVoice.BackColor = Color.White;

                isPlaceholder1Active = false;
            }
        }

        private void rtbNonVoice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbNonVoice.Text))
            {
                rtbNonVoice.Text = nonVoicePlaceHolderText;
                rtbNonVoice.ForeColor = SystemColors.GrayText;
                isPlaceholder1Active = true;
            }
        }

        private void rtbVoice_Enter(object sender, EventArgs e)
        {
            if (isPlaceholder2Active)
            {
                rtbVoice.Text = "";
                rtbVoice.ForeColor = SystemColors.ControlText;
                rtbVoice.BackColor = Color.White;
                isPlaceholder2Active = false;
            }
        }

        private void rtbVoice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbVoice.Text))
            {
                rtbVoice.Text = voicePlaceHolderText;
                rtbVoice.ForeColor = SystemColors.GrayText;
                isPlaceholder2Active = true;
            }
        }

        private void rtbReadingCompre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbReadingCompre.Text))
            {
                rtbReadingCompre.Text = readingComprePlaceHolderText;
                rtbReadingCompre.ForeColor = SystemColors.GrayText;
                isPlaceholder3Active = true;
            }
        }

        private void rtbReadingCompre_Enter(object sender, EventArgs e)
        {
            if (isPlaceholder3Active)
            {
                rtbReadingCompre.Text = "";
                rtbReadingCompre.ForeColor = SystemColors.ControlText;
                rtbReadingCompre.BackColor = Color.White;
                rtbReadingCompre.ForeColor = Color.DimGray;
                isPlaceholder3Active = false;
            }
        }


        private void rtbVoice_TextChanged(object sender, EventArgs e)
        {
            if (rtbVoice.SelectedText.Length > 0)
            {
                ucSpeechControlVoice1.TextList = rtbVoice.Text.Trim().Split(";").ToList();
            }
            else
                ucSpeechControlVoice1.TextList = rtbVoice.Text.Trim().Split(";").ToList();
        }

        private void rtbNonVoice_TextChanged(object sender, EventArgs e)
        {
            ucSpeechControlNonVoice1.TextList = rtbNonVoice.Text.Trim().Split(";").ToList();
        }

        private void rtbReadingCompre_TextChanged(object sender, EventArgs e)
        {
            string titleText = txtTitle1.Texts.Trim();
            ucSpeechControlReadingCompre1.TextList = (string.Format("{0};{1}",
                titleText, rtbReadingCompre.Text)).Split(";").ToList();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            txtTitle1.BackColor = Color.White;

            string titleText = txtTitle1.Texts.Trim();
            ucSpeechControlReadingCompre1.TextList = (titleText != string.Empty
                ? string.Format("Title: {0};{1}", titleText, rtbReadingCompre.Text)
                : rtbReadingCompre.Text).Split(";").ToList();
        }

        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            MultipleChoiceModal m = new MultipleChoiceModal(questionaire.Count + 1, "MC");
            m.ShowDialog();

            if (m.Question != null)
            {
                questionaire.Add(m.Question);
                InitializeQuestinaireControls(m.Question);
            }
        }

        private void btnIdentification_Click(object sender, EventArgs e)
        {
            MultipleChoiceModal m = new MultipleChoiceModal(questionaire.Count + 1, "ID");
            m.ShowDialog();

            if (m.Question != null)
            {
                questionaire.Add(m.Question);
                InitializeQuestinaireControls(m.Question);
            }
        }

        private void InitializeQuestinaireControls(QuestionaireModel model)
        {
            var ucMc = new ucMultipleChoice(model);
            //if (model.Type == "MC")
            //{
            pnlReadingCompre.Height += ucMc.Height;
            tlpQuestions.RowStyles.Add(new RowStyle());
            tlpQuestions.Controls.Add(ucMc, 0, model.ItemNo);
            //}
            //else
            //{
            //    pnlReadingCompre.Height += ucMc.Height;
            //    tlpQuestions.RowStyles.Add(new RowStyle());
            //    tlpQuestions.Controls.Add(ucMc, 0, model.ItemNo);
            //}

        }

        private bool IsValid()
        {
            bool _isValid = true;
            if (rtbNonVoice.Text == nonVoicePlaceHolderText)
            {
                rtbNonVoice.BackColor = Color.Red;
                rtbNonVoice.ForeColor = Color.White;
                _isValid = false;
            }

            if (rtbVoice.Text == voicePlaceHolderText)
            {
                rtbVoice.BackColor = Color.Red;
                rtbVoice.ForeColor = Color.White;
                _isValid = false;
            }

            if (rtbReadingCompre.Text == readingComprePlaceHolderText)
            {
                rtbReadingCompre.BackColor = Color.Red;
                rtbReadingCompre.ForeColor = Color.White;
                _isValid = false;
            }

            if (txtTitle1.Texts == string.Empty)
            {
                txtTitle1.BackColor = Color.Red;
                _isValid = false;
            }

            if (tlpQuestions.Controls.OfType<ucMultipleChoice>().Count() <= 0)
            {
                MessageBox.Show("Please input questions for your Reading comprehension", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _isValid = false;
            }

            return _isValid;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                List<QuestionaireModel> questions = new List<QuestionaireModel>();
                List<ucMultipleChoice> ucontrols = tlpQuestions.Controls.OfType<ucMultipleChoice>().ToList();
                foreach (ucMultipleChoice u in ucontrols)
                {
                    questions.Add(u.Model);
                };

                List<QuestionAnswer> voiceQA = new();
                foreach (var vqaItem in rtbVoice.Text.Split(";").ToList())
                {
                    if (vqaItem.Trim() != string.Empty)
                    {
                        voiceQA.Add(new QuestionAnswer()
                        {
                            Id = 0,
                            Value = vqaItem,
                            Answer = string.Empty
                        });
                    }
                }

                List<QuestionAnswer> nonVoiceQA = new();
                foreach (var nvqaItem in rtbNonVoice.Text.Split(";").ToList())
                {
                    if (nvqaItem.Trim() != string.Empty)
                    {
                        nonVoiceQA.Add(new QuestionAnswer()
                        {
                            Id = 0,
                            Value = nvqaItem,
                            Answer = string.Empty
                        });
                    }
                }

                QuizletModel model = new QuizletModel()
                {
                    ActivityType = cbType.SelectedValue.ToString(),
                    Grade = cbGrade.SelectedValue.ToString(),
                    SchoolYear = cbSchoolYear.SelectedValue.ToString(),
                    Voice = voiceQA,
                    NonVoice = nonVoiceQA,
                    ReadingComprehension = new ReadingComprehension()
                    {
                        Title = txtTitle1.Texts,
                        Description = rtbReadingCompre.Text,
                        Questions = questions
                    }
                };

                factory.SaveQuizlet(model);
            }
        }

        private void tlpQuestions_ControlAdded(object sender, ControlEventArgs e)
        {
            List<ucMultipleChoice> ucontrols = tlpQuestions.Controls.OfType<ucMultipleChoice>().ToList();

            if (ucontrols.Count > 0)
            {
                pnlReadingCompre.Height = pnlReadingCompreInitialHeight + (ucMultipleChoiceInitialHeight * ucontrols.Count);
                tableLayoutPanel2.RowStyles[5] = new RowStyle(SizeType.Absolute, pnlReadingCompreInitialHeight + (ucMultipleChoiceInitialHeight * ucontrols.Count));
            }
            else
            {
                pnlReadingCompre.Height = pnlReadingCompreInitialHeight;
                tableLayoutPanel2.RowStyles[5] = new RowStyle(SizeType.Absolute, 250);
            }

            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.PerformLayout();
        }

        private void tlpQuestions_ControlRemoved(object sender, ControlEventArgs e)
        {
            List<ucMultipleChoice> ucontrols = tlpQuestions.Controls.OfType<ucMultipleChoice>().ToList();


            questionaire.Clear();
            int count = 1;
            foreach (var uControl in ucontrols.OrderBy(o => o.Model.ItemNo))
            {
                uControl.ItemNo = count++;
                questionaire.Add(uControl.Model);
            }

            if (ucontrols.Count > 0)
            {
                tableLayoutPanel2.RowStyles[5] = new RowStyle(SizeType.Absolute, pnlReadingCompreInitialHeight + (ucMultipleChoiceInitialHeight * ucontrols.Count));
                pnlReadingCompre.Height = pnlReadingCompreInitialHeight + (ucMultipleChoiceInitialHeight * ucontrols.Count);
            }
            else
            {
                pnlReadingCompre.Height = pnlReadingCompreInitialHeight;
                tableLayoutPanel2.RowStyles[5] = new RowStyle(SizeType.Absolute, 600);
            }

            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.PerformLayout();
        }


    }
}
