﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS200_Windows_Form144
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myListView.GridLines = true;
            myListView.FullRowSelect = true;

            myListView.Columns.Add("제품명", 150);
            myListView.Columns.Add("단가", 100, HorizontalAlignment.Right);
            myListView.Columns.Add("수량", 70, HorizontalAlignment.Right);
            myListView.Columns.Add("금액", 100, HorizontalAlignment.Right);

            ListViewItem item1 = new ListViewItem("Acess", 0);
            ListViewItem item2 = new ListViewItem("Excel", 1);
            ListViewItem item3 = new ListViewItem("PowerPoint", 2);
            ListViewItem item4 = new ListViewItem("Word", 3);

            item1.SubItems.Add("22,000");
            item1.SubItems.Add("30");
            item1.SubItems.Add("660,000");
            item2.SubItems.Add("33,000");
            item2.SubItems.Add("30");
            item2.SubItems.Add("1,650,000");
            item3.SubItems.Add("11,000");
            item3.SubItems.Add("50");
            item3.SubItems.Add("550,000");
            item4.SubItems.Add("22,000");
            item4.SubItems.Add("30");
            item4.SubItems.Add("660,000");

            myListView.Items.AddRange(new ListViewItem[]
            { item1, item2, item3,item4 });

            ImageList sImageList = new ImageList();
            sImageList.ImageSize = new Size(24, 24);
            ImageList lImageList = new ImageList();
            lImageList.ImageSize = new Size(64, 64);

            myListView.SmallImageList = sImageList;
            myListView.LargeImageList = lImageList;

            sImageList.Images.Add(Bitmap.FromFile(@"C:\Users\진시영\source\repos\CS200_Windows_Form144\CS200_Windows_Form144\..\Image\acess.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"C:\Users\진시영\source\repos\CS200_Windows_Form144\CS200_Windows_Form144\..\Image\excel.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"C:\Users\진시영\source\repos\CS200_Windows_Form144\CS200_Windows_Form144\..\Image\ppt.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"C:\Users\진시영\source\repos\CS200_Windows_Form144\CS200_Windows_Form144\..\Image\word.png"));

            lImageList.Images.Add(Bitmap.FromFile(@"C:\Users\진시영\source\repos\CS200_Windows_Form144\CS200_Windows_Form144\..\Image\acess.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"C:\Users\진시영\source\repos\CS200_Windows_Form144\CS200_Windows_Form144\..\Image\excel.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"C:\Users\진시영\source\repos\CS200_Windows_Form144\CS200_Windows_Form144\..\Image\ppt.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"C:\Users\진시영\source\repos\CS200_Windows_Form144\CS200_Windows_Form144\..\Image\word.png"));
        }
    }
}
