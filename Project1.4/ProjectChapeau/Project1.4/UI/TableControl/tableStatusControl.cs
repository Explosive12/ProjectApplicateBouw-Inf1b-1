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
        private FlowLayoutPanel flowLayoutPanel;
        public tableStatusControl(int tableId, tableviewControl tableviewControl, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            lblTableIdStatusControl.Text = tableId.ToString();
            this.tableId = tableId;
            tableService = new TableService();
            this.tableviewControl = tableviewControl;
            this.flowLayoutPanel = flowLayoutPanel;
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
            tableGereseveerdControl tableGereseveerdControl = new tableGereseveerdControl(tableId, this.tableGereseveerdControl , flowLayoutPanel);
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(tableGereseveerdControl);
        }
        public void UpdateTableStatus(TableStatus status, int tableId)
        {
            DialogResult result = MessageBox.Show("Do you want to updated the table status", "Update Status", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    tableService.UpdateTableStatus(status, tableId);
                    MessageBox.Show("The table was updated succesfully");
                    tableviewControl.UpdateTableData();
                    flowLayoutPanel.Controls.Clear();
                    flowLayoutPanel.Controls.Add(tableviewControl);
                    break;
                case DialogResult.No:
                    MessageBox.Show("The table is not updated");
                    break;
            }
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(tableviewControl);
            tableviewControl.BringToFront();
            this.Hide();
        }
        private void GoToTableButton(object sender, EventArgs e)
        {
            //kian zijn stukje
        }

    }
}
