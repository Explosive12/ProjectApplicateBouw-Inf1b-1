namespace Project1._4.UI
{
    partial class BarKitchenView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKitchenHeader = new Label();
            btnLoad2004 = new Button();
            flpKitchenOrders = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblKitchenHeader
            // 
            lblKitchenHeader.AutoSize = true;
            lblKitchenHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblKitchenHeader.Location = new Point(819, 85);
            lblKitchenHeader.Name = "lblKitchenHeader";
            lblKitchenHeader.Size = new Size(553, 104);
            lblKitchenHeader.TabIndex = 0;
            lblKitchenHeader.Text = "Kitchen Orders";
            // 
            // btnLoad2004
            // 
            btnLoad2004.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoad2004.Location = new Point(111, 65);
            btnLoad2004.Name = "btnLoad2004";
            btnLoad2004.Size = new Size(169, 52);
            btnLoad2004.TabIndex = 2;
            btnLoad2004.Text = "Load";
            btnLoad2004.UseVisualStyleBackColor = true;
            btnLoad2004.Click += btnLoad2004_Click;
            // 
            // flpKitchenOrders
            // 
            flpKitchenOrders.Location = new Point(97, 189);
            flpKitchenOrders.Name = "flpKitchenOrders";
            flpKitchenOrders.Size = new Size(2045, 787);
            flpKitchenOrders.TabIndex = 3;
            // 
            // BarKitchenView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2237, 1005);
            Controls.Add(flpKitchenOrders);
            Controls.Add(btnLoad2004);
            Controls.Add(lblKitchenHeader);
            Name = "BarKitchenView";
            Text = "BarKitchenView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKitchenHeader;
        private Button btnLoad2004;
        private FlowLayoutPanel flpKitchenOrders;
    }
}