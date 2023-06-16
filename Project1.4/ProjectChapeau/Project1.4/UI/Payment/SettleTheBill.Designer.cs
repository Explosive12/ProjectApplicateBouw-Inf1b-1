namespace Project1._4.UI
{
    partial class SettleTheBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettleTheBill));
            logo = new PictureBox();
            label1 = new Label();
            orderPriceLabel = new Label();
            amountPaidLAbel = new Label();
            tipAmountLabel = new Label();
            labelVat = new Label();
            goBackToTableForm = new Button();
            orderPriceLabelSettle = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(-1, 1);
            logo.Name = "logo";
            logo.Size = new Size(115, 58);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(138, 210, 176);
            label1.Location = new Point(55, 184);
            label1.Name = "label1";
            label1.Size = new Size(293, 28);
            label1.TabIndex = 6;
            label1.Text = "THE BILL HAS BEEN SETTLED!";
            // 
            // orderPriceLabel
            // 
            orderPriceLabel.AutoSize = true;
            orderPriceLabel.Location = new Point(87, 264);
            orderPriceLabel.Name = "orderPriceLabel";
            orderPriceLabel.Size = new Size(84, 15);
            orderPriceLabel.TabIndex = 7;
            orderPriceLabel.Text = "ORDER PRICE: ";
            // 
            // amountPaidLAbel
            // 
            amountPaidLAbel.AutoSize = true;
            amountPaidLAbel.Location = new Point(87, 306);
            amountPaidLAbel.Name = "amountPaidLAbel";
            amountPaidLAbel.Size = new Size(95, 15);
            amountPaidLAbel.TabIndex = 8;
            amountPaidLAbel.Text = "AMOUNT PAID:  ";
            // 
            // tipAmountLabel
            // 
            tipAmountLabel.AutoSize = true;
            tipAmountLabel.Location = new Point(87, 343);
            tipAmountLabel.Name = "tipAmountLabel";
            tipAmountLabel.Size = new Size(83, 15);
            tipAmountLabel.TabIndex = 9;
            tipAmountLabel.Text = "TIP AMOUNT: ";
            // 
            // labelVat
            // 
            labelVat.AutoSize = true;
            labelVat.Location = new Point(87, 380);
            labelVat.Name = "labelVat";
            labelVat.Size = new Size(32, 15);
            labelVat.TabIndex = 10;
            labelVat.Text = "VAT: ";
            // 
            // goBackToTableForm
            // 
            goBackToTableForm.BackColor = Color.FromArgb(138, 210, 176);
            goBackToTableForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            goBackToTableForm.Location = new Point(77, 483);
            goBackToTableForm.Name = "goBackToTableForm";
            goBackToTableForm.Size = new Size(243, 44);
            goBackToTableForm.TabIndex = 15;
            goBackToTableForm.Text = "GO BACK TO TABLES";
            goBackToTableForm.UseVisualStyleBackColor = false;
            goBackToTableForm.Click += goBackToTableForm_Click;
            // 
            // orderPriceLabelSettle
            // 
            orderPriceLabelSettle.AutoSize = true;
            orderPriceLabelSettle.Location = new Point(310, 264);
            orderPriceLabelSettle.Name = "orderPriceLabelSettle";
            orderPriceLabelSettle.Size = new Size(0, 15);
            orderPriceLabelSettle.TabIndex = 16;
            // 
            // SettleTheBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(orderPriceLabelSettle);
            Controls.Add(goBackToTableForm);
            Controls.Add(labelVat);
            Controls.Add(tipAmountLabel);
            Controls.Add(amountPaidLAbel);
            Controls.Add(orderPriceLabel);
            Controls.Add(label1);
            Controls.Add(logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettleTheBill";
            Text = "Form2";
            Load += SettleTheBill_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label label1;
        private Label orderPriceLabel;
        private Label amountPaidLAbel;
        private Label tipAmountLabel;
        private Label labelVat;
        private Button goBackToTableForm;
        private Label orderPriceLabelSettle;
    }
}