using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4.UI.Management.UC
{
    public partial class ManageMenuUC : UserControl
    {
        private ManagerView form;

        public ManageMenuUC(ManagerView form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            form.GoBackToMainMenu();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            form.NavigateToAddMenuItem();
        }

        private void buttonAdjust_Click(object sender, EventArgs e)
        {
            form.NavigateToAddMenuItem();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            form.NavigateToStockManagement();
        }
    }
}
