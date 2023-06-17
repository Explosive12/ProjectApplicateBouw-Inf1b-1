using Project1._4.Model;
using Project1._4.UI.Management;
using Project1._4.UI.Management.UC;
using Project1._4.UI.Management.UC.Menu;

namespace Project1._4.UI
{
    public partial class ManagerView : Form
    {
        private Control.ControlCollection _panelControls;

        public ManagerView()
        {
            InitializeComponent();
            _panelControls = panelManagerView.Controls;
        }

        internal void GoBackToMainMenu()
        {
            ClearPanel();
            _panelControls.Add(new MainMenuUC(this));
        }

        internal void GoBackToManageMenu()
        {
            ClearPanel();
            _panelControls.Add(new ManageMenuUC(this));
        }

        internal void NavigateToAddOrAdjustMenuItem(string typeOfPanel, string buttonText, Product product)
        {
            ClearPanel();
            _panelControls.Add(new AddOrAdjustMenuItemUC(this, typeOfPanel, buttonText, product));
        }

        internal void NavigateToAddOrAdjustEmployee(string typeOfPanel, string buttonText,Employee employee)
        {
            ClearPanel();
            _panelControls.Add(new AddOrAdjustEmployeeUC(this, typeOfPanel, buttonText, employee));
        }

        internal void NavigateToEmployee()
        {
            ClearPanel();
            _panelControls.Add(new EmployeeManagementUC(this));
        }

        internal void NavigateToMenu()
        {
            ClearPanel();
            _panelControls.Add(new ManageMenuUC(this));
    }

        internal void NavigateToStockManagement()
        {
            ClearPanel();
            _panelControls.Add(new StockManagementUC(this));
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            _panelControls.Add(new MainMenuUC(this));
        }

        private void ClearPanel()
        {
            _panelControls.Clear();
        }
    }
}
