using BAR.Core.Models;
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

namespace BARApp.Views.ActivityPages
{
    public partial class ReadingCompre : Form
    {
        public ReadingCompre(ReadingComprehension model)
        {
            InitializeComponent();

            lblContent.Text = string.Format("{0}\n\n{1}", model.Title, model.Description);

            int count = 2;
            foreach (var q in model.Questions.OrderBy(o => o.ItemNo))
            {
                var ucReadingCompre = new ucReadingCompreQuestionCard(q);
                ucReadingCompre.Dock = DockStyle.Top;

                tlpContent.RowStyles.Add(new RowStyle());
                tlpContent.Controls.Add(ucReadingCompre, 0, count++);
            }
        }
    }
}
