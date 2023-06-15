using Project1._4.Model;


namespace Project1._4.UI
{
    public partial class UserEmployeeUC : UserControl
    {

        private Color selectedColor = Color.FromArgb(255, 128, 0);
        private Color unSelectedColor = SystemColors.ActiveBorder;
        public bool IsSelected
        {
            get
            {
                return buttonSelectOption.BackColor == selectedColor;
            }
        }

        public Employee Employee { get; internal set; }

        public UserEmployeeUC(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            buttonSelectOption.Text = employee.Username;
            textBoxType.Text = employee.Function.ToString();
        }


        private void textBoxType_TextChanged(object sender, EventArgs e)
        {

        }

        private void OptionSelected(object sender, EventArgs e)
        {
            foreach (UserEmployeeUC userEmployeeUC in Parent.Controls.OfType<UserEmployeeUC>())
            {
                userEmployeeUC.buttonSelectOption.BackColor = unSelectedColor;
            }

            this.buttonSelectOption.BackColor = selectedColor;
        }
    }

}
