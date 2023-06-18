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
    public partial class tableGereseveerdControl : UserControl
    {
        private int tableId;
        private tableGereseveerdControl tableGereseveerd;
        private Table table;
        private FlowLayoutPanel FlowLayoutPanel;
        private TableService tableService;
        public tableGereseveerdControl(int tableId, tableGereseveerdControl tableGereseveerdControl , FlowLayoutPanel FlowLayoutPanel)
        {
            this.tableId = tableId;
            this.tableGereseveerd = tableGereseveerdControl;
            this.FlowLayoutPanel = FlowLayoutPanel;

            table = new Table();

            InitializeComponent();
        }
        private void Opslaan(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation()
            {
                phoneNumber = int.Parse(txtNummerGegevens.Text),
                naam = txtNaamGegevens.Text,
                opmerking = int.Parse(txtOpmerkingGegevens.Text),
                datum = DateTime.Parse(txtDatumGegevens.Text),
                tijd = DateTime.Parse(txtTijdGegevens.Text),
            };

            tableService = new TableService();

            //reserve table and update the tablestatus 
            tableService.ReserveTable(reservation , tableId);

            tableService.UpdateTableStatus(TableStatus.Gereseveerd, tableId);
            MessageBox.Show("The table has been reserved successfully ");
            this.Hide();

            tableviewControl tableview = new tableviewControl(table , FlowLayoutPanel);
            tableview.UpdateTableData();

            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(tableview);

        }
    }
}
