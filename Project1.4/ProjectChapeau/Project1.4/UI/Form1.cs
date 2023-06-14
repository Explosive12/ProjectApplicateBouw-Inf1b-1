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
            BarKitchenView barKitchenView = new BarKitchenView();

            // Show the new form
            barKitchenView.Show();

            ///doesnt close it
            this.Hide();

        }

        private void orderViewBtn_Click(object sender, EventArgs e)
        {
            OrderView orderView = new OrderView();

            orderView.Show();

            this.Hide();
        }
    }
}