using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName;
using Project1._4.Model;
using Project1._4.Service;
using Project1._4.UI;
using Project1._4.UI.Payment;
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
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(tableviewControl);
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
            tableGereseveerdControl tableGereseveerdControl = new tableGereseveerdControl(tableId, this.tableGereseveerdControl, flowLayoutPanel);
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(tableGereseveerdControl);
        }
        public void UpdateTableStatus(TableStatus status, int tableId)
        {
            Table table = tableService.GetTableById(tableId);
            if (table.status == TableStatus.Gereseveerd && (status == TableStatus.Vrij || status == TableStatus.Bezet))
            {
                DialogResult resultGereseveerd = MessageBox.Show("The table is currently reserved do you want to change the status", "Update Status", MessageBoxButtons.YesNo);
                if (resultGereseveerd == DialogResult.Yes)
                {
                    Reservation reservation = tableService.GetReservationById(table.reseveringId);
                    if (reservation == null)
                    {
                        MessageBox.Show("reservation not found");
                        return;
                    }
                    tableService.RemoveReservation(reservation, tableId, status);
                    table.status = status;
                    tableService.UpdateTableStatus(status, tableId);
                }
                else if (resultGereseveerd == DialogResult.No)
                {
                    MessageBox.Show("The table status remains unchanged");
                    return;
                }
            }
            else
            {
                DialogResult resultStatus = MessageBox.Show("Do you want to updated the table status", "Update Status", MessageBoxButtons.YesNo);
                if (resultStatus == DialogResult.Yes)
                {
                    table.status = status;
                    tableService.UpdateTableStatus(status, tableId);
                }
                else
                {
                    MessageBox.Show("The table status remains unchanged");
                    return;
                }
            }
            tableviewControl.UpdateTableData();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(tableviewControl);

        }
        private void GoToTableButton(object sender, EventArgs e)
        {
            OrderViewLunch orderViewLunch = new OrderViewLunch(tableId);
            orderViewLunch.Show();
            tablev.Hide();
        }

        private void buttonGoToPayment_Click(object sender, EventArgs e)
        {
            finishBill finishBill = new finishBill();
            finishBill.Show();
            this.Hide();
        }
    }
}
