namespace Project1._4.UI.Payment
{
    partial class finishBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finishBill));
            logo = new PictureBox();
            billLabel = new Label();
            proceedPayment = new Button();
            listView1 = new ListView();
            labelTotal = new Label();
            labelPaymentType = new Label();
            labelOrderPrice = new Label();
            labelVat = new Label();
            buttonDesign = new Button();
            DEBITRadio = new RadioButton();
            radioButtonVisa = new RadioButton();
            radioButtonCash = new RadioButton();
            totalPriceCalculate = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(2, 1);
            logo.Name = "logo";
            logo.Size = new Size(115, 58);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            billLabel.Location = new Point(58, 116);
            billLabel.Name = "billLabel";
            billLabel.Size = new Size(56, 30);
            billLabel.TabIndex = 18;
            billLabel.Text = "BILL";
            billLabel.Click += billLabel_Click;
            // 
            // proceedPayment
            // 
            proceedPayment.BackColor = Color.FromArgb(138, 210, 176);
            proceedPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            proceedPayment.Location = new Point(77, 588);
            proceedPayment.Name = "proceedPayment";
            proceedPayment.Size = new Size(243, 44);
            proceedPayment.TabIndex = 19;
            proceedPayment.Text = "PROCEED TO PAYMENT";
            proceedPayment.UseVisualStyleBackColor = false;
            proceedPayment.Click += proceedPayment_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(58, 160);
            listView1.Name = "listView1";
            listView1.Size = new Size(286, 272);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = SystemColors.Window;
            labelTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.Location = new Point(68, 397);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(77, 25);
            labelTotal.TabIndex = 21;
            labelTotal.Text = "TOTAL: ";
            // 
            // labelPaymentType
            // 
            labelPaymentType.AutoSize = true;
            labelPaymentType.Location = new Point(58, 471);
            labelPaymentType.Name = "labelPaymentType";
            labelPaymentType.Size = new Size(144, 15);
            labelPaymentType.TabIndex = 22;
            labelPaymentType.Text = "CHOOSE PAYMENT TYPE: ";
            // 
            // labelOrderPrice
            // 
            labelOrderPrice.AutoSize = true;
            labelOrderPrice.Location = new Point(61, 531);
            labelOrderPrice.Name = "labelOrderPrice";
            labelOrderPrice.Size = new Size(84, 15);
            labelOrderPrice.TabIndex = 23;
            labelOrderPrice.Text = "ORDER PRICE: ";
            // 
            // labelVat
            // 
            labelVat.AutoSize = true;
            labelVat.Location = new Point(61, 557);
            labelVat.Name = "labelVat";
            labelVat.Size = new Size(35, 15);
            labelVat.TabIndex = 24;
            labelVat.Text = "VAT:  ";
            // 
            // buttonDesign
            // 
            buttonDesign.BackColor = Color.Orange;
            buttonDesign.Location = new Point(58, 382);
            buttonDesign.Name = "buttonDesign";
            buttonDesign.Size = new Size(283, 12);
            buttonDesign.TabIndex = 25;
            buttonDesign.UseVisualStyleBackColor = false;
            // 
            // DEBITRadio
            // 
            DEBITRadio.AutoSize = true;
            DEBITRadio.Location = new Point(62, 499);
            DEBITRadio.Name = "DEBITRadio";
            DEBITRadio.Size = new Size(55, 19);
            DEBITRadio.TabIndex = 26;
            DEBITRadio.TabStop = true;
            DEBITRadio.Text = "DEBIT";
            DEBITRadio.UseVisualStyleBackColor = true;
            DEBITRadio.CheckedChanged += DEBITRadio_CheckedChanged;
            // 
            // radioButtonVisa
            // 
            radioButtonVisa.AutoSize = true;
            radioButtonVisa.Location = new Point(162, 499);
            radioButtonVisa.Name = "radioButtonVisa";
            radioButtonVisa.Size = new Size(86, 19);
            radioButtonVisa.TabIndex = 27;
            radioButtonVisa.TabStop = true;
            radioButtonVisa.Text = "VISA/AMEX";
            radioButtonVisa.UseVisualStyleBackColor = true;
            radioButtonVisa.CheckedChanged += radioButtonVisa_CheckedChanged;
            // 
            // radioButtonCash
            // 
            radioButtonCash.AutoSize = true;
            radioButtonCash.Location = new Point(285, 499);
            radioButtonCash.Name = "radioButtonCash";
            radioButtonCash.Size = new Size(56, 19);
            radioButtonCash.TabIndex = 28;
            radioButtonCash.TabStop = true;
            radioButtonCash.Text = "CASH";
            radioButtonCash.UseVisualStyleBackColor = true;
            radioButtonCash.CheckedChanged += radioButtonCash_CheckedChanged_1;
            // 
            // totalPriceCalculate
            // 
            totalPriceCalculate.AutoSize = true;
            totalPriceCalculate.Location = new Point(294, 407);
            totalPriceCalculate.Name = "totalPriceCalculate";
            totalPriceCalculate.Size = new Size(38, 15);
            totalPriceCalculate.TabIndex = 29;
            totalPriceCalculate.Text = "label1";
            // 
            // finishBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(totalPriceCalculate);
            Controls.Add(radioButtonCash);
            Controls.Add(radioButtonVisa);
            Controls.Add(DEBITRadio);
            Controls.Add(buttonDesign);
            Controls.Add(labelVat);
            Controls.Add(labelOrderPrice);
            Controls.Add(labelPaymentType);
            Controls.Add(labelTotal);
            Controls.Add(listView1);
            Controls.Add(proceedPayment);
            Controls.Add(billLabel);
            Controls.Add(logo);
            Name = "finishBill";
            Text = "Form1";
            Load += finishBill_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label billLabel;
        private Button proceedPayment;
        private ListView listView1;
        private Label labelTotal;
        private Label labelPaymentType;
        private Label labelOrderPrice;
        private Label labelVat;
        private Button buttonDesign;
        private RadioButton DEBITRadio;
        private RadioButton radioButtonVisa;
        private RadioButton radioButtonCash;
        private Label totalPriceCalculate;
    }
}