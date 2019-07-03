using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

delegate int NumberChanger(int n);
namespace GitHubTest617
{
    public partial class Form1 : Form
    {
        public int Total;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyClass _classy = new MyClass();

            _classy.Count(MethodtoPass, Complete);
            
        }

        public void MethodtoPass(int value)
        {
            label1.Text = value.ToString();
        }

        public void Complete()
        {
            MessageBox.Show("Complete!");

        }
    }
}
