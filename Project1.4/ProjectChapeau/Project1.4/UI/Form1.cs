using Project1._4.UI;

namespace Project1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginview_Click(object sender, EventArgs e)
        {
            LoginView loginview = new LoginView();
            Form1 form1 = new Form1();

            loginview.Show();
            form1.Close();
        }
    }
}