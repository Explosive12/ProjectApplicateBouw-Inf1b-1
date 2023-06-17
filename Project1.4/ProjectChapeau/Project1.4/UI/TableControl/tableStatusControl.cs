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
        private tableGereseveerdControl tableGereseveerdControl;
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
            UpdateTableStatus(TableStatus.Vrij, tableId);
        }
        private void occupiedButton(object sender, EventArgs e)
        {
            UpdateTableStatus(TableStatus.Bezet, tableId);
        }
        private void reservedButton(object sender, EventArgs e)
        {
            if (tableService.GetTableById(tableId).status == TableStatus.Gereseveerd)
            {
                MessageBox.Show("This table is already reserved");
                return;
            }
            tableGereseveerdControl tableGereseveerdControl = new tableGereseveerdControl(tableId, this.tableGereseveerdControl);
            this.Parent.Controls.Add(tableGereseveerdControl);
            tableGereseveerdControl.BringToFront();
        }
        private void UpdateTableStatus(TableStatus status, int tableId)
        {
            DialogResult result = MessageBox.Show("Do you want to updated the table status", "Update Status", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes:
                    if (status == TableStatus.Gereseveerd)
                        tableService.ReserveTable(status, tableId);
                    else
                        tableService.UpdateTableStatus(status, tableId);
                    MessageBox.Show("The table was updated succesfully");
                    break;
                case DialogResult.No:
                    MessageBox.Show("The table is not updated");
                    break;
            }
            tableviewControl.UpdateTableData();

            this.Hide();
        }
        private void GoToTableButton(object sender, EventArgs e)
        {
            //kian zijn stukje
        }

    }
}
