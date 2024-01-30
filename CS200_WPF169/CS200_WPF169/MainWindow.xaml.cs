using Microsoft.Win32;
using System;
using System.Windows;

namespace CS200_WPF169
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\진시영\source\repos\CS200_Windows_Form144";
            ofd.Multiselect = true;
            var result = ofd.ShowDialog();
            if (result == true) // Check if the user clicked "OK"
            {
                foreach (var s in ofd.FileNames)
                {
                    lbFiles.Items.Add(s);
                }
            }
        }
    }
}
