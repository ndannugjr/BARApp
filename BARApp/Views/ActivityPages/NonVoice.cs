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
    public partial class NonVoice : Form
    {
        List<QuestionAnswer> _qa;
        public NonVoice(List<QuestionAnswer> qa)
        {
            InitializeComponent();
            _qa = qa;

            int count = 2;
            int itemNoCount = 1;
            foreach (var q in qa.OrderBy(o => o.ActivityVoiceNonVoiceDetailId))
            {
                q.ItemNo = itemNoCount++;
                var ucNonVoiceCard = new ucNonVoiceCard(q);
                ucNonVoiceCard.Dock = DockStyle.Top;

                tlpContent.RowStyles.Add(new RowStyle());
                tlpContent.Controls.Add(ucNonVoiceCard, 0, count++);
            }
        }

        private void btnChangeVoice_Click(object sender, EventArgs e)
        {
            foreach (var ucNv in tlpContent.Controls.OfType<ucNonVoiceCard>())
            {
                foreach (var tlp in ucNv.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (var ucSc in tlp.Controls.OfType<ucSpeechControl>())
                    {
                        ucSc.IsMaleVoice = !ucSc.IsMaleVoice;
                    }
                }
            }
        }
    }
}
