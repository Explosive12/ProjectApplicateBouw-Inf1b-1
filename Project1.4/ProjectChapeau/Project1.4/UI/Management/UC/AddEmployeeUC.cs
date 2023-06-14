using Project1._4.Model;
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
    public partial class AddEmployeeUC : UserControl
    {
        private ManagerView form;

        public AddEmployeeUC(ManagerView form)
        {
            InitializeComponent();
            this.form = form;

            this.panelAddEmployee.Controls.Add(new AddItemUC("Name"));
            this.panelAddEmployee.Controls.Add(new AddItemUC("Role"));
            this.panelAddEmployee.Controls.Add(new AddItemUC("Password"));

        }

        private void GoBackToEmployee(object sender, EventArgs e)
        {
            form.NavigateToEmployee();
        }
    }
}
