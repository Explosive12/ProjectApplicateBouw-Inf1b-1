namespace Project1._4
{
    partial class OrderViewLunch
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
            OrderViewStarterFLP = new FlowLayoutPanel();
            orderViewGoToLunchBtn = new Button();
            orderViewGoToDinnerBtn = new Button();
            orderViewGoToDrinksBtn = new Button();
            orderViewTableLbl = new Label();
            orderViewLbl1 = new Label();
            orderViewLbl2 = new Label();
            OrderViewMainFLP = new FlowLayoutPanel();
            OrderViewDessertsFLP = new FlowLayoutPanel();
            orderViewLbl3 = new Label();
            label1 = new Label();
            orderViewCommentBtn = new Button();
            orderViewRemoveBtn = new Button();
            orderViewAddBtn = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // OrderViewStarterFLP
            // 
            OrderViewStarterFLP.AutoScroll = true;
            OrderViewStarterFLP.Location = new Point(28, 165);
            OrderViewStarterFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewStarterFLP.Name = "OrderViewStarterFLP";
            OrderViewStarterFLP.Size = new Size(340, 169);
            OrderViewStarterFLP.TabIndex = 1;
            // 
            // orderViewGoToLunchBtn
            // 
            orderViewGoToLunchBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToLunchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToLunchBtn.Location = new Point(28, 77);
            orderViewGoToLunchBtn.Name = "orderViewGoToLunchBtn";
            orderViewGoToLunchBtn.Size = new Size(86, 41);
            orderViewGoToLunchBtn.TabIndex = 0;
            orderViewGoToLunchBtn.Text = "LUNCH";
            orderViewGoToLunchBtn.UseVisualStyleBackColor = false;
            orderViewGoToLunchBtn.Click += orderViewGoToLunchBtn_Click;
            // 
            // orderViewGoToDinnerBtn
            // 
            orderViewGoToDinnerBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToDinnerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToDinnerBtn.Location = new Point(153, 77);
            orderViewGoToDinnerBtn.Name = "orderViewGoToDinnerBtn";
            orderViewGoToDinnerBtn.Size = new Size(93, 41);
            orderViewGoToDinnerBtn.TabIndex = 2;
            orderViewGoToDinnerBtn.Text = "DINNER";
            orderViewGoToDinnerBtn.UseVisualStyleBackColor = false;
            orderViewGoToDinnerBtn.Click += orderViewGoToDinnerBtn_Click;
            // 
            // orderViewGoToDrinksBtn
            // 
            orderViewGoToDrinksBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToDrinksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToDrinksBtn.Location = new Point(275, 77);
            orderViewGoToDrinksBtn.Name = "orderViewGoToDrinksBtn";
            orderViewGoToDrinksBtn.Size = new Size(93, 41);
            orderViewGoToDrinksBtn.TabIndex = 3;
            orderViewGoToDrinksBtn.Text = "DRINKS";
            orderViewGoToDrinksBtn.UseVisualStyleBackColor = false;
            orderViewGoToDrinksBtn.Click += orderViewGoToDrinksBtn_Click;
            // 
            // orderViewTableLbl
            // 
            orderViewTableLbl.AutoSize = true;
            orderViewTableLbl.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewTableLbl.Location = new Point(119, 9);
            orderViewTableLbl.Name = "orderViewTableLbl";
            orderViewTableLbl.Size = new Size(179, 54);
            orderViewTableLbl.TabIndex = 4;
            orderViewTableLbl.Text = "TABLE {}";
            // 
            // orderViewLbl1
            // 
            orderViewLbl1.AutoSize = true;
            orderViewLbl1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl1.Location = new Point(141, 121);
            orderViewLbl1.Name = "orderViewLbl1";
            orderViewLbl1.Size = new Size(99, 37);
            orderViewLbl1.TabIndex = 5;
            orderViewLbl1.Text = "Entree";
            // 
            // orderViewLbl2
            // 
            orderViewLbl2.AutoSize = true;
            orderViewLbl2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl2.Location = new Point(124, 346);
            orderViewLbl2.Name = "orderViewLbl2";
            orderViewLbl2.Size = new Size(170, 37);
            orderViewLbl2.TabIndex = 6;
            orderViewLbl2.Text = "MainCourse";
            // 
            // OrderViewMainFLP
            // 
            OrderViewMainFLP.AutoScroll = true;
            OrderViewMainFLP.Location = new Point(28, 385);
            OrderViewMainFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewMainFLP.Name = "OrderViewMainFLP";
            OrderViewMainFLP.Size = new Size(340, 169);
            OrderViewMainFLP.TabIndex = 2;
            // 
            // OrderViewDessertsFLP
            // 
            OrderViewDessertsFLP.AutoScroll = true;
            OrderViewDessertsFLP.Location = new Point(28, 609);
            OrderViewDessertsFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewDessertsFLP.Name = "OrderViewDessertsFLP";
            OrderViewDessertsFLP.Size = new Size(340, 169);
            OrderViewDessertsFLP.TabIndex = 7;
            // 
            // orderViewLbl3
            // 
            orderViewLbl3.AutoSize = true;
            orderViewLbl3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl3.Location = new Point(141, 570);
            orderViewLbl3.Name = "orderViewLbl3";
            orderViewLbl3.Size = new Size(126, 37);
            orderViewLbl3.TabIndex = 8;
            orderViewLbl3.Text = "Desserts";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 803);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 9;
            label1.Text = "Orders";
            // 
            // orderViewCommentBtn
            // 
            orderViewCommentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewCommentBtn.Location = new Point(28, 1009);
            orderViewCommentBtn.Name = "orderViewCommentBtn";
            orderViewCommentBtn.Size = new Size(86, 40);
            orderViewCommentBtn.TabIndex = 10;
            orderViewCommentBtn.Text = "COMMENT";
            orderViewCommentBtn.UseVisualStyleBackColor = true;
            // 
            // orderViewRemoveBtn
            // 
            orderViewRemoveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewRemoveBtn.Location = new Point(124, 1009);
            orderViewRemoveBtn.Name = "orderViewRemoveBtn";
            orderViewRemoveBtn.Size = new Size(86, 40);
            orderViewRemoveBtn.TabIndex = 11;
            orderViewRemoveBtn.Text = "REMOVE";
            orderViewRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // orderViewAddBtn
            // 
            orderViewAddBtn.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewAddBtn.Location = new Point(216, 1009);
            orderViewAddBtn.Name = "orderViewAddBtn";
            orderViewAddBtn.Size = new Size(152, 40);
            orderViewAddBtn.TabIndex = 12;
            orderViewAddBtn.Text = "ADD";
            orderViewAddBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(28, 836);
            listView1.Name = "listView1";
            listView1.Size = new Size(340, 167);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "";
            columnHeader2.Width = 250;
            // 
            // OrderViewLunch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(398, 1061);
            Controls.Add(listView1);
            Controls.Add(orderViewAddBtn);
            Controls.Add(orderViewRemoveBtn);
            Controls.Add(orderViewCommentBtn);
            Controls.Add(label1);
            Controls.Add(OrderViewDessertsFLP);
            Controls.Add(orderViewLbl3);
            Controls.Add(OrderViewMainFLP);
            Controls.Add(orderViewLbl2);
            Controls.Add(orderViewLbl1);
            Controls.Add(orderViewTableLbl);
            Controls.Add(orderViewGoToDrinksBtn);
            Controls.Add(orderViewGoToDinnerBtn);
            Controls.Add(orderViewGoToLunchBtn);
            Controls.Add(OrderViewStarterFLP);
            MaximumSize = new Size(414, 1500);
            Name = "OrderViewLunch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderView";
            Load += OrderViewLunch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button testBtn;
        private FlowLayoutPanel OrderViewStarterFLP;
        private Button orderViewGoToLunchBtn;
        private Button orderViewGoToDinnerBtn;
        private Button orderViewGoToDrinksBtn;
        private Label orderViewTableLbl;
        private Label orderViewLbl1;
        private Label orderViewLbl2;
        private FlowLayoutPanel OrderViewMainFLP;
        private FlowLayoutPanel OrderViewDessertsFLP;
        private Label orderViewLbl3;
        private Label label1;
        private Button orderViewCommentBtn;
        private Button orderViewRemoveBtn;
        private Button orderViewAddBtn;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}