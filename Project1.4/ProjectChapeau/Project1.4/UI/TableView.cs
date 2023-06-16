using Microsoft.Graph.Models;
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
using System.Xml.Serialization;

namespace Project1._4.UI
{
    public partial class TableView : Form
    {
        public TableView(string username)
        {
            InitializeComponent();
            Table table = new Table();
            tableviewControl tableviewControl = new tableviewControl(table);

            this.FLPTableView.Controls.Add(tableviewControl);

            lblLoginName.Text = username;
        }


    }
}
