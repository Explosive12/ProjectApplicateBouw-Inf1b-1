using Project1._4.Model;
using Project1._4.Service;

namespace Project1._4.UI.Management.UC
{
    public partial class AddOrAdjustMenuItemUC : UserControl
    {
        private readonly Product _product;
        private readonly ManagerView _form;
        private readonly AddItemUC _stock = new AddItemUC("Stock");
        private readonly AddItemUC _price = new AddItemUC("Price");
        private readonly AddItemUC _productName = new AddItemUC("Name");
        private readonly AddOrAdjustItemComboBoxUC _category = new AddOrAdjustItemComboBoxUC("Category", "ProductType");


        public AddOrAdjustMenuItemUC(ManagerView form, string typeOfPanelMenuItemText, string buttonText, Product product)
        {
            InitializeComponent();
            _form = form;
            _product = product;
            labelMenuChange.Text = typeOfPanelMenuItemText;
            buttonAddOrAdjustMenuItem.Text = buttonText;

            FillPanel(product);
        }

        private void FillPanel(Product product)
        {
            if (product != null)
            {
                _productName.Value = product.Name;
                _category.ChosenOption = product.Type.ToString();
                _price.Value = product.Price.ToString();
                _stock.Value = product.Stock.ToString();
            }
            panelAddProductList.Controls.Add(_productName);
            panelAddProductList.Controls.Add(_price);
            panelAddProductList.Controls.Add(_category);
            panelAddProductList.Controls.Add(_stock);
        }

        private void ButtonGoBackClick(object sender, EventArgs e)
        {
            _form.GoBackToManageMenu();
        }

        private void AddOrAdjustClick(object sender, EventArgs e)
        {
            try
            {
                if (_productName.Value == "" || _category.ChosenOption == null || _stock.Value == "")
                {
                    MessageBox.Show("Please fill in all the fields");
                    return;
                }
                if (_product != null)
                    AdjustMenuItem();
                else
                    AddMenuItem();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Something went wrong while adding or adjusting {_productName.Value}{exp.Message}");
            }
        }

        private void AdjustMenuItem()
        {
            ProductType productType = (ProductType)Enum.Parse(typeof(ProductType), _category.ChosenOption);
            decimal vat = GetVatPercentage(productType);
            Product product = new Product(_product.ProductId, _productName.Value, decimal.Parse(_price.Value), int.Parse(_stock.Value), vat, productType);
            ProductService productService = new ProductService();
            productService.UpdateProduct(product);

            _form.NavigateToMenu();
        }

        private void AddMenuItem()
        {
            ProductType productType = (ProductType)Enum.Parse(typeof(ProductType), _category.ChosenOption);
            decimal vat = GetVatPercentage(productType);
            Product product = new Product(0, _productName.Value, decimal.Parse(_price.Value), int.Parse(_stock.Value), vat, productType);
            ProductService productService = new ProductService();
            productService.AddProduct(product);

            _form.NavigateToMenu();
        }

        private decimal GetVatPercentage(ProductType productType)
        {
            if (productType == ProductType.Spirit || productType == ProductType.Wine || productType == ProductType.Beer)
                return 21;
            return 9;
        }


    }
}
