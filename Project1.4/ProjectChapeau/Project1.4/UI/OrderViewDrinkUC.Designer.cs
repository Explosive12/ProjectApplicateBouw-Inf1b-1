namespace Project1._4.UI
{
    partial class OrderViewDrinkUC
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
            priceLbl = new Label();
            productLbl = new Label();
            UCButton = new Button();
            SuspendLayout();
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.BackColor = Color.White;
            priceLbl.Location = new Point(233, 36);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(41, 15);
            priceLbl.TabIndex = 6;
            priceLbl.Text = "{Price}";
            priceLbl.Click += priceLbl_Click;
            // 
            // productLbl
            // 
            productLbl.AutoEllipsis = true;
            productLbl.BackColor = Color.White;
            productLbl.Location = new Point(13, 12);
            productLbl.Name = "productLbl";
            productLbl.Size = new Size(218, 39);
            productLbl.TabIndex = 5;
            productLbl.Text = "{Product}";
            productLbl.Click += productLbl_Click;
            // 
            // UCButton
            // 
            UCButton.BackColor = Color.Transparent;
            UCButton.Location = new Point(0, -1);
            UCButton.Margin = new Padding(3, 2, 3, 2);
            UCButton.Name = "UCButton";
            UCButton.Size = new Size(341, 64);
            UCButton.TabIndex = 7;
            UCButton.UseVisualStyleBackColor = false;
            UCButton.Click += UCButton_Click;
            // 
            // OrderViewDrinkUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(priceLbl);
            Controls.Add(productLbl);
            Controls.Add(UCButton);
            Name = "OrderViewDrinkUC";
            Size = new Size(341, 62);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label priceLbl;
        private Label productLbl;
        private Button UCButton;
    }
}
