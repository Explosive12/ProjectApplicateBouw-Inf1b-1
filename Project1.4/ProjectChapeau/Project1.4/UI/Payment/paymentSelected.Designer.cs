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
            label1 = new Label();
            textBoxCustomTip = new TextBox();
            buttonPay = new Button();
            buttonSet = new Button();
            button1 = new Button();
            buttonAddChangeTip = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 419);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 28;
            label1.Text = "CUSTOM TIP:";
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
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 210, 176);
            button1.Location = new Point(317, 440);
            button1.Name = "button1";
            button1.Size = new Size(56, 23);
            button1.TabIndex = 32;
            button1.Text = "SET";
            button1.UseVisualStyleBackColor = false;
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
            // 
            // paymentSelected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(buttonAddChangeTip);
            Controls.Add(button1);
            Controls.Add(buttonSet);
            Controls.Add(buttonPay);
            Controls.Add(textBoxCustomTip);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox textBoxCustomTip;
        private Button buttonPay;
        private Button buttonSet;
        private Button button1;
        private Button buttonAddChangeTip;
    }
}