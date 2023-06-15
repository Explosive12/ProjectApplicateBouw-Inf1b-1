﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4.UI.Management.UC.Menu
{
    public partial class StockManagementUC : UserControl
    {
        private ManagerView form;

        public StockManagementUC(ManagerView form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            form.GoBackToManageMenu();
        }
    }
}
