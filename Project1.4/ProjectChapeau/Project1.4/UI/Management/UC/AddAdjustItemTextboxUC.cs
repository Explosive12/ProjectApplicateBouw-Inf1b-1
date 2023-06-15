using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4.UI.Management.UC
{
    public partial class AddItemUC : UserControl
    {

        public string Value
        {
            get
            {
                return textBoxAddItem.Text;
            }
            set { textBoxAddItem.Text = value; }
        }

        public AddItemUC(string label, bool isPassword = false)
        {
            InitializeComponent();

            this.labelAddItem.Text = label;
            if (isPassword)
                this.textBoxAddItem.PasswordChar = '*';
        }
    }
}
