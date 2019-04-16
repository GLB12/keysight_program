using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormstest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Choose S2p file
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*s2p*)|*.s2p*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径    
                textBox1.Text = file;
            }
        }

        //Parameter Range Chack 
        private bool Para_Chack()
        {
            if(numericUpDown1.Value<0)
            {
                MessageBox.Show("Please chack Para1","Parameter Error");
                return false;
            }
            return true;
        }

        //Parameter Extract
        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter setup_file = new System.IO.StreamWriter("setup.txt");
            string[] para=new string[2];
            para[0]= numericUpDown1.Text;
            para[1] = textBox1.Text;
            int index = 0;
            string[] lines = System.IO.File.ReadAllLines("setup_template.txt");
            if(Para_Chack())
            {
                foreach(string line in lines)
                {
                    if(line.Contains("Parameter"))
                    {
                        string temp_line=line.Replace("Parameter", para[index]);
                        setup_file.WriteLine(temp_line);
                        ++index;
                    }
                    else
                        setup_file.WriteLine(line);
                }
                setup_file.Close();
            }
        }
    }
}
