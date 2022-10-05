using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fairyName;
            int fairyAge;
            int fairyHeight;
            string fairyPlanet;
            string fairyMagic;
            string fairyActions;
            string fairyState;

            fairyName = textBox1.Text;
            fairyAge = (int)numericUpDown1.Value;
            fairyHeight = (int)numericUpDown2.Value;
            fairyPlanet = textBox2.Text;
            fairyMagic = textBox3.Text;
            fairyActions = textBox4.Text;
            fairyState = textBox5.Text;
        }
    }
}
