using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security;

namespace CS200_Windows_Form153
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;
        public Form1()
        {
            InitializeComponent();

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "Select a text file";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.Title = "Open text file";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message:{ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
