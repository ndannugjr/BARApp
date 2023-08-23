using BAR.Core.Models;
using BAR.Factory;
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
    public partial class ucQuizCard : UserControl
    {
        private QuizCardModel _model;
        public QuizCardModel Model { get { return _model; } set { _model = value; } }

        private QuizletFactory factory;
        public ucQuizCard(QuizCardModel model)
        {
            InitializeComponent();
            _model = model;


            lblActivityType.Text = _model.ActivityType;
            lblSchoolYear.Text = _model.SchoolYearDesc;

            factory = new QuizletFactory();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            QuizletModel quiz = factory.GetQuiz(_model.QuizId);
            ActivityModal modal = new ActivityModal(quiz);
            modal.ShowDialog();
        }
    }
}
