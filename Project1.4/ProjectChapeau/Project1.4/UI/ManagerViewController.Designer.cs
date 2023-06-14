namespace Project1._4
{
    partial class ManagerViewController
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
            PnlMenuManagement = new Panel();
            buttonToMenu = new Button();
            buttonToEmployeeManagement = new Button();
            pictureBox1 = new PictureBox();
            PnlMenuManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnlMenuManagement
            // 
            PnlMenuManagement.Controls.Add(pictureBox1);
            PnlMenuManagement.Controls.Add(buttonToEmployeeManagement);
            PnlMenuManagement.Controls.Add(buttonToMenu);
            PnlMenuManagement.Location = new Point(0, 0);
            PnlMenuManagement.Name = "PnlMenuManagement";
            PnlMenuManagement.Size = new Size(414, 736);
            PnlMenuManagement.TabIndex = 0;
            // 
            // buttonToMenu
            // 
            buttonToMenu.BackColor = Color.MediumAquamarine;
            buttonToMenu.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToMenu.Location = new Point(89, 496);
            buttonToMenu.Name = "buttonToMenu";
            buttonToMenu.Size = new Size(256, 50);
            buttonToMenu.TabIndex = 0;
            buttonToMenu.Text = "Menu";
            buttonToMenu.UseVisualStyleBackColor = false;
            // 
            // buttonToEmployeeManagement
            // 
            buttonToEmployeeManagement.BackColor = Color.MediumAquamarine;
            buttonToEmployeeManagement.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToEmployeeManagement.Location = new Point(89, 360);
            buttonToEmployeeManagement.Name = "buttonToEmployeeManagement";
            buttonToEmployeeManagement.Size = new Size(256, 50);
            buttonToEmployeeManagement.TabIndex = 1;
            buttonToEmployeeManagement.Text = "Employee Management";
            buttonToEmployeeManagement.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chapeagoeie;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ManagerViewController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlMenuManagement);
            Name = "ManagerViewController";
            Size = new Size(414, 736);
            PnlMenuManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox4;
        private TextBox textBox3;
        private Panel PnlMenuManagement;
        private Button buttonToMenu;
        private Button buttonToEmployeeManagement;
        private PictureBox pictureBox1;
    }
}
