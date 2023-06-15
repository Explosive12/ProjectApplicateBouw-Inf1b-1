namespace Project1._4.UI.Management.UC
{
    partial class AddOrAdjustMenuItemUC
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
            Logo = new PictureBox();
            buttonGoBack = new RoundedItems.RoundButton();
            labelMenu = new Label();
            panelAddMenuItem = new FlowLayoutPanel();
            buttonAddMenuItem = new RoundedItems.RoundButton();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.chapeagoeie;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(131, 66);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 17;
            Logo.TabStop = false;
            // 
            // buttonGoBack
            // 
            buttonGoBack.BackColor = Color.FromArgb(255, 179, 71);
            buttonGoBack.Cursor = Cursors.Hand;
            buttonGoBack.FlatAppearance.BorderSize = 0;
            buttonGoBack.FlatStyle = FlatStyle.Flat;
            buttonGoBack.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGoBack.ForeColor = SystemColors.ActiveCaptionText;
            buttonGoBack.Location = new Point(296, 21);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(86, 43);
            buttonGoBack.TabIndex = 18;
            buttonGoBack.Text = "BACK";
            buttonGoBack.UseVisualStyleBackColor = false;
            buttonGoBack.Click += buttonGoBack_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu.Location = new Point(30, 121);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(208, 39);
            labelMenu.TabIndex = 19;
            labelMenu.Text = "MENU ITEM";
            // 
            // panelAddMenuItem
            // 
            panelAddMenuItem.BackColor = SystemColors.Window;
            panelAddMenuItem.Location = new Point(36, 163);
            panelAddMenuItem.Name = "panelAddMenuItem";
            panelAddMenuItem.Size = new Size(357, 449);
            panelAddMenuItem.TabIndex = 20;
            // 
            // buttonAddMenuItem
            // 
            buttonAddMenuItem.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddMenuItem.Cursor = Cursors.Hand;
            buttonAddMenuItem.FlatAppearance.BorderSize = 0;
            buttonAddMenuItem.FlatStyle = FlatStyle.Flat;
            buttonAddMenuItem.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddMenuItem.Location = new Point(36, 633);
            buttonAddMenuItem.Name = "buttonAddMenuItem";
            buttonAddMenuItem.Size = new Size(120, 35);
            buttonAddMenuItem.TabIndex = 18;
            buttonAddMenuItem.Text = "ADD";
            buttonAddMenuItem.UseVisualStyleBackColor = false;
            // 
            // AddOrAjustMenuUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddMenuItem);
            Controls.Add(panelAddMenuItem);
            Controls.Add(labelMenu);
            Controls.Add(buttonGoBack);
            Controls.Add(Logo);
            Name = "AddOrAjustMenuUC";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private RoundedItems.RoundButton buttonGoBack;
        private Label labelMenu;
        private FlowLayoutPanel panelAddMenuItem;
        private RoundedItems.RoundButton buttonAddMenuItem;
    }
}
