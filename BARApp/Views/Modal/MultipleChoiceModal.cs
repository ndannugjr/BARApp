using BAR.Core.Models;
using BARApp.uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARApp.Views.Modal
{
    public partial class MultipleChoiceModal : Form
    {
        public QuestionaireModel Question;
        private int _questionNumber;
        private string _type;
        public MultipleChoiceModal(int questionNumber, string type)
        {
            InitializeComponent();
            _questionNumber = questionNumber;
            lblQuestionNumber.Text = "Question #: " + questionNumber.ToString();
            _type = type;
            btnAdd.Text = "Add";

            HideRows();
        }

        public MultipleChoiceModal(QuestionaireModel model)
        {
            InitializeComponent();
            _type = model.Type;
            lblQuestionNumber.Text = "Question #: " + model.ItemNo.ToString();
            _questionNumber = model.ItemNo;
            txtQuestion.Texts = model.Question;
            txtChoiceA.Texts = model.ChoiceA;
            txtChoiceB.Texts = model.ChoiceB;
            txtChoiceC.Texts = model.ChoiceC;
            txtChoiceD.Texts = model.ChoiceD;

            if (_type != "MC")
                txtAnswer.Texts = model.Answer;
            else
            {
                switch (model.Answer)
                {
                    case "A":
                        rbtnA.Checked = true;
                        break;
                    case "B":
                        rbtnB.Checked = true;
                        break;
                    case "C":
                        rbtnC.Checked = true;
                        break;
                    case "D":
                        rbtnD.Checked = true;
                        break;
                    default:
                        MessageBox.Show("The answer is invalid!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            HideRows();

            btnAdd.Text = "Save";
        }

        private void HideRows()
        {
            if (_type != "MC")
            {
                for (int i = 2; i <= 5; i++)
                {
                    tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[i].Height = 0;
                }

                tableLayoutPanel1.RowStyles[7].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[7].Height = 0;

                this.Size = new System.Drawing.Size(790, 230);
                //txtQuestion.TabIndex = 0;
                txtAnswer.TabIndex = 1;
                btnAdd.TabIndex = 2;
                btnCancel.TabIndex = 3;
                txtChoiceA.TabIndex = 4;
                txtChoiceB.TabIndex = 5;
                txtChoiceC.TabIndex = 6;
                txtChoiceD.TabIndex = 7;

            }
            else
            {
                tableLayoutPanel1.RowStyles[6].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[6].Height = 0;

                txtAnswer.Visible = false;
            }
        }

        private bool IsValid()
        {
            bool _isValid = true;
            if (_type != "MC")
            {
                if (txtQuestion.Texts == string.Empty)
                {
                    errorProvider.SetError(txtQuestion, "Required");
                    _isValid = false;
                }
                if (txtAnswer.Texts == string.Empty)
                {
                    errorProvider.SetError(txtAnswer, "Required");
                    _isValid = false;
                }
            }
            else
            {
                if (txtQuestion.Texts == string.Empty)
                {
                    errorProvider.SetError(txtQuestion, "Required");
                    _isValid = false;
                }
                if (txtChoiceA.Texts == string.Empty)
                {
                    errorProvider.SetError(txtChoiceA, "Required");
                    _isValid = false;
                }
                if (txtChoiceB.Texts == string.Empty)
                {
                    errorProvider.SetError(txtChoiceB, "Required");
                    _isValid = false;
                }
                if (txtChoiceC.Texts == string.Empty)
                {
                    errorProvider.SetError(txtChoiceC, "Required");
                    _isValid = false;
                }
                if (txtChoiceD.Texts == string.Empty)
                {
                    errorProvider.SetError(txtChoiceD, "Required");
                    _isValid = false;
                }
            }

            return _isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Question = new QuestionaireModel();

                string ans = string.Empty;
                if (_type == "MC")
                {
                    if (rbtnA.Checked)
                        ans = "A";
                    if (rbtnB.Checked)
                        ans = "B";
                    if (rbtnC.Checked)
                        ans = "C";
                    if (rbtnD.Checked)
                        ans = "D";
                }
                else
                    ans = txtAnswer.Texts;

                QuestionaireModel m = new QuestionaireModel()
                {
                    ItemNo = _questionNumber,
                    Type = _type,
                    Question = txtQuestion.Texts,
                    ChoiceA = txtChoiceA.Texts,
                    ChoiceB = txtChoiceB.Texts,
                    ChoiceC = txtChoiceC.Texts,
                    ChoiceD = txtChoiceD.Texts,
                    Answer = ans
                };

                Question = m;

                this.Close();
            }
        }

        private void MultipleChoiceModal_Load(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            var control = ((TextBox)sender).Parent;
            errorProvider.SetError(control, "");
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
