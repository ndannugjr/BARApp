using BAR.Factory;
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

namespace BARApp.Views
{
    public partial class Activities : Form
    {
        QuizletFactory factory;
        public Activities()
        {
            InitializeComponent();
            factory = new QuizletFactory();
            timer.Start();


            var quizzes = factory.GetQuizList();
            int count = 1;
            foreach (var qcModel in quizzes)
            {
                var ucQuizCard = new ucQuizCard(qcModel);

                tlpActivities.RowStyles.Add(new RowStyle());
                tlpActivities.Controls.Add(ucQuizCard, 0, count++);
            }


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblReminder.ForeColor == Color.Red)
                lblReminder.ForeColor = Color.White;
            else
                lblReminder.ForeColor = Color.Red;
        }
    }
}
