using Project1._4.Model;
using Project1._4.Service;
using Project1._4.UI;

namespace Project1._4
{
    public partial class MainMenuUC : UserControl
    {
        private ManagerView _form;
        private string _currentEmployeeName;

        public MainMenuUC(ManagerView form, string username)
        {
            _currentEmployeeName = username;

            InitializeComponent();
            labelUserName.Text = _currentEmployeeName;
            _form = form;
        }

        private void NavigateToMenu(object sender, EventArgs e)
        {
            _form.NavigateToMenu();
        }

        private void NavigateToEmployee(object sender, EventArgs e)
        {
            _form.NavigateToEmployee();
        }
        private void ButtonToTableViewClick(object sender, EventArgs e)
        {
            _form.NavigateToTableView();
        }

        private void MainMenuUC_Load(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            List<Income> income = orderService.GetPriceFromLast2Months();

            if (income.Count > 0)
            {
                labelLastMonth.Text = GetMonthName(income[0].Month) + "(ex VAT)";
                labelLastMonthIncome.Text = income[0].Total.ToString("C");
            }
            if (income.Count > 1)
            {
                labelThisMonth.Text = GetMonthName(income[1].Month) + "(ex VAT)";
                labelThisMonthIncome.Text = income[1].Total.ToString("C");
            }
        }

        private static string GetMonthName(int month)
        {
            return new DateTime(2020, month, 1).ToString("MMMM");
        }


    }
}
