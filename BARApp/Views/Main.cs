using BAR.Core.Classes;
using BAR.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BARApp.Views
{
    public partial class Main : Form
    {
        private static Main _instance;
        public Main()
        {
            InitializeComponent();
            _instance = this;
            InitializeButtons(RuntimeInfo.Menu);
        }

        public static void DisplayForm(Form frm)
        {
            foreach (var pnl in _instance.pnlContent.Controls.OfType<Panel>())
            {
                pnl.Visible = false;
            }
            foreach (var form in _instance.pnlContent.Controls.OfType<Form>())
            {

                if (frm == null)
                {
                    form.Close();
                    return;
                }

                if (form.Name != frm.Name)
                    form.Close();
                else
                    return;
            }

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            _instance.pnlContent.Controls.Add(frm);
        }

        private static void SetActiveBtn(Button btn)
        {
            btn.BackColor = Color.FromArgb(192, 255, 255);

            foreach (var button in _instance.pnlMenu.Controls.OfType<Button>()
                .Where(x => x.Name != btn.Name))
            {
                button.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void InitializeButtons(List<MenuNavigation> menu)
        {
            foreach (MenuNavigation m in menu)
            {
                Button btn = new Button()
                {
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    BackColor = Color.FromArgb(255, 255, 255),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.DimGray,
                    Location = new Point(15, 85),
                    Margin = new Padding(0, 0, 0, 10),
                    Name = "btn" + Regex.Replace(m.Title, @"\s+", ""),
                    Size = new Size(340, 60),
                    TabIndex = 6,
                    Text = m.Title.ToUpper(),
                    UseVisualStyleBackColor = false
                };

                btn.FlatAppearance.BorderColor = Color.FromArgb(68, 114, 196);
                btn.Click += Btn_Click;

                pnlMenu.RowStyles.Add(new RowStyle());
                pnlMenu.Controls.Add(btn, 0, m.MenuOrder);

                if (m.MenuOrder == 1)
                {
                    SetActiveBtn(btn);
                    DisplayForm(new Dashboard());
                }
            };

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                Button btn = (Button)sender;
                SetActiveBtn(btn);
                if (btn.Name == "btnDashboard")
                    DisplayForm(new Dashboard());
                else if (btn.Name == "btnQuizlet")
                    DisplayForm(new Quizlet());
                else if (btn.Name == "btnDBViewer")
                    DisplayForm(new DbViewer());
                else if (btn.Name == "btnActivities")
                    DisplayForm(new Activities());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
