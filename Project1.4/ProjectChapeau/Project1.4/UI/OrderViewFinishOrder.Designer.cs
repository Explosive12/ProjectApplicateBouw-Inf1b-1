namespace Project1._4.UI
{
    partial class OrderViewFinishOrder
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
            pictureBox1 = new PictureBox();
            orderViewTableLbl = new Label();
            orderViewGoToDrinksBtn = new Button();
            orderViewGoToDinnerBtn = new Button();
            orderViewGoToLunchBtn = new Button();
            orderItemLV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            orderViewPriceLbl = new Label();
            orderViewVATLbl = new Label();
            orderViewPayBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chapeagoeie;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // orderViewTableLbl
            // 
            orderViewTableLbl.AutoSize = true;
            orderViewTableLbl.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewTableLbl.Location = new Point(121, 9);
            orderViewTableLbl.Name = "orderViewTableLbl";
            orderViewTableLbl.Size = new Size(179, 54);
            orderViewTableLbl.TabIndex = 18;
            orderViewTableLbl.Text = "TABLE {}";
            // 
            // orderViewGoToDrinksBtn
            // 
            orderViewGoToDrinksBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToDrinksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToDrinksBtn.Location = new Point(277, 77);
            orderViewGoToDrinksBtn.Name = "orderViewGoToDrinksBtn";
            orderViewGoToDrinksBtn.Size = new Size(93, 41);
            orderViewGoToDrinksBtn.TabIndex = 17;
            orderViewGoToDrinksBtn.Text = "DRINKS";
            orderViewGoToDrinksBtn.UseVisualStyleBackColor = false;
            orderViewGoToDrinksBtn.Click += orderViewGoToDrinksBtn_Click;
            // 
            // orderViewGoToDinnerBtn
            // 
            orderViewGoToDinnerBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToDinnerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToDinnerBtn.Location = new Point(155, 77);
            orderViewGoToDinnerBtn.Name = "orderViewGoToDinnerBtn";
            orderViewGoToDinnerBtn.Size = new Size(93, 41);
            orderViewGoToDinnerBtn.TabIndex = 16;
            orderViewGoToDinnerBtn.Text = "DINNER";
            orderViewGoToDinnerBtn.UseVisualStyleBackColor = false;
            orderViewGoToDinnerBtn.Click += orderViewGoToDinnerBtn_Click;
            // 
            // orderViewGoToLunchBtn
            // 
            orderViewGoToLunchBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToLunchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToLunchBtn.Location = new Point(30, 77);
            orderViewGoToLunchBtn.Name = "orderViewGoToLunchBtn";
            orderViewGoToLunchBtn.Size = new Size(86, 41);
            orderViewGoToLunchBtn.TabIndex = 15;
            orderViewGoToLunchBtn.Text = "LUNCH";
            orderViewGoToLunchBtn.UseVisualStyleBackColor = false;
            orderViewGoToLunchBtn.Click += orderViewGoToLunchBtn_Click;
            // 
            // orderItemLV
            // 
            orderItemLV.Activation = ItemActivation.OneClick;
            orderItemLV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            orderItemLV.HoverSelection = true;
            orderItemLV.Location = new Point(30, 139);
            orderItemLV.MultiSelect = false;
            orderItemLV.Name = "orderItemLV";
            orderItemLV.Size = new Size(340, 322);
            orderItemLV.TabIndex = 20;
            orderItemLV.UseCompatibleStateImageBehavior = false;
            orderItemLV.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "no.";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "name";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "price";
            columnHeader3.Width = 70;
            // 
            // orderViewPriceLbl
            // 
            orderViewPriceLbl.AutoSize = true;
            orderViewPriceLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewPriceLbl.Location = new Point(205, 464);
            orderViewPriceLbl.Name = "orderViewPriceLbl";
            orderViewPriceLbl.RightToLeft = RightToLeft.No;
            orderViewPriceLbl.Size = new Size(124, 37);
            orderViewPriceLbl.TabIndex = 21;
            orderViewPriceLbl.Text = "Totaal:{}";
            // 
            // orderViewVATLbl
            // 
            orderViewVATLbl.AutoSize = true;
            orderViewVATLbl.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            orderViewVATLbl.Location = new Point(246, 501);
            orderViewVATLbl.Name = "orderViewVATLbl";
            orderViewVATLbl.Size = new Size(54, 28);
            orderViewVATLbl.TabIndex = 22;
            orderViewVATLbl.Text = "VAT:";
            // 
            // orderViewPayBtn
            // 
            orderViewPayBtn.BackColor = Color.DarkOrange;
            orderViewPayBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewPayBtn.Location = new Point(255, 550);
            orderViewPayBtn.Name = "orderViewPayBtn";
            orderViewPayBtn.Size = new Size(115, 49);
            orderViewPayBtn.TabIndex = 23;
            orderViewPayBtn.Text = "PAY";
            orderViewPayBtn.UseVisualStyleBackColor = false;
            orderViewPayBtn.Click += orderViewPayBtn_Click;
            // 
            // OrderViewFinishOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 611);
            Controls.Add(orderViewPayBtn);
            Controls.Add(orderViewVATLbl);
            Controls.Add(orderViewPriceLbl);
            Controls.Add(orderItemLV);
            Controls.Add(pictureBox1);
            Controls.Add(orderViewTableLbl);
            Controls.Add(orderViewGoToDrinksBtn);
            Controls.Add(orderViewGoToDinnerBtn);
            Controls.Add(orderViewGoToLunchBtn);
            Name = "OrderViewFinishOrder";
            Text = "OrderViewFinishOrder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label orderViewTableLbl;
        private Button orderViewGoToDrinksBtn;
        private Button orderViewGoToDinnerBtn;
        private Button orderViewGoToLunchBtn;
        private ListView orderItemLV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label orderViewPriceLbl;
        private Label orderViewVATLbl;
        private Button orderViewPayBtn;
    }
}