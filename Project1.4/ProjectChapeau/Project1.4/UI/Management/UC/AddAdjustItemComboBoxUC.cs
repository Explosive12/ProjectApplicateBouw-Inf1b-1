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
    public partial class AddAdjustItemComboBoxUC : UserControl
    {
        private string enumType;

        // public string to get the chosen option
        public int ChosenOption
        {
            get
            {
                return comboBoxType.SelectedIndex;
            }
        }

        public AddAdjustItemComboBoxUC(string label, string enumType)
        {
            InitializeComponent();

            this.labelAddComboBoxItem.Text = label;
            this.enumType = enumType;
        }


        // Fill Combobox with the enum options
        private void FillComboBox(object sender, EventArgs e)
        {
            comboBoxType.SelectedValue = "Hi";
            switch (enumType)
            {
                case "EmployeeType":
                    foreach (string role in Enum.GetNames(typeof(EmployeeType)))
                    {
                        comboBoxType.Items.Add(role);
                    }
                    break;
                case "MenuType":
                    foreach (string menu in Enum.GetNames(typeof(MenuType)))
                    {
                        comboBoxType.Items.Add(menu);
                    }
                    break;
                case "ProductType":
                    foreach (string category in Enum.GetNames(typeof(ProductType)))
                    {
                        comboBoxType.Items.Add(category);
                    }
                    break;
                default:
                    throw new Exception("The enum for this does not exist in here");
            }


        }
    }
}
