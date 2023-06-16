using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName;
using Project1._4.Model;
using Project1._4.Service;
using Project1._4.UI;
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
        private tableviewControl tableviewControl;
        public tableStatusControl(int tableId, tableviewControl tableviewControl)
        {
            InitializeComponent();
            lblTableIdStatusControl.Text = tableId.ToString();
            this.tableId = tableId;
            tableService = new TableService();
            this.tableviewControl = tableviewControl;
        }
        private void Back(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void freeButton(object sender, EventArgs e)
        {
            UpdateTableStatus(TableStatus.Vrij , tableId);
        }
        private void occupiedButton(object sender, EventArgs e)
        {
            UpdateTableStatus(TableStatus. Bezet , tableId);
        }
        private void reservedButton(object sender, EventArgs e)
        {
            UpdateTableStatus(TableStatus.Gereseveerd , tableId);
        }
        private void UpdateTableStatus(TableStatus status, int tableId)
        {
            tableService.UpdateTableStatus(status, tableId);
            MessageBox.Show("The table was succesfully updated");

            tableviewControl.UpdateTableData();

            this.Hide();
        }
        private void GoToTableButton(object sender, EventArgs e)
        {
            //kian zijn stukje
        }

    }
}
