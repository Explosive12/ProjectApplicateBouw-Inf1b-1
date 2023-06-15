using Project1._4.Model;


namespace Project1._4.UI.Management.UC
{
    public partial class AddAdjustItemComboBoxUC : UserControl
    {
        private string enumType;

        // public string to get the chosen option
        public string ChosenOption
        {
            get
            {
                return (string)comboBoxType.SelectedItem;
            }
            set { comboBoxType.SelectedItem = value; }
        }

        public AddAdjustItemComboBoxUC(string label, string enumType)
        {
            InitializeComponent();

            this.labelAddComboBoxItem.Text = label;
            this.enumType = enumType;
            FillComboBox();
        }


        // Fill Combobox with the enum options
        private void FillComboBox()
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
