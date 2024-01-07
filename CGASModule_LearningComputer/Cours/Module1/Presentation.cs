using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGASModule_LearningComputer.Cours.Module1
{
    public partial class Presentation : UserControl
    {
        public Presentation()
        {
            InitializeComponent();
            ReturnPage_Button.Visible = false;
            NextPage_Button.Visible = false;
            page11.Visible = false;
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Module_Start_Click(object sender, EventArgs e)
        {
            ReturnPage_Button.Visible = true;
            NextPage_Button.Visible = true;
            Module_Start.Visible = false;
            Return_Button.Visible = false;
            page11.Visible = true;
            pictureBox1.Visible = false;
            label2.Visible = false;
        }
    }
}
