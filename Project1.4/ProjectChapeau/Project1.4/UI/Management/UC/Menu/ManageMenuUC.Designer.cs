namespace Project1._4.UI.Management.UC
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
            buttonAdjust = new RoundedItems.RoundButton();
            buttonRemove = new RoundedItems.RoundButton();
            buttonAddNew = new RoundedItems.RoundButton();
            buttonGoBack = new RoundedItems.RoundButton();
            labelMenu = new RoundedItems.RoundLabel();
            Logo = new PictureBox();
            panelProductsList = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // buttonAdjust
            // 
            buttonAdjust.BackColor = Color.FromArgb(138, 210, 176);
            buttonAdjust.Cursor = Cursors.Hand;
            buttonAdjust.FlatAppearance.BorderSize = 0;
            buttonAdjust.FlatStyle = FlatStyle.Flat;
            buttonAdjust.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdjust.Location = new Point(36, 616);
            buttonAdjust.Name = "buttonAdjust";
            buttonAdjust.Size = new Size(120, 35);
            buttonAdjust.TabIndex = 11;
            buttonAdjust.Text = "ADJUST";
            buttonAdjust.UseVisualStyleBackColor = false;
            buttonAdjust.Click += buttonAdjustMenuItem_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(245, 108, 117);
            buttonRemove.Cursor = Cursors.Hand;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.Location = new Point(273, 616);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(120, 35);
            buttonRemove.TabIndex = 13;
            buttonRemove.Text = "REMOVE";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // buttonAddNew
            // 
            buttonAddNew.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddNew.Cursor = Cursors.Hand;
            buttonAddNew.FlatAppearance.BorderSize = 0;
            buttonAddNew.FlatStyle = FlatStyle.Flat;
            buttonAddNew.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNew.Location = new Point(273, 111);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(120, 35);
            buttonAddNew.TabIndex = 14;
            buttonAddNew.Text = "ADD NEW";
            buttonAddNew.UseVisualStyleBackColor = false;
            buttonAddNew.Click += buttonAddNewMenuItem_Click;
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
            buttonGoBack.TabIndex = 15;
            buttonGoBack.Text = "BACK";
            buttonGoBack.UseVisualStyleBackColor = false;
            buttonGoBack.Click += buttonGoBack_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu.Location = new Point(30, 111);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(115, 39);
            labelMenu.TabIndex = 16;
            labelMenu.Text = "MENU";
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
            // panelProductsList
            // 
            panelProductsList.AutoScroll = true;
            panelProductsList.BackColor = SystemColors.Window;
            panelProductsList.Location = new Point(36, 152);
            panelProductsList.Name = "panelProductsList";
            panelProductsList.Size = new Size(375, 449);
            panelProductsList.TabIndex = 21;
            // 
            // ManageMenuUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panelProductsList);
            Controls.Add(Logo);
            Controls.Add(labelMenu);
            Controls.Add(buttonGoBack);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdjust);
            Name = "ManageMenuUC";
            Size = new Size(414, 736);
            Load += ManageMenuOnLoad;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedItems.RoundButton buttonAdjust;
        private RoundedItems.RoundButton buttonRemove;
        private RoundedItems.RoundButton buttonAddNew;
        private RoundedItems.RoundButton buttonGoBack;
        private RoundedItems.RoundLabel labelMenu;
        private PictureBox Logo;
        private FlowLayoutPanel panelProductsList;
    }
}
