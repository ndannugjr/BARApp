using BAR.Core.Models;
using BAR.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARApp.Views
{
    public partial class QuizDetails : Form
    {
        QuizletFactory factory;
        Quizlet quizlet;
        private List<QuizletModel> model;
        public QuizDetails()
        {
            InitializeComponent();
            factory = new QuizletFactory();

            InitializeActivities();
            timer.Start();
        }

        private void InitializeActivities()
        {

            model = factory.GetQuizList();
            InitializeTableRows(model);
        }

        private void btnPost_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = (int)btn.Tag;

            if (factory.IsAlreadyPosted(id))
            {
                var res = MessageBox.Show("Quiz already posted. \n\n Do you wish to unpost?", "Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    factory.PostQuiz(id);
                    var lbl = tableLayoutPanel.Controls.OfType<Label>()
                         .Where(s => s.Name == $"lblPostedDate{id}").FirstOrDefault();
                    lbl.Text = "-";
                    lbl.Tag = null;
                }
            }
            else
            {
                var res = MessageBox.Show("Post this quiz?", "Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    DateTime postedDate = factory.PostQuiz(id);
                    var lbl = tableLayoutPanel.Controls.OfType<Label>()
                         .Where(s => s.Name == $"lblPostedDate{id}").FirstOrDefault();
                    lbl.Text = TimeAgoFromDateTime(postedDate);
                    lbl.Tag = postedDate;

                }
            }
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            timer.Enabled = false;
            Button btn = ((Button)sender);
            int headerId = (int)btn.Tag;
            quizlet = new Quizlet(factory.GetQuizById(headerId));
            quizlet.ShowDialog();

            //InitializeActivities();
            UpdateRowDataByRowNumber(tableLayoutPanel.GetRow(btn), headerId);

            timer.Start();
        }

        private void UpdateRowDataByRowNumber(int rowNum, int id)
        {
            model = factory.GetQuizList();
            var data = model.FirstOrDefault(s => s.ActivityHeaderId == id);

            foreach (Control ctrl in tableLayoutPanel.Controls)
            {
                if (tableLayoutPanel.GetRow(ctrl) == rowNum)
                {
                    if (ctrl.Name == $"lblActivityType{id}")
                        ctrl.Text = data.ActivityType;
                    //else if (ctrl.Name == $"lblCreatedDate{id}")
                    //    ctrl.Text = TimeAgoFromDateTime(data.CreatedDate);
                    else if (ctrl.Name == $"lblLastUpdatedDate{data.ActivityHeaderId}")
                    {
                        ctrl.Text = data.CreatedDate != data.LastUpdatedDate
                    ? TimeAgoFromDateTime(data.LastUpdatedDate)
                    : "-";
                        ctrl.Tag = data.LastUpdatedDate.ToString();
                    }
                    else if (ctrl.Name == $"lblPostedDate{data.ActivityHeaderId}")
                    {
                        ctrl.Text = data.PostedDate != null
                       ? TimeAgoFromDateTime(data.PostedDate.Value)
                       : "-";
                        ctrl.Tag = data.PostedDate.ToString();
                    }
                    else if (ctrl.Name == $"lblGrade{data.ActivityHeaderId}")
                        ctrl.Text = data.Grade;
                    else if (ctrl.Name == $"lblSchoolYearDesc{data.ActivityHeaderId}")
                        ctrl.Text = data.SchoolYearDesc;

                }
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            timer.Enabled = false;
            Button btn = (Button)sender;
            var res = MessageBox.Show("Are you sure you want to delete this activity?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                factory.DeleteQuiz((int)btn.Tag);

                List<Control> controlsToRemove = new List<Control>();
                foreach (Control control in tableLayoutPanel.Controls)
                {
                    if (tableLayoutPanel.GetRow(control) == tableLayoutPanel.GetRow(btn))
                    {
                        controlsToRemove.Add(control);
                        control.Tag = null;
                    }
                }

                foreach (Control control in controlsToRemove)
                {
                    tableLayoutPanel.Controls.Remove(control);
                    control.Dispose();
                }
            }

            timer.Start();
        }

        static string TimeAgoFromDateTime(DateTime inputDate)
        {
            TimeSpan timeDifference = DateTime.Now - inputDate;

            if (timeDifference < TimeSpan.FromMinutes(1))
            {
                return "a moment ago";
            }
            else if (timeDifference < TimeSpan.FromHours(1))
            {
                int minutes = (int)timeDifference.TotalMinutes;
                return $"{minutes} minute{(minutes != 1 ? "s" : "")} ago";
            }
            else if (timeDifference < TimeSpan.FromDays(1))
            {
                int hours = (int)timeDifference.TotalHours;
                return $"{hours} hour{(hours != 1 ? "s" : "")} ago";
            }
            else if (timeDifference < TimeSpan.FromDays(7))
            {
                int days = (int)timeDifference.TotalDays;
                return $"{days} day{(days != 1 ? "s" : "")} ago";
            }
            else if (timeDifference < TimeSpan.FromDays(30)) // Approximate month
            {
                int weeks = (int)(timeDifference.TotalDays / 7);
                return $"{weeks} week{(weeks != 1 ? "s" : "")} ago";
            }
            else
            {
                return inputDate.ToString("yyyy-MM-dd");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Quizlet q = new Quizlet();
            q.ShowDialog();
            timer.Start();
        }

        private void InitializeTableRows(List<QuizletModel> model)
        {
            int rowNumber = 3;

            foreach (var m in model)
            {
                tableLayoutPanel.Height += 30;

                tableLayoutPanel.Controls.Add(CreateLabel(m.ActivityType,
                    $"lblActivityType{m.ActivityHeaderId}", ""), 0, rowNumber);

                tableLayoutPanel.Controls.Add(CreateLabel(TimeAgoFromDateTime(m.CreatedDate),
                    $"lblCreatedDate{m.ActivityHeaderId}", m.CreatedDate.ToString()), 1, rowNumber);

                tableLayoutPanel.Controls.Add(CreateLabel(m.CreatedDate != m.LastUpdatedDate
                    ? TimeAgoFromDateTime(m.LastUpdatedDate)
                    : "-", $"lblLastUpdatedDate{m.ActivityHeaderId}", m.LastUpdatedDate.ToString()), 2, rowNumber);

                tableLayoutPanel.Controls.Add(CreateLabel(m.PostedDate != null
                    ? TimeAgoFromDateTime(m.PostedDate.Value)
                    : "-", $"lblPostedDate{m.ActivityHeaderId}", m.PostedDate.ToString()), 3, rowNumber);

                tableLayoutPanel.Controls.Add(CreateLabel(m.Grade,
                    $"lblGrade{m.ActivityHeaderId}", ""), 4, rowNumber);

                tableLayoutPanel.Controls.Add(CreateLabel(m.SchoolYearDesc,
                    $"lblSchoolYearDesc{m.ActivityHeaderId}", ""), 5, rowNumber);

                var btnEdit = CreateButton("✏️", $"btncEdit{m.ActivityHeaderId}", m.ActivityHeaderId, 1, Color.Gold);
                btnEdit.Click += btnEdit_Click;

                tableLayoutPanel.Controls.Add(btnEdit, 6, rowNumber);

                var btnPost = CreateButton("📌", $"btncPost{m.ActivityHeaderId}", m.ActivityHeaderId, 2, Color.Green);
                btnPost.Click += btnPost_Click;

                tableLayoutPanel.Controls.Add(btnPost, 7, rowNumber);

                var btnDelete = CreateButton("❌", $"btncDelete{m.ActivityHeaderId}", m.ActivityHeaderId, 3, Color.Red);
                btnDelete.Click += btnDelete_Click;

                tableLayoutPanel.Controls.Add(btnDelete, 8, rowNumber);

                rowNumber++;

            }
        }

        private Label CreateLabel(string text, string name, string tag)
        {
            DateTime dtTag = new DateTime();
            if (tag != string.Empty)
            {
                dtTag = Convert.ToDateTime(tag);
            }

            return new Label()
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.Black,
                Location = new Point(81, 0),
                Size = new Size(128, 35),
                Text = text,
                Name = name,
                Tag = dtTag,
                TextAlign = ContentAlignment.MiddleCenter,
            };
        }

        private Button CreateButton(string text, string name, int tag, int btnOder, Color backColor)
        {
            return new Button()
            {
                BackColor = backColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.White,
                Size = new Size(40, 29),
                Text = text,
                Name = name,
                Tag = tag,
                UseVisualStyleBackColor = false,
                Margin = btnOder == 1 ? new Padding(28, 0, 0, 0) : new Padding(5, 0, 0, 0)
            };
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dtDefault = new DateTime();
            DateTime dtTag;
            foreach (var lbl in tableLayoutPanel.Controls.OfType<Label>().Where(s => s.Tag != null && s.Text != "-"))
            {
                if (DateTime.TryParseExact(lbl.Tag.ToString(), "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtTag))
                {
                    if (dtTag != dtDefault)
                        lbl.Text = TimeAgoFromDateTime(dtTag);
                }
            }
        }
    }
}
