using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName;
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

namespace Project1._4
{
    public partial class tableStatusControl : UserControl
    {
        private TableService tableService;
        private int tableId;
        public tableStatusControl(int tableId)
        {
            InitializeComponent();
            lblTableIdStatusControl.Text = tableId.ToString();
            tableService = new TableService();
        }
        private void Back(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void freeButton(object sender, EventArgs e)
        {
            UpdateTableStatus(TableStatus.Vrij);
        }
        private void occupiedButton(object sender, EventArgs e)
        {
            UpdateTableStatus(TableStatus.Bezet);
        }
        private void reservedButton(object sender, EventArgs e)
        {
            UpdateTableStatus(TableStatus.Gereseveerd);
        }
        private void UpdateTableStatus(TableStatus status)
        {
            Table table = tableService.GetTableById(tableId);
            if (table != null)
            {
                table.status = status;
                tableService.UpdateTableStatus(table);
                MessageBox.Show("Table status updated successfully");
            }
            else
                MessageBox.Show("Table status was not updated successfully");

            this.Hide();
        }
        private void GoToTableButton(object sender, EventArgs e)
        {
            //kian zijn stukje
        }

    }
}
