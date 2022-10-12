using System;
using System.IO;
using System.Windows.Forms;

namespace FileDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void WriteFairyToFile(string _fairyName, string _fairyAge, 
            string _fairyHeight, string _fairyPlanet, string _fairyMagic,
            string _fairyActions, string _fairyState)
        {
            string folder = @"C:\Temp\";
            string fileName = "WinxDB.txt";
            string fullPath = folder + fileName;
            string[] fairy = {_fairyName,_fairyAge,_fairyHeight,_fairyPlanet,
            _fairyMagic,_fairyActions,_fairyState};
            File.WriteAllLines(fullPath, fairy);
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
            string errMsg = "";
            bool gotError = false;

            fairyName = textBox1.Text;
            fairyAge = (int)numericUpDown1.Value;
            fairyHeight = (int)numericUpDown2.Value;
            fairyPlanet = textBox2.Text;
            fairyMagic = textBox3.Text;
            fairyActions = textBox4.Text;
            fairyState = textBox5.Text;

            if (fairyName.Length < 3)
            {
                gotError = true;
                errMsg += "Имя феи введено некорректно. ";
            }
            if (fairyAge == 0)
            {
                gotError = true;
                errMsg += "Фея еще не родилась. ";
            }
            if (fairyHeight == 100)
            {
                gotError = true;
                errMsg += "Фея очень маленькая. ";
            }
            if (fairyPlanet.Length < 3)
            {
                gotError = true;
                errMsg += "Название планеты очень короткое. ";
            }
            if (fairyMagic.Length < 3)
            {
                gotError = true;
                errMsg += "Описание магии очень короткое. ";
            }
            if (fairyActions.Length < 3)
            {
                gotError = true;
                errMsg += "Описание деятельности очень короткое. ";
            }
            if (fairyState.Length < 3)
            {
                gotError = true;
                errMsg += "Описание статуса очень короткое. ";
            }
            if (gotError)
            {
                MessageBox.Show(errMsg);
                gotError = false;
            }

            if (!gotError)//записать в файл только если нет ошибок
            {
                WriteFairyToFile(fairyName,fairyAge.ToString(),fairyHeight.ToString()
                    ,fairyPlanet,fairyMagic,fairyActions,fairyState);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //WriteFairyToFile();
        }
    }
}
