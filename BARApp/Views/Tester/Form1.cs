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

namespace BARApp.Views.Tester
{
    public partial class Form1 : Form
    {
        QuizletFactory factory;
        public Form1()
        {
            InitializeComponent();
            factory = new QuizletFactory();
            var uc = new ucQuizDetails(factory.GetQuizList());
            panel1.Controls.Add(uc);
        }
    }
}
