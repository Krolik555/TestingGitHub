using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTest617
{
    public partial class Form1 : Form
    {
        public int num = 6;
        public string word = "6";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Utility.CompareValue(1,1.1f).ToString();
            label1.Text = Utility.CompareType("cat", "fish").ToString();
        }

    }
}
