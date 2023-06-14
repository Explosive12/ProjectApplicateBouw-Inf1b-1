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

namespace Project1._4.UI
{
    public partial class UserEmployeeUC : UserControl
    {
        public UserEmployeeUC(string userName, EmployeeType employeeType)
        {
            InitializeComponent();
            buttonEmployee.Text = userName;
            textBoxType.Text = employeeType.ToString();
        }

    }

}
