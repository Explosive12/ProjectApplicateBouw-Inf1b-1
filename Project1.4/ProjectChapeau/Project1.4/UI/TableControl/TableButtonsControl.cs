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
    public partial class TableButtonsControl : UserControl
    {
        public TableButtonsControl()
        {
            InitializeComponent();
        }
        public Button GetButton(int column, int row, int tableId, TableStatus status)
        {
            Button button = new Button();
            button.Text = tableId.ToString();
            button.Size = btnTableButton.Size;
            button.BackColor = GetbuttonColor(status);
            return button;
        }
        private Color GetbuttonColor(TableStatus status)
        {
            switch (status)
            {
                case TableStatus.Vrij:
                    return Color.FromArgb(138, 210, 176);
                case TableStatus.Bezet:
                    return Color.FromArgb(255, 179, 71);
                case TableStatus.Gereseveerd:
                    return Color.FromArgb(196, 196, 196);
                default:
                    return Color.FromArgb(0, 0, 0);
            };
        }
    }
}
