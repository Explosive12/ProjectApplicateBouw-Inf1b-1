namespace Project1._4
{
    partial class OrderViewLunchUC
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
            productLbl = new Label();
            priceLbl = new Label();
            UCButton = new Button();
            SuspendLayout();
            // 
            // productLbl
            // 
            productLbl.AutoEllipsis = true;
            productLbl.Location = new Point(13, 10);
            productLbl.Name = "productLbl";
            productLbl.Size = new Size(218, 39);
            productLbl.TabIndex = 0;
            productLbl.Text = "{Product}";
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(233, 34);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(41, 15);
            priceLbl.TabIndex = 1;
            priceLbl.Text = "{Price}";
            // 
            // UCButton
            // 
            UCButton.BackColor = Color.Transparent;
            UCButton.Location = new Point(-3, -2);
            UCButton.Margin = new Padding(3, 2, 3, 2);
            UCButton.Name = "UCButton";
            UCButton.Size = new Size(341, 62);
            UCButton.TabIndex = 2;
            UCButton.UseVisualStyleBackColor = false;
            UCButton.Click += UCButton_Click;
            // 
            // OrderViewUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(priceLbl);
            Controls.Add(productLbl);
            Controls.Add(UCButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrderViewUC";
            Size = new Size(337, 58);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productLbl;
        private Label priceLbl;
        private Button UCButton;
    }
}
