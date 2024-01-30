﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS200_Windows_Form132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string raffaello = "라파엘로 산치오, 이탈리아, 르네상스 3대 거장, 1483~1520";
            string schoolOfAthens = "라파엘로(Raphael,Raffaello Sanzio da Urbino)는 " +
                "동시대의 대가인 미켈란젤로, 레오나르도 다빈치와 함께 르네상스 3대 거장으로 " +
                "알려져 있습니다. 가장 유명한 작품은 <아테네학당(The School of Athens)>으로 " +
                "바티칸궁(Apostolic Palace)에 있는 프레스코 벽화 입니다.\n";

            label1.Text = raffaello;
            label2.Text = schoolOfAthens;
        }
    }
}
