namespace Project1._4.UI.Management.UC.Menu
{
    partial class StockManagementUC
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
            labelStock = new Label();
            panelAddStock = new FlowLayoutPanel();
            buttonAddStockAmount = new RoundedItems.RoundButton();
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
            Logo.TabIndex = 18;
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
            buttonGoBack.TabIndex = 19;
            buttonGoBack.Text = "BACK";
            buttonGoBack.UseVisualStyleBackColor = false;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelStock.Location = new Point(30, 121);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(125, 39);
            labelStock.TabIndex = 20;
            labelStock.Text = "STOCK";
            // 
            // panelAddStock
            // 
            panelAddStock.BackColor = SystemColors.Window;
            panelAddStock.Location = new Point(36, 163);
            panelAddStock.Name = "panelAddStock";
            panelAddStock.Size = new Size(357, 449);
            panelAddStock.TabIndex = 21;
            // 
            // buttonAddStockAmount
            // 
            buttonAddStockAmount.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddStockAmount.Cursor = Cursors.Hand;
            buttonAddStockAmount.FlatAppearance.BorderSize = 0;
            buttonAddStockAmount.FlatStyle = FlatStyle.Flat;
            buttonAddStockAmount.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddStockAmount.Location = new Point(36, 633);
            buttonAddStockAmount.Name = "buttonAddStockAmount";
            buttonAddStockAmount.Size = new Size(120, 35);
            buttonAddStockAmount.TabIndex = 22;
            buttonAddStockAmount.Text = "ADD";
            buttonAddStockAmount.UseVisualStyleBackColor = false;
            // 
            // StockUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddStockAmount);
            Controls.Add(panelAddStock);
            Controls.Add(labelStock);
            Controls.Add(buttonGoBack);
            Controls.Add(Logo);
            Name = "StockUC";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private RoundedItems.RoundButton buttonGoBack;
        private Label labelStock;
        private FlowLayoutPanel panelAddStock;
        private RoundedItems.RoundButton buttonAddStockAmount;
    }
}
