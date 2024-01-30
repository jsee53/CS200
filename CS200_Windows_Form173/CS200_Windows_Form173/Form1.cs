using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS200_Windows_Form173
{
    public partial class Form1 : Form
    {
        private bool modifyFlag = false;
        private string fileName = "noname.txt";
        public Form1()
        {
            InitializeComponent();
            this.Text = fileName + " - myNotePad";
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            modifyFlag = true;
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();

            txtMemo.Text = "";
            modifyFlag = false;
            fileName = "noname.txt";
        }

        private void FileProcessBeforeClose()
        {
            if (modifyFlag == true)
            {
                DialogResult ans = MessageBox.Show("변경된 내용을 저장하겠습니까?",
                    "저장", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    if (fileName == "noname.txt")
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                            sw.WriteLine(txtMemo.Text);
                            sw.Close();
                        }
                    }
                    else
                    {
                        StreamWriter sw = File.CreateText(fileName);
                        sw.WriteLine(txtMemo.Text);
                        sw.Close();
                    }
                }
            }
        }
    }
}
