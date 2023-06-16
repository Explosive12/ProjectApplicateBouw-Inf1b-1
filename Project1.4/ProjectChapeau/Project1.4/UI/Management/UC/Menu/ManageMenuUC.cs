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

namespace Project1._4.UI.Management.UC
{
    public partial class ManageMenuUC : UserControl
    {
        private ManagerView _form;

        public ManageMenuUC(ManagerView form)
        {
            InitializeComponent();
            this._form = form;
        }

        // Refreshes the controls (buttons) in the panel
        private void RefreshMenuPanel()
        {
            panelProductsList.Controls.Clear();
            List<Product> products = GetAllProducts();
            foreach (Product product in products)
            {
                panelProductsList.Controls.Add(new ItemButtonUC(null, product));
            }
        }

        // Gets all products from the database
        private List<Product> GetAllProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllProducts();
            return products;
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            _form.GoBackToMainMenu();
        }

        private void buttonAddNewMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToAddOrAdjustMenuItem("ADD MENU ITEM", "ADD", null);
        }

        private void buttonAdjustMenuItem_Click(object sender, EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            NavigateToAddOrAdjustMenuItem("ADJUST MENU ITEM", "ADJUST", product);
        }

        private void NavigateToAddOrAdjustMenuItem(string typeofPanel, string buttonText, Product product)
        {
            _form.NavigateToAddOrAdjustMenuItem(typeofPanel, buttonText, product);
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
    }
}
