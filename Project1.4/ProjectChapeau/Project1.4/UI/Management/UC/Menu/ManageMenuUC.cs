using Project1._4.Model;
using Project1._4.Service;

namespace Project1._4.UI.Management.UC
{
    public partial class ManageMenuUC : UserControl
    {
        private const int stockWidth = 30;
        private ManagerView _form;

        public ManageMenuUC(ManagerView form)
        {
            InitializeComponent();
            _form = form;
        }

        // Refreshes the controls (buttons) in the panel
        private void RefreshMenuPanel()
        {
            panelProductsList.Controls.Clear();
            List<Product> products = GetAllProducts();
            foreach (Product product in products)
            {
                ItemButtonUC control = new ItemButtonUC(null, product);
                control.TextboxSize = stockWidth; //small size for textbox so that label can be a long text
                panelProductsList.Controls.Add(control);
            }
        }

        // Gets all products from the database
        private List<Product> GetAllProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllProducts();
            return products;
        }

        private void ButtonGoBackClick(object sender, EventArgs e)
        {
            _form.GoBackToMainMenu();
        }

        private void ButtonAddNewMenuItemClick(object sender, EventArgs e)
        {
            _form.NavigateToAddOrAdjustMenuItem("ADD MENU ITEM", "ADD", null);
        }

        private void ButtonAdjustMenuItemClick(object sender, EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            _form.NavigateToAddOrAdjustMenuItem("ADJUST MENU ITEM", "ADJUST", product);
        }

        private void ManageMenuOnLoad(object sender, EventArgs e)
        {
            RefreshMenuPanel();
        }

        // Loops through all buttons to see which one is selected, if none is selected it return null 
        private Product GetSelectedProduct()
        {
            foreach (ItemButtonUC productItemUC in panelProductsList.Controls.OfType<ItemButtonUC>())
            {
                if (productItemUC.IsSelected)
                    return productItemUC.Product;
            }
            return null!;
        }

        private void ButtonRemoveClick(object sender, EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            
            ProductService service = new ProductService();
            service.DeleteProduct(product);
            
            RefreshMenuPanel();
        }
    }
}
