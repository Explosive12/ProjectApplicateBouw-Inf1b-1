using Project1._4.Model;
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
        public Table Table
        {
            get { return table; }
        }

        public tableviewControl(Table table)
        {
            InitializeComponent();
            this.table = table;

            tableButtons = new TableButtonsControl();
            tableLayoutPanel.Controls.Add(tableButtons, 0 , 0);

            for (int row = 1; row < 2; row++)
                for (int coll = 0; coll < 5; coll++)
                {
                    Button button = tableButtons.GetButton(coll, row);
                    tableLayoutPanel.Controls.Add(button, coll, row);
                }
        }
    }
}
