using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS200_Windows_Form142
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            foreach (var city in cLstBox.CheckedItems)
                lstBox.Items.Add(city);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (var city in cLstBox.Items)
                lstBox.Items.Add(city);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<string> lstRemove = new List<string>();

            foreach (string city in lstBox.SelectedItems)
                lstRemove.Add(city);

            foreach (string city in lstRemove)
                lstBox.Items.Remove(city);
        }

        private void btnDeAll_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }
    }
}
