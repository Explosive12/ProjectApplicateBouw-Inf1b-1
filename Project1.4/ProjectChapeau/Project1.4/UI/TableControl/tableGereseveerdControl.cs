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
        public tableGereseveerdControl(int tableId, tableGereseveerdControl tableGereseveerdControl)
        {
            this.tableId = tableId;
            this.tableGereseveerd = tableGereseveerdControl;
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

            TableService tableService = new TableService();
            tableService.ReserveTable(reservation , tableId);

            tableService.UpdateTableStatus(TableStatus.Gereseveerd, tableId);
        }
    }
}
