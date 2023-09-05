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
    public partial class ucNonVoiceCard : UserControl
    {
        private QuestionAnswer _model;
        public QuestionAnswer Model { get { return _model; } set { _model = value; } }
        public ucNonVoiceCard(QuestionAnswer model)
        {
            InitializeComponent();
            _model = model;
            lblItem.Text = "Item #" + model.ItemNo.ToString();

            if (model.ItemNo % 2 == 0)
                this.BackColor = Color.Azure;
            else
                this.BackColor = Color.White;

            ucSpeechControl.TextList = new List<string>() { model.Value };
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            _model.StudentAnswer = txtAnswer.Texts;
            if (txtAnswer.Texts.Trim() == string.Empty)
            {
                lblItem.ForeColor = Color.DimGray;
                lblAnswer.ForeColor = Color.DimGray;
                tableLayoutPanel1.BackColor = Color.White;
            }
            else
            {
                lblItem.ForeColor = Color.Black;
                lblAnswer.ForeColor = Color.Black;
                tableLayoutPanel1.BackColor = Color.LightGreen;
            }
        }
    }
}
