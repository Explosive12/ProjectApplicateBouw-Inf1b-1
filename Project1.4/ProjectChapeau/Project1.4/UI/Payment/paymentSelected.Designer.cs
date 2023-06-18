namespace Project1._4.UI.Payment
{
    partial class paymentSelected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentSelected));
            logo = new PictureBox();
            labelCustomerComment = new Label();
            labelPaymentType = new Label();
            labelamountPaid = new Label();
            textBoxAmountPaid = new TextBox();
            labelChange = new Label();
            TipLabel = new Label();
            customTip = new Label();
            textBoxCustomTip = new TextBox();
            buttonPay = new Button();
            buttonSet = new Button();
            buttonAddChangeTip = new Button();
            tipHasBeenAdded = new Label();
            totalPriceSelected = new Label();
            LeftOverPriceLabel = new Label();
            euroLabel = new Label();
            TipLabelWithChange = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(-3, 2);
            logo.Name = "logo";
            logo.Size = new Size(115, 58);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // labelCustomerComment
            // 
            labelCustomerComment.AutoSize = true;
            labelCustomerComment.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerComment.Location = new Point(26, 131);
            labelCustomerComment.Name = "labelCustomerComment";
            labelCustomerComment.Size = new Size(115, 30);
            labelCustomerComment.TabIndex = 18;
            labelCustomerComment.Text = "PAYMENT";
            // 
            // labelPaymentType
            // 
            labelPaymentType.AutoSize = true;
            labelPaymentType.Location = new Point(28, 171);
            labelPaymentType.Name = "labelPaymentType";
            labelPaymentType.Size = new Size(84, 15);
            labelPaymentType.TabIndex = 23;
            labelPaymentType.Text = "ORDER PRICE: ";
            // 
            // labelamountPaid
            // 
            labelamountPaid.AutoSize = true;
            labelamountPaid.Location = new Point(28, 203);
            labelamountPaid.Name = "labelamountPaid";
            labelamountPaid.Size = new Size(92, 15);
            labelamountPaid.TabIndex = 24;
            labelamountPaid.Text = "AMOUNT PAID: ";
            // 
            // textBoxAmountPaid
            // 
            textBoxAmountPaid.Location = new Point(273, 200);
            textBoxAmountPaid.Name = "textBoxAmountPaid";
            textBoxAmountPaid.Size = new Size(100, 23);
            textBoxAmountPaid.TabIndex = 25;
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Location = new Point(28, 309);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(58, 15);
            labelChange.TabIndex = 26;
            labelChange.Text = "CHANGE:";
            // 
            // TipLabel
            // 
            TipLabel.AutoSize = true;
            TipLabel.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            TipLabel.Location = new Point(28, 345);
            TipLabel.Name = "TipLabel";
            TipLabel.Size = new Size(35, 23);
            TipLabel.TabIndex = 27;
            TipLabel.Text = "TIP";
            // 
            // customTip
            // 
            customTip.AutoSize = true;
            customTip.Location = new Point(28, 419);
            customTip.Name = "customTip";
            customTip.Size = new Size(76, 15);
            customTip.TabIndex = 28;
            customTip.Text = "CUSTOM TIP:";
            // 
            // textBoxCustomTip
            // 
            textBoxCustomTip.Location = new Point(273, 411);
            textBoxCustomTip.Name = "textBoxCustomTip";
            textBoxCustomTip.Size = new Size(100, 23);
            textBoxCustomTip.TabIndex = 29;
            // 
            // buttonPay
            // 
            buttonPay.BackColor = Color.Orange;
            buttonPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPay.Location = new Point(73, 526);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(243, 44);
            buttonPay.TabIndex = 30;
            buttonPay.Text = "PAY";
            buttonPay.UseVisualStyleBackColor = false;
            buttonPay.Click += buttonPay_Click;
            // 
            // buttonSet
            // 
            buttonSet.BackColor = Color.FromArgb(138, 210, 176);
            buttonSet.Location = new Point(317, 229);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(56, 23);
            buttonSet.TabIndex = 31;
            buttonSet.Text = "SET";
            buttonSet.UseVisualStyleBackColor = false;
            buttonSet.Click += buttonSet_Click;
            // 
            // buttonAddChangeTip
            // 
            buttonAddChangeTip.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddChangeTip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddChangeTip.Location = new Point(28, 380);
            buttonAddChangeTip.Name = "buttonAddChangeTip";
            buttonAddChangeTip.Size = new Size(345, 25);
            buttonAddChangeTip.TabIndex = 33;
            buttonAddChangeTip.Text = "ADD CHANGE AS TIP";
            buttonAddChangeTip.UseVisualStyleBackColor = false;
            buttonAddChangeTip.Click += buttonAddChangeTip_Click;
            // 
            // tipHasBeenAdded
            // 
            tipHasBeenAdded.AutoSize = true;
            tipHasBeenAdded.BackColor = SystemColors.Control;
            tipHasBeenAdded.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tipHasBeenAdded.ForeColor = Color.FromArgb(138, 210, 176);
            tipHasBeenAdded.Location = new Point(141, 483);
            tipHasBeenAdded.Name = "tipHasBeenAdded";
            tipHasBeenAdded.Size = new Size(0, 15);
            tipHasBeenAdded.TabIndex = 34;
            // 
            // totalPriceSelected
            // 
            totalPriceSelected.AutoSize = true;
            totalPriceSelected.Location = new Point(298, 171);
            totalPriceSelected.Name = "totalPriceSelected";
            totalPriceSelected.Size = new Size(75, 15);
            totalPriceSelected.TabIndex = 35;
            totalPriceSelected.Text = "getTotalPrice";
            totalPriceSelected.Click += totalPriceSelected_Click;
            // 
            // LeftOverPriceLabel
            // 
            LeftOverPriceLabel.AutoSize = true;
            LeftOverPriceLabel.Location = new Point(326, 309);
            LeftOverPriceLabel.Name = "LeftOverPriceLabel";
            LeftOverPriceLabel.Size = new Size(0, 15);
            LeftOverPriceLabel.TabIndex = 36;
            // 
            // euroLabel
            // 
            euroLabel.AutoSize = true;
            euroLabel.Location = new Point(288, 171);
            euroLabel.Name = "euroLabel";
            euroLabel.Size = new Size(13, 15);
            euroLabel.TabIndex = 37;
            euroLabel.Text = "€";
            // 
            // TipLabelWithChange
            // 
            TipLabelWithChange.AutoSize = true;
            TipLabelWithChange.Location = new Point(326, 353);
            TipLabelWithChange.Name = "TipLabelWithChange";
            TipLabelWithChange.Size = new Size(0, 15);
            TipLabelWithChange.TabIndex = 38;
            // 
            // paymentSelected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(TipLabelWithChange);
            Controls.Add(euroLabel);
            Controls.Add(LeftOverPriceLabel);
            Controls.Add(totalPriceSelected);
            Controls.Add(tipHasBeenAdded);
            Controls.Add(buttonAddChangeTip);
            Controls.Add(buttonSet);
            Controls.Add(buttonPay);
            Controls.Add(textBoxCustomTip);
            Controls.Add(customTip);
            Controls.Add(TipLabel);
            Controls.Add(labelChange);
            Controls.Add(textBoxAmountPaid);
            Controls.Add(labelamountPaid);
            Controls.Add(labelPaymentType);
            Controls.Add(labelCustomerComment);
            Controls.Add(logo);
            Name = "paymentSelected";
            Text = "Form1";
            Load += paymentSelected_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label labelCustomerComment;
        private Label labelPaymentType;
        private Label labelamountPaid;
        private TextBox textBoxAmountPaid;
        private Label labelChange;
        private Label TipLabel;
        private Label customTip;
        private TextBox textBoxCustomTip;
        private Button buttonPay;
        private Button buttonSet;
        private Button buttonAddChangeTip;
        private Label tipHasBeenAdded;
        private Label totalPriceSelected;
        private Label LeftOverPriceLabel;
        private Label euroLabel;
        private Label TipLabelWithChange;
    }
}