using BAR.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARApp.Views.Modal
{
    public partial class ActivityModal : Form
    {
        private QuizletModel _model;
        public ActivityModal(QuizletModel model)
        {
            InitializeComponent();
            _model = model;
        }
    }
}
