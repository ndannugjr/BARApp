using BAR.Core.Classes;
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

            if (factory.IsDone(model.ActivityHeaderId, RuntimeInfo.UserId))
            {
                btnStart.Text = "Review";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Review")
            {
                QuizletModel q = factory.GetQuizResultsById(_model.ActivityHeaderId, RuntimeInfo.UserId);
            }
            else
            {
                QuizletModel quiz = factory.GetQuizById(_model.ActivityHeaderId);
                ActivityModal modal = new ActivityModal(quiz);
                modal.ShowDialog();
            }
        }
    }
}
