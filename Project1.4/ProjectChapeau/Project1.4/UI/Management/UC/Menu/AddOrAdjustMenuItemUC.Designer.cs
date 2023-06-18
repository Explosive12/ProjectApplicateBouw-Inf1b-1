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
            labelMenuChange = new Label();
            panelAddProductList = new FlowLayoutPanel();
            buttonAddOrAdjustMenuItem = new RoundedItems.RoundButton();
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
            buttonGoBack.Click += ButtonGoBackClick;
            // 
            // labelMenuChange
            // 
            labelMenuChange.AutoSize = true;
            labelMenuChange.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenuChange.Location = new Point(30, 121);
            labelMenuChange.Name = "labelMenuChange";
            labelMenuChange.Size = new Size(208, 39);
            labelMenuChange.TabIndex = 19;
            labelMenuChange.Text = "MENU ITEM";
            // 
            // panelAddProductList
            // 
            panelAddProductList.AutoScroll = true;
            panelAddProductList.BackColor = SystemColors.Window;
            panelAddProductList.Location = new Point(36, 163);
            panelAddProductList.Name = "panelAddProductList";
            panelAddProductList.Size = new Size(357, 449);
            panelAddProductList.TabIndex = 20;
            // 
            // buttonAddOrAdjustMenuItem
            // 
            buttonAddOrAdjustMenuItem.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddOrAdjustMenuItem.Cursor = Cursors.Hand;
            buttonAddOrAdjustMenuItem.FlatAppearance.BorderSize = 0;
            buttonAddOrAdjustMenuItem.FlatStyle = FlatStyle.Flat;
            buttonAddOrAdjustMenuItem.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddOrAdjustMenuItem.Location = new Point(36, 633);
            buttonAddOrAdjustMenuItem.Name = "buttonAddOrAdjustMenuItem";
            buttonAddOrAdjustMenuItem.Size = new Size(120, 35);
            buttonAddOrAdjustMenuItem.TabIndex = 18;
            buttonAddOrAdjustMenuItem.Text = "ADD";
            buttonAddOrAdjustMenuItem.UseVisualStyleBackColor = false;
            buttonAddOrAdjustMenuItem.Click += AddOrAdjustClick;
            // 
            // AddOrAdjustMenuItemUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddOrAdjustMenuItem);
            Controls.Add(panelAddProductList);
            Controls.Add(labelMenuChange);
            Controls.Add(buttonGoBack);
            Controls.Add(Logo);
            Name = "AddOrAdjustMenuItemUC";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private RoundedItems.RoundButton buttonGoBack;
        private Label labelMenuChange;
        private FlowLayoutPanel panelAddProductList;
        private RoundedItems.RoundButton buttonAddOrAdjustMenuItem;
    }
}
