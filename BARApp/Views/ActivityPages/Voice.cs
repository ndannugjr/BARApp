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
    public partial class Voice : Form
    {
        List<QuestionAnswer> _qa;
        public Voice(List<QuestionAnswer> qa)
        {
            InitializeComponent();
            _qa = qa;

            int count = 1;
            int itemNoCount = 1;
            foreach (var q in qa.OrderBy(o => o.ActivityVoiceNonVoiceDetailId))
            {
                q.ItemNo = itemNoCount++;
                var ucVoiceCard = new ucVoiceCard(q);
                ucVoiceCard.Dock = DockStyle.Top;

                tlpContent.RowStyles.Add(new RowStyle());
                tlpContent.Controls.Add(ucVoiceCard, 0, count++);
            }
        }
    }
}
