using BAR.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARApp.uc
{
    public partial class ucQuizDetails : UserControl
    {
        public List<QuizletModel> _model;
        public List<QuizletModel> Model { get { return _model; } set { _model = value; } }

        public ucQuizDetails(List<QuizletModel> model)
        {
            InitializeComponent();
            _model = model;

            //lblType.Text = model.ActivityType;
            //lblCreatedDate.Text = TimeAgoFromDateTime(model.CreatedDate);
            //lblUpdatedDate.Text = model.CreatedDate != model.LastUpdatedDate ? TimeAgoFromDateTime(model.LastUpdatedDate) : "-";
            //lblPostedDate.Text = model.PostedDate != null ? TimeAgoFromDateTime(model.PostedDate.Value) : "-";
            //lblGrade.Text = model.Grade;
            //lblSchoolYear.Text = model.SchoolYearDesc;

            int count = 1;
            foreach (var m in model)
            {

                //tableLayoutPanel.RowStyles.Add(new RowStyle());

                tableLayoutPanel.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Location = new Point(81, 0),
                    Size = new Size(128, 35),
                    Text = m.ActivityType,
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 0, count);

                tableLayoutPanel.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Location = new Point(81, 0),
                    Size = new Size(128, 35),
                    Text = TimeAgoFromDateTime(m.CreatedDate),
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 1, count);

                tableLayoutPanel.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Location = new Point(81, 0),
                    Size = new Size(128, 35),
                    Text = m.CreatedDate != m.LastUpdatedDate ? TimeAgoFromDateTime(m.LastUpdatedDate) : "-",
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 2, count);

                tableLayoutPanel.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Location = new Point(81, 0),
                    Size = new Size(128, 35),
                    Text = m.PostedDate != null ? TimeAgoFromDateTime(m.PostedDate.Value) : "-",
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 3, count);

                tableLayoutPanel.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Location = new Point(81, 0),
                    Size = new Size(128, 35),
                    Text = m.Grade,
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 4, count);

                tableLayoutPanel.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Location = new Point(81, 0),
                    Size = new Size(128, 35),
                    Text = m.SchoolYearDesc,
                    TextAlign = ContentAlignment.MiddleCenter,
                }, 5, count);

                tableLayoutPanel.Controls.Add(new Button()
                {
                    BackColor = Color.Gold,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Size = new Size(40, 29),
                    Text = "✏️",
                    UseVisualStyleBackColor = false
                }, 6, count);

                tableLayoutPanel.Controls.Add(new Button()
                {
                    BackColor = Color.FromArgb(0, 192, 0),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Size = new Size(40, 29),
                    Text = "📌",
                    UseVisualStyleBackColor = false
                }, 7, count);

                tableLayoutPanel.Controls.Add(new Button()
                {
                    BackColor = Color.Red,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Size = new Size(40, 29),
                    Text = "❌",
                    UseVisualStyleBackColor = false
                }, 8, count);

                count++;
                this.Height += 35;

            }
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
                return inputDate.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
    }
}
