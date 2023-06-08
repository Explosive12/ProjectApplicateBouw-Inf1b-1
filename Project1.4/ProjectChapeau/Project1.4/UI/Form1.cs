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

        private void btnBarResOverview_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            LoginView loginview = new LoginView(); 
            BarKitchenView barKitchenView = new BarKitchenView();
            Form1 form1 = new Form1();
            
            // Show the new form
            barKitchenView.Show();
            loginview.Show();

            ///doesnt close it
            form1.Close();

        }
    }
}