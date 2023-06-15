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
            tableslist = tableService.GetAllTables();

            tableButtons = new TableButtonsControl();
            //tableLayoutPanel.Controls.Add(tableButtons, 0 , 0);

            int buttontext = 0;

            for (int row = 0; row < 2; row++)
            {
                for (int coll = 0; coll < 5; coll++)
                {
                    int tableId = tableslist[buttontext].tafelId;
                    Button button = tableButtons.GetButton(coll, row, tableId);
                    button.Click += Button_Click;
                    tableLayoutPanel.Controls.Add(button, coll, row);
                    buttontext++;
                }
            }
        }
        private void Button_Click(object sender , EventArgs e)
        {
            Button button = (Button)sender;
            int tableId = int.Parse(button.Text);

            tableStatusControl tableStatusControl = new tableStatusControl(tableId);
            this.Parent.Controls.Add(tableStatusControl);
            tableStatusControl.BringToFront();
        }
    }
}
