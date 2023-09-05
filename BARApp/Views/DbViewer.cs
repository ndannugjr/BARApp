using BAR.Data;
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
    public partial class DbViewer : Form
    {
        public DbViewer()
        {
            InitializeComponent();

            using (var db = new ApplicationDbContext())
            {
                dataGridView1.DataSource = db.AnswerSheet.ToList();
                dataGridView2.DataSource = db.ActivityHeader.ToList();
                dataGridView3.DataSource = db.ActivityDescription.ToList();
                dataGridView4.DataSource = db.ActivityQuestions.ToList();
                dataGridView5.DataSource = db.ActivityVoiceNonVoiceDetails.ToList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                var activityHeader = db.ActivityHeader.ToList();
                var activityDesc = db.ActivityDescription.ToList();
                var questions = db.ActivityQuestions.ToList();
                var nonVoiceDetails = db.ActivityVoiceNonVoiceDetails.ToList();


                db.ActivityHeader.RemoveRange(activityHeader);
                db.ActivityDescription.RemoveRange(activityDesc);
                db.ActivityQuestions.RemoveRange(questions);
                db.ActivityVoiceNonVoiceDetails.RemoveRange(nonVoiceDetails);
                db.SaveChanges();

                dataGridView2.DataSource = db.ActivityHeader.ToList();
                dataGridView3.DataSource = db.ActivityDescription.ToList();
                dataGridView4.DataSource = db.ActivityQuestions.ToList();
                dataGridView5.DataSource = db.ActivityVoiceNonVoiceDetails.ToList();
            }
        }
    }
}
