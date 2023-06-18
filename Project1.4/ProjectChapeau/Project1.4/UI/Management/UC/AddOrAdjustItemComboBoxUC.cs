using Project1._4.Model;


namespace Project1._4.UI.Management.UC
{
    public partial class AddOrAdjustItemComboBoxUC : UserControl
    {
        private string[] roles = Enum.GetNames(typeof(EmployeeType));
        private string[] categories = Enum.GetNames(typeof(ProductType));
        // public string to get the chosen option
        public string ChosenOption
        {
            get
            {
                return (string)comboBoxType.SelectedItem;
            }
            set
            {
                comboBoxType.SelectedItem = value;
            }
        }

        public AddOrAdjustItemComboBoxUC(string label, string enumType)
        {
            InitializeComponent();

            this.labelAddComboBoxItem.Text = label;
            FillComboBox(GetNames(enumType));
        }

        // Fill Combobox with the enum options
        private void FillComboBox(string[] enumNames)
        {
            foreach (string name in enumNames)
                comboBoxType.Items.Add(name);
        }
        
        private string[] GetNames(string enumType)
        {
            return enumType switch
            {
                "EmployeeType" => roles,
                "ProductType" => categories,
                _ => throw new Exception("The enum for this does not exist in here"), // _ = default
            };
        }
    }
}
