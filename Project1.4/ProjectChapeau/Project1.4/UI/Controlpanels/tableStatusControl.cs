﻿using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4
{
    public partial class tableStatusControl : UserControl
    {
        public tableStatusControl(int tableId)
        {
            InitializeComponent();
            lblTableIdStatusControl.Text = tableId.ToString();
        }
        private void Back(object sender , EventArgs e)
        {
            this.Hide();
        }
    }
}