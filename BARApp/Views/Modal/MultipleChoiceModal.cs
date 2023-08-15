using BAR.Core.Models;
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
            txtAnswer.Texts = model.Answer;
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

                this.Size = new System.Drawing.Size(790, 230);
                //txtQuestion.TabIndex = 0;
                txtAnswer.TabIndex = 1;
                btnAdd.TabIndex = 2;
                btnCancel.TabIndex = 3;
                txtChoiceA.TabIndex = 4;
                txtChoiceB.TabIndex =5;
                    txtChoiceC.TabIndex = 6;
                   txtChoiceD.TabIndex = 7;
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Question = new QuestionaireModel();

            QuestionaireModel m = new QuestionaireModel()
            {
                ItemNo = _questionNumber,
                Type = _type,
                Question = txtQuestion.Texts,
                ChoiceA = txtChoiceA.Texts,
                ChoiceB = txtChoiceB.Texts,
                ChoiceC = txtChoiceC.Texts,
                ChoiceD = txtChoiceD.Texts,
                Answer = txtAnswer.Texts
            };

            Question = m;

            this.Close();
        }

        private void MultipleChoiceModal_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
