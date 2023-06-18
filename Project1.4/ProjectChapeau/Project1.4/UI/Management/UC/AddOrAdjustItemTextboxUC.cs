namespace Project1._4.UI.Management.UC
{
    public partial class AddItemUC : UserControl
    {

        public string Value
        {
            get
            {
                return textBoxAddItem.Text;
            }
            set
            {
                textBoxAddItem.Text = value;
            }
        }

        public AddItemUC(string label, bool isPassword = false)
        {
            InitializeComponent();

            labelAddItem.Text = label;
            if (isPassword)
                textBoxAddItem.PasswordChar = '*';
        }
    }
}
