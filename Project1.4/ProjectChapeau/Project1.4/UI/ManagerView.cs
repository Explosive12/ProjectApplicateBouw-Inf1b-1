﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4.UI
{
    public partial class ManagerView : Form
    {
        public ManagerView()
        {
            InitializeComponent();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            this.panelManagerView.Controls.Add(new ManagerViewForm());
        }
    }
}
