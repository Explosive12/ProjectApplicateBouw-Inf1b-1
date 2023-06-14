namespace Project1._4
{
    partial class OrderViewUC
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
            productLbl.AutoSize = true;
            productLbl.Location = new Point(22, 24);
            productLbl.Name = "productLbl";
            productLbl.Size = new Size(70, 20);
            productLbl.TabIndex = 0;
            productLbl.Text = "{Product}";
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(258, 60);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(51, 20);
            priceLbl.TabIndex = 1;
            priceLbl.Text = "{Price}";
            // 
            // UCButton
            // 
            UCButton.Location = new Point(0, 0);
            UCButton.Name = "UCButton";
            UCButton.Size = new Size(390, 118);
            UCButton.TabIndex = 2;
            UCButton.UseVisualStyleBackColor = true;
            UCButton.Click += UCButton_Click;
            // 
            // OrderViewUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            Controls.Add(priceLbl);
            Controls.Add(productLbl);
            Controls.Add(UCButton);
            Name = "OrderViewUC";
            Size = new Size(390, 118);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productLbl;
        private Label priceLbl;
        private Button UCButton;
    }
}
