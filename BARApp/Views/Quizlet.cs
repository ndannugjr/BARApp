﻿using System;
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

namespace BARApp.Views
{
    public partial class Quizlet : Form
    {
        private bool isPlaceholder1Active = true;
        private bool isPlaceholder2Active = true;
        private bool isPlaceholder3Active = true;
        private string nonVoicePlaceHolderText = "Please input words in a Semicolon-Separated format (e.g. Chair; Climbing; Zebra)\r\n";
        private string voicePlaceHolderText = "Please input words/sentence in a Semicolon-Separated format (e.g. Maricris went to a birthday party on Saturday; The boats are floating along the lakeshore; Island)";

        private string readingComprePlaceHolderText = "Please input text here... ";
        private List<QuestionaireModel> questionaire;
        private int pnlReadingCompreInitialHeight = 400;

        public static Quizlet _quizletInstace;

        int ucMultipleChoiceInitialHeight = 206;
        public Quizlet()
        {
            InitializeComponent();
            questionaire = new List<QuestionaireModel>();

            rtbNonVoice.Text = nonVoicePlaceHolderText;
            rtbNonVoice.ForeColor = SystemColors.GrayText;

            rtbVoice.Text = voicePlaceHolderText;
            rtbVoice.ForeColor = SystemColors.GrayText;

            rtbReadingCompre.Text = readingComprePlaceHolderText;
            rtbReadingCompre.ForeColor = SystemColors.GrayText;

            ucSpeechControlVoice1.TextList = voicePlaceHolderText.Split(";").ToList();
            ucSpeechControlNonVoice1.TextList = nonVoicePlaceHolderText.Split(";").ToList();
            ucSpeechControlReadingCompre1.TextList = readingComprePlaceHolderText.Split(";").ToList();


            // pnlReadingCompreInitialHeight = pnlReadingCompre.Height;

            _quizletInstace = this;
        }

        private void rtbNonVoice_Enter(object sender, EventArgs e)
        {
            if (isPlaceholder1Active)
            {
                rtbNonVoice.Text = "";
                rtbNonVoice.ForeColor = SystemColors.ControlText;
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
                isPlaceholder3Active = false;
            }
        }


        private void rtbVoice_TextChanged(object sender, EventArgs e)
        {
            if (rtbVoice.SelectedText.Length > 0)
            {
                ucSpeechControlVoice1.TextList = rtbVoice.Text.Split(";").ToList();
            }
            else
                ucSpeechControlVoice1.TextList = rtbVoice.Text.Split(";").ToList();
        }

        private void rtbNonVoice_TextChanged(object sender, EventArgs e)
        {
            ucSpeechControlNonVoice1.TextList = rtbNonVoice.Text.Split(";").ToList();
        }

        private void rtbReadingCompre_TextChanged(object sender, EventArgs e)
        {
            string titleText = txtTitle1.Texts;
            ucSpeechControlReadingCompre1.TextList = (string.Format("{0};{1}",
                titleText, rtbReadingCompre.Text)).Split(";").ToList();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            string titleText = txtTitle1.Texts;
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
            if (model.Type == "MC")
            {
                pnlReadingCompre.Height += ucMc.Height;
                tlpQuestions.RowStyles.Add(new RowStyle());
                tlpQuestions.Controls.Add(ucMc, 0, model.ItemNo);
            }
            else
            {
                pnlReadingCompre.Height += ucMc.Height;
                tlpQuestions.RowStyles.Add(new RowStyle());
                tlpQuestions.Controls.Add(ucMc, 0, model.ItemNo);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void tlpQuestions_ControlAdded(object sender, ControlEventArgs e)
        {
            List<ucMultipleChoice> ucontrols = tlpQuestions.Controls.OfType<ucMultipleChoice>().ToList();

            if (ucontrols.Count > 0)
            {
                pnlReadingCompre.Height = pnlReadingCompreInitialHeight + (ucMultipleChoiceInitialHeight * ucontrols.Count);
                tableLayoutPanel2.RowStyles[5] = new RowStyle(SizeType.Absolute, 400 + (ucMultipleChoiceInitialHeight * ucontrols.Count));
            }
            else
            {
                pnlReadingCompre.Height = pnlReadingCompreInitialHeight;
                tableLayoutPanel2.RowStyles[5] = new RowStyle(SizeType.Absolute, 200);
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
                //tlpQuestions.Controls.Remove(uControl);
                //InitializeQuestinaireControls(uControl.Model);
            }

            //foreach (var c in questionaire)
            //{
            //    InitializeQuestinaireControls(c);
            //}

            if (ucontrols.Count > 0)
            {
                tableLayoutPanel2.RowStyles[5] = new RowStyle(SizeType.Absolute, 400 + (ucMultipleChoiceInitialHeight * ucontrols.Count));
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
