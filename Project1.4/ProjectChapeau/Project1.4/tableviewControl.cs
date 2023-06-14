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
    public partial class tableviewControl : UserControl
    {
        private Table table;
        private TableButtonsControl tableButtons;

        private TableService tableService;
        private List<Table> tableslist;
        public Table Table
        {
            get { return table; }
        }

        public tableviewControl(Table table)
        {
            InitializeComponent();
            this.table = table;

            tableService = new TableService();
            tableslist = tableService.GetTables();

            tableButtons = new TableButtonsControl();
            tableLayoutPanel.Controls.Add(tableButtons, 0 , 0);

            for (int row = 0; row < 2; row++)
            {
                for (int coll = 0; coll < 5; coll++)
                {
                    int buttontext = tableslist[row * 5 + coll].tafelId;
                    Button button = tableButtons.GetButton(coll, row, buttontext);
                    tableLayoutPanel.Controls.Add(button, coll, row);
                }
            }
        }
    }
}
