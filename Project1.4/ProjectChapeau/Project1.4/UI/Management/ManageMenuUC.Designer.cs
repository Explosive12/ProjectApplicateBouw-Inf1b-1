using Project1._4.UI.Management.RoundedItems;

namespace Project1._4
{
    partial class ManageMenuUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonToMenu = new RoundButton();
            buttonToEmployeeManagement = new RoundButton();
            Logo = new PictureBox();
            labelUserName = new RoundLabel();
            buttonToTableView = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // buttonToMenu
            // 
            buttonToMenu.BackColor = Color.FromArgb(138, 210, 176);
            buttonToMenu.FlatAppearance.BorderSize = 0;
            buttonToMenu.FlatStyle = FlatStyle.Flat;
            buttonToMenu.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToMenu.Location = new Point(81, 496);
            buttonToMenu.Name = "buttonToMenu";
            buttonToMenu.Size = new Size(284, 73);
            buttonToMenu.TabIndex = 0;
            buttonToMenu.Text = "MENU";
            buttonToMenu.UseVisualStyleBackColor = false;
            // 
            // buttonToEmployeeManagement
            // 
            buttonToEmployeeManagement.BackColor = Color.FromArgb(138, 210, 176);
            buttonToEmployeeManagement.FlatAppearance.BorderSize = 0;
            buttonToEmployeeManagement.FlatStyle = FlatStyle.Flat;
            buttonToEmployeeManagement.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToEmployeeManagement.Location = new Point(81, 360);
            buttonToEmployeeManagement.Name = "buttonToEmployeeManagement";
            buttonToEmployeeManagement.Size = new Size(284, 69);
            buttonToEmployeeManagement.TabIndex = 1;
            buttonToEmployeeManagement.Text = "EMPLOYEE MANAGEMENT";
            buttonToEmployeeManagement.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.chapeagoeie;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(131, 66);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.BackColor = Color.DarkOrange;
            labelUserName.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.Location = new Point(303, 26);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(86, 43);
            labelUserName.TabIndex = 3;
            labelUserName.Text = "{Name}";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonToTableView
            // 
            buttonToTableView.BackColor = Color.FromArgb(138, 210, 176);
            buttonToTableView.FlatAppearance.BorderSize = 0;
            buttonToTableView.FlatStyle = FlatStyle.Flat;
            buttonToTableView.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToTableView.Location = new Point(81, 218);
            buttonToTableView.Name = "buttonToTableView";
            buttonToTableView.Size = new Size(284, 69);
            buttonToTableView.TabIndex = 4;
            buttonToTableView.Text = "TABLE VIEW";
            buttonToTableView.UseVisualStyleBackColor = false;
            // 
            // ManageMenuUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonToTableView);
            Controls.Add(labelUserName);
            Controls.Add(buttonToEmployeeManagement);
            Controls.Add(buttonToMenu);
            Controls.Add(Logo);
            Name = "ManageMenuUC";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox4;
        private TextBox textBox3;
        private RoundButton buttonToMenu;
        private RoundButton buttonToEmployeeManagement;
        private PictureBox Logo;
        private RoundLabel labelUserName;
        private RoundButton buttonToTableView;
    }
}
