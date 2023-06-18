using Project1._4.Model;
using Project1._4.UI.Management;
using Project1._4.UI.Management.UC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project1._4.UI
{
    public partial class ManagerView : Form
    {
        private Control.ControlCollection _panelControls;
        private string _username;

        public ManagerView(string username)
        {
            InitializeComponent();
            _panelControls = panelManagerView.Controls;
            _username = username;
        }

        internal void GoBackToMainMenu()
        {
            ClearPanel();
            _panelControls.Add(new MainMenuUC(this, _username));
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

        internal void NavigateToAddOrAdjustEmployee(string typeOfPanel, string buttonText, Employee employee)
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

        private void ManagerView_Load(object sender, EventArgs e)
        {
            _panelControls.Add(new MainMenuUC(this, _username));
        }

        private void ClearPanel()
        {
            _panelControls.Clear();
        }
        
        internal void NavigateToTableView()
        {
            this.Hide();
            TableView tableView = new TableView(_username);
            tableView.Show();
        }
    }
}
