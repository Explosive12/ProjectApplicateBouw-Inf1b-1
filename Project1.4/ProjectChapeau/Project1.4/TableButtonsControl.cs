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
        public Button GetButton(int column, int row, int buttontext)
        {
            Button button = new Button();
            button.Text = buttontext.ToString();
            button.Size = btnTableButton.Size;
            return button;
        }
    }
}
