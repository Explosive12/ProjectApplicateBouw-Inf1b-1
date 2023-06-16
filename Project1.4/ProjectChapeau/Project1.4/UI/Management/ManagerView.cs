using Project1._4.Model;
using Project1._4.UI.Management;
using Project1._4.UI.Management.UC;
using Project1._4.UI.Management.UC.Menu;
using System;
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

        internal void GoBackToMainMenu()
        {
            this.panelManagerView.Controls.Clear();
            this.panelManagerView.Controls.Add(new MainMenuUC(this));
        }

        internal void GoBackToManageMenu()
        {
            this.panelManagerView.Controls.Clear();
            this.panelManagerView.Controls.Add(new ManageMenuUC(this));
        }

        internal void NavigateToAddOrAdjustMenuItem(string typeOfPanel, string buttonText, Product product)
        {
            this.panelManagerView.Controls.Clear();
            this.panelManagerView.Controls.Add(new AddOrAdjustMenuItemUC(this, typeOfPanel, buttonText, product));
        }

        internal void NavigateToAddOrAdjustEmployee(string typeOfPanel, string buttonText,Employee employee)
        {
            this.panelManagerView.Controls.Clear();
            this.panelManagerView.Controls.Add(new AddOrAdjustEmployeeUC(this, typeOfPanel, buttonText, employee));
        }

        internal void NavigateToEmployee()
        {
            this.panelManagerView.Controls.Clear();
            this.panelManagerView.Controls.Add(new EmployeeManagementUC(this));
        }

        internal void NavigateToMenu()
        {
            this.panelManagerView.Controls.Clear();
            this.panelManagerView.Controls.Add(new ManageMenuUC(this));
    }

        internal void NavigateToStockManagement()
        {
            this.panelManagerView.Controls.Clear();
            this.panelManagerView.Controls.Add(new StockManagementUC(this));
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            this.panelManagerView.Controls.Add(new MainMenuUC(this));
        }
    }
}
