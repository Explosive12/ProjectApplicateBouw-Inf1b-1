using Project1._4.Model;


namespace Project1._4.UI
{
    public partial class ItemButtonUC : UserControl
    {

        private Color selectedColor = Color.FromArgb(255, 128, 0);
        private Color unSelectedColor = SystemColors.ActiveBorder;
        private Color lowStockColor = Color.FromArgb(245, 108, 117);
        public bool IsSelected
        {
            get
            {
                return buttonSelectOption.BackColor == selectedColor;
            }
        }

        public Employee Employee { get; internal set; }
        public Product Product { get; internal set; }

        public ItemButtonUC(Employee employee = null, Product product = null)
        {
            InitializeComponent();


            Employee = employee;
            Product = product;

            if (employee != null)
            {
                SetEmployee(employee);
            }
            else if (product != null)
            {
                SetProduct(product);
            }

        }

        public void SetEmployee(Employee employee)
        {
            buttonSelectOption.Text = employee.Username;
            textBoxStock.Text = employee.Function.ToString();
        }

        public void SetProduct(Product product)
        {
            buttonSelectOption.Text = product.Name;
            textBoxStock.Text = product.Stock.ToString();
            if (product.Stock == 1)
            {
                textBoxStock.BackColor = lowStockColor;
            }
        }

        private void OptionSelected(object sender, EventArgs e)
        {
            foreach (ItemButtonUC userItemUC in Parent.Controls.OfType<ItemButtonUC>())
            {
                userItemUC.buttonSelectOption.BackColor = unSelectedColor;
            }

            this.buttonSelectOption.BackColor = selectedColor;
        }
    }

}
