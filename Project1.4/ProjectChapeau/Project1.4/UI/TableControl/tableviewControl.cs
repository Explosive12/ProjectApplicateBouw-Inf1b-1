using Microsoft.Graph.Education.Classes.Item.Assignments.Item.Submissions.Item.Return;
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
    public partial class tableviewControl : UserControl
    {
        private Table table;
        private TableButtonsControl tableButtons;
        private FlowLayoutPanel flowLayoutPanel;

        private TableService tableService;
        private List<Table> tableslist;
        public Table Table
        {
            get { return table; }
        }

        public tableviewControl(Table table, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            this.table = table;
            this.flowLayoutPanel = flowLayoutPanel;
            
            tableService = new TableService();
            tableslist = tableService.GetAllTables();

            tableButtons = new TableButtonsControl();
            AddButtonsToTableLayout();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            //get the clicked button and its index int thetablelayoutpanel
            Button button = (Button)sender;
            int buttonIndex = tableLayoutPanel.Controls.IndexOf(button);
            //get the tableId and status
            int tableId = tableslist[buttonIndex].tafelId;
            TableStatus status = tableslist[buttonIndex].status;

            if (status == TableStatus.Besteld)
            {
                DialogResult result = MessageBox.Show("There is a order on the table , do you want to proceed ?", "Confirm Change", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            else if (status == TableStatus.Gereseveerd)
            {
                DialogResult result = MessageBox.Show("The table is reserved. Do you want to change the status and remove the reservation", "Confirm Change", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Reservation reservation = new Reservation();
                    tableService.RemoveReservation(reservation, tableId, status);
                    
                    TableStatus statusAfterGereseveerd = TableStatus.Vrij;
                    if (status == TableStatus.Bezet)
                    {
                        statusAfterGereseveerd = TableStatus.Bezet;
                    }
                    tableService.UpdateTableStatus(statusAfterGereseveerd , tableId);
                }
                else if (result == DialogResult.No)
                {
                    tableviewControl tableviewControl = new tableviewControl(table, flowLayoutPanel);
                    flowLayoutPanel.Controls.Clear();
                    flowLayoutPanel.Controls.Add(tableviewControl);
                    return;
                }
            }
            tableStatusControl tableStatusControl = new tableStatusControl(tableId, this , flowLayoutPanel);
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(tableStatusControl);
        }
        public void UpdateTableData()
        {
            tableslist = tableService.GetAllTables();
            AddButtonsToTableLayout();
        }
        private void AddButtonsToTableLayout()
        {
            tableLayoutPanel.Controls.Clear();
            for (int row = 0; row < 2; row++)
            {
                for (int coll = 0; coll < 5; coll++)
                {
                    int buttonIndex = row * 5 + coll;
                    int tableId = tableslist[buttonIndex].tafelId;
                    TableStatus status = tableslist[buttonIndex].status;

                    Button button = tableButtons.GetButton(coll, row, tableId, status);
                    button.Click += Button_Click;

                    tableLayoutPanel.Controls.Add(button, coll, row);
                }
            }
        }
    }
}
