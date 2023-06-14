namespace Project1._4.UI
{
    partial class OrderViewDinner
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
            orderViewTableLbl = new Label();
            orderViewGoToDrinksBtn = new Button();
            orderViewGoToDinnerBtn = new Button();
            orderViewGoToLunchBtn = new Button();
            OrderViewFLP = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // orderViewTableLbl
            // 
            orderViewTableLbl.AutoSize = true;
            orderViewTableLbl.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            orderViewTableLbl.Location = new Point(105, 9);
            orderViewTableLbl.Name = "orderViewTableLbl";
            orderViewTableLbl.Size = new Size(164, 54);
            orderViewTableLbl.TabIndex = 9;
            orderViewTableLbl.Text = "TABLE {}";
            // 
            // orderViewGoToDrinksBtn
            // 
            orderViewGoToDrinksBtn.Location = new Point(243, 77);
            orderViewGoToDrinksBtn.Name = "orderViewGoToDrinksBtn";
            orderViewGoToDrinksBtn.Size = new Size(103, 41);
            orderViewGoToDrinksBtn.TabIndex = 8;
            orderViewGoToDrinksBtn.Text = "DRINKS";
            orderViewGoToDrinksBtn.UseVisualStyleBackColor = true;
            orderViewGoToDrinksBtn.Click += orderViewGoToDrinksBtn_Click;
            // 
            // orderViewGoToDinnerBtn
            // 
            orderViewGoToDinnerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            orderViewGoToDinnerBtn.Location = new Point(128, 77);
            orderViewGoToDinnerBtn.Name = "orderViewGoToDinnerBtn";
            orderViewGoToDinnerBtn.Size = new Size(93, 41);
            orderViewGoToDinnerBtn.TabIndex = 7;
            orderViewGoToDinnerBtn.Text = "DINNER";
            orderViewGoToDinnerBtn.UseVisualStyleBackColor = true;
            orderViewGoToDinnerBtn.Click += orderViewGoToDinnerBtn_Click;
            // 
            // orderViewGoToLunchBtn
            // 
            orderViewGoToLunchBtn.Location = new Point(22, 77);
            orderViewGoToLunchBtn.Name = "orderViewGoToLunchBtn";
            orderViewGoToLunchBtn.Size = new Size(86, 41);
            orderViewGoToLunchBtn.TabIndex = 5;
            orderViewGoToLunchBtn.Text = "LUNCH";
            orderViewGoToLunchBtn.UseVisualStyleBackColor = true;
            orderViewGoToLunchBtn.Click += orderViewGoToLunchBtn_Click;
            // 
            // OrderViewFLP
            // 
            OrderViewFLP.AutoScroll = true;
            OrderViewFLP.Location = new Point(22, 154);
            OrderViewFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewFLP.Name = "OrderViewFLP";
            OrderViewFLP.Size = new Size(340, 169);
            OrderViewFLP.TabIndex = 6;
            // 
            // OrderViewDinner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(orderViewTableLbl);
            Controls.Add(orderViewGoToDrinksBtn);
            Controls.Add(orderViewGoToDinnerBtn);
            Controls.Add(orderViewGoToLunchBtn);
            Controls.Add(OrderViewFLP);
            Name = "OrderViewDinner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderViewDinner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderViewTableLbl;
        private Button orderViewGoToDrinksBtn;
        private Button orderViewGoToDinnerBtn;
        private Button orderViewGoToLunchBtn;
        private FlowLayoutPanel OrderViewFLP;
    }
}