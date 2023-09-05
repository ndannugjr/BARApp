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

namespace BARApp.uc
{
    public partial class ucReadingCompreQuestionCard : UserControl
    {
        private QuestionaireModel _model;
        public QuestionaireModel Model { get { return _model; } set { _model = value; } }

        public ucReadingCompreQuestionCard(QuestionaireModel model)
        {
            InitializeComponent();
            _model = model;

            if (model.ItemNo % 2 == 0)
                this.BackColor = Color.White;
            else
                this.BackColor = Color.Azure;

            if (model.Type != "MC")
            {
                for (int i = 2; i <= 5; i++)
                {
                    tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[i].Height = 0;
                }

                tableLayoutPanel1.RowStyles[7].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[7].Height = 0;

                this.Size = new System.Drawing.Size(800, 110);
            }
            else
            {
                //800, 348
                this.Size = new System.Drawing.Size(800, 220);
                txtAnswer.Visible = false;
                tableLayoutPanel1.RowStyles[6].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[6].Height = 0;
            }

            //lblQuestionNumber.Text = string.Format("Question #{0}", model.ItemNo);
            lblQuestionNumber.Text = model.ItemNo.ToString() + ".";
            lblChoiceA.Text = model.ChoiceA;
            lblChoiceB.Text = model.ChoiceB;
            lblChoiceC.Text = model.ChoiceC;
            lblChoiceD.Text = model.ChoiceD;
            lblQuestion.Text = model.Question;

            rbtnA.Checked = false;
            rbtnB.Checked = false;
            rbtnC.Checked = false;
            rbtnD.Checked = false;
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton s = (RadioButton)sender;
            if (s.Checked)
                _model.StudentAnswer = s.Text;


            foreach (var tlp1 in tableLayoutPanel1.Controls.OfType<TableLayoutPanel>())
            {
                var rbtnList = tlp1.Controls.OfType<RadioButton>().ToList();
                if (rbtnList.Any(s => s.Checked))
                {
                    foreach (var rbtn in tlp1.Controls.OfType<RadioButton>())
                    {
                        rbtn.ForeColor = Color.Black;
                    }

                    foreach (var lbl in tableLayoutPanel1.Controls.OfType<Label>())
                    {
                        lbl.ForeColor = Color.Black;
                    }

                    tableLayoutPanel1.BackColor = Color.LightGreen;

                }
            }



        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswer.Texts.Trim() == string.Empty)
            {
                tableLayoutPanel1.BackColor = Color.White;

                foreach (var lbl in tableLayoutPanel1.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Color.DimGray;
                }
            }
            else
            {
                tableLayoutPanel1.BackColor = Color.LightGreen;
                foreach (var lbl in tableLayoutPanel1.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Color.Black;
                }
                _model.StudentAnswer = txtAnswer.Texts;
            }
        }
    }
}
