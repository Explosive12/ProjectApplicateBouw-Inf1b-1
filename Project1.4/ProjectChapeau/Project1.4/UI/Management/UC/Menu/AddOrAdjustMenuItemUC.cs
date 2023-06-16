using Project1._4.Model;
using Project1._4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project1._4.UI.Management.UC
{
    public partial class AddOrAdjustMenuItemUC : UserControl
    {
        private readonly ManagerView _form;
        private readonly Product _product;
        private AddItemUC productName = new AddItemUC("Name");
        private AddOrAdjustItemComboBoxUC _category = new AddOrAdjustItemComboBoxUC("Category", "ProductType");

        private AddItemUC _stock = new AddItemUC("Stock");


        public AddOrAdjustMenuItemUC(ManagerView form, string typeOfPanelMenuItemText, string buttonText, Product product)
        {
            InitializeComponent();
            this._form = form;
            this.labelMenuChange.Text = typeOfPanelMenuItemText;
            this.buttonAddOrAdjustMenuItem.Text = buttonText;

            AddControllers(product);
        }

        private void AddControllers(Product product)
        {
            if (product != null)
            {
                productName.Value = product.Name;
                _category.ChosenOption = product.Type.ToString();
                _stock.Value = product.Stock.ToString();
            }
            this.panelAddProductList.Controls.Add(productName);
            this.panelAddProductList.Controls.Add(_category);
            this.panelAddProductList.Controls.Add(_stock);
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            _form.GoBackToManageMenu();
        }

        private void AddOrAdjust_Click(object sender, EventArgs e)
        {
            if (productName.Value == "" || _category.ChosenOption == null || _stock.Value == "")
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }

            try
            {
                if (buttonAddOrAdjustMenuItem.Text == "ADJUST")
                    AdjustMenuItem();
                    
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Something went wrong while adding or adjusting {productName.Value}{exp.Message}");
            }
        }
        private void AdjustMenuItem()
        {
            ProductService productService = new ProductService();
            
        }

        private void AddMenuItem()
        {
            
        }
    }
}
