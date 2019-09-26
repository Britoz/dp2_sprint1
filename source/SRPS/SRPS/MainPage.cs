﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPS.View
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            SalesRecord salesRecord = new SalesRecord();
            salesRecord.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            SaleReport salesReport = new SaleReport();
            salesReport.Show();
        }
    }
}
