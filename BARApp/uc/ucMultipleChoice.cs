using BAR.Core.Models;
using BARApp.Views;
using BARApp.Views.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARApp.uc
{
    public partial class ucMultipleChoice : UserControl
    {
        private QuestionaireModel _model;
        public QuestionaireModel Model { get { return _model; } set { _model = value; } }
        private int itemNo;
        public int ItemNo
        {
            get { return itemNo; }
            set
            {
                itemNo = value;
                lblQuestionNumber.Text = "Question #: " + itemNo.ToString();
                Model.ItemNo = itemNo;
            }
        }
        public ucMultipleChoice(QuestionaireModel model)
        {
            InitializeComponent();
            lblQuestionNumber.Text = "Question #: " + model.ItemNo.ToString();
            lblQuestion.Text = model.Question;
            lblChoiceA.Text = model.ChoiceA;
            lblChoiceB.Text = model.ChoiceB;
            lblChoiceC.Text = model.ChoiceC;
            lblChoiceD.Text = model.ChoiceD;

            _model = model;

            if (model.Type != "MC")
            {
                for (int i = 2; i <= 6; i++)
                {
                    tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[i].Height = 0;
                }

                this.Size = new System.Drawing.Size(1200, 100);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MultipleChoiceModal m = new MultipleChoiceModal(Model);
            m.ShowDialog();

            if (m.Question != null)
            {
                lblQuestionNumber.Text = "Question #: " + m.Question.ItemNo.ToString();
                lblQuestion.Text = m.Question.Question;
                lblChoiceA.Text = m.Question.ChoiceA;
                lblChoiceB.Text = m.Question.ChoiceB;
                lblChoiceC.Text = m.Question.ChoiceC;
                lblChoiceD.Text = m.Question.ChoiceD;

                Model = m.Question;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Quizlet.ReducePanelHeight(this.Height);
            this.Parent.Controls.Remove(this);
        }
    }
}
