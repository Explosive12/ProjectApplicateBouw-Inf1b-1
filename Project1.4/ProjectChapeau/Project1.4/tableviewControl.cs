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
        public Table Table
        {
            get { return table; }
        }

        public tableviewControl(Table table)
        {
            InitializeComponent();
            this.table = table;
        }
    }
}
