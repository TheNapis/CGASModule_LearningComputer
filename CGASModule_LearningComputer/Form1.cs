using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CGASModule_LearningComputer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            presentation1.Visible = false;
        }

        private void Button_Module1_Click(object sender, EventArgs e)
        {
            Button_Module1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            presentation1.Visible = true;
        }
    }
}
