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
            pictureBox1 = new PictureBox();
            orderItemLV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            orderViewFinishBtn = new Button();
            orderViewRemoveBtn = new Button();
            orderViewCommentBtn = new Button();
            label1 = new Label();
            OrderViewDessertsFLP = new FlowLayoutPanel();
            orderViewLbl3 = new Label();
            OrderViewMainFLP = new FlowLayoutPanel();
            orderViewLbl2 = new Label();
            orderViewLbl1 = new Label();
            orderViewTableLbl = new Label();
            orderViewGoToDrinksBtn = new Button();
            orderViewGoToDinnerBtn = new Button();
            orderViewGoToLunchBtn = new Button();
            OrderViewStarterFLP = new FlowLayoutPanel();
            orderViewSideDish = new Label();
            OrderViewSideDishFLP = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chapeagoeie;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // orderItemLV
            // 
            orderItemLV.Activation = ItemActivation.OneClick;
            orderItemLV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            orderItemLV.Location = new Point(27, 1082);
            orderItemLV.MultiSelect = false;
            orderItemLV.Name = "orderItemLV";
            orderItemLV.Size = new Size(340, 167);
            orderItemLV.TabIndex = 29;
            orderItemLV.UseCompatibleStateImageBehavior = false;
            orderItemLV.View = View.Details;
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
            // orderViewFinishBtn
            // 
            orderViewFinishBtn.BackColor = Color.DarkOrange;
            orderViewFinishBtn.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewFinishBtn.Location = new Point(215, 1255);
            orderViewFinishBtn.Name = "orderViewFinishBtn";
            orderViewFinishBtn.Size = new Size(152, 40);
            orderViewFinishBtn.TabIndex = 28;
            orderViewFinishBtn.Text = "FINISH";
            orderViewFinishBtn.UseVisualStyleBackColor = false;
            orderViewFinishBtn.Click += orderViewFinishBtn_Click;
            // 
            // orderViewRemoveBtn
            // 
            orderViewRemoveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewRemoveBtn.Location = new Point(123, 1255);
            orderViewRemoveBtn.Name = "orderViewRemoveBtn";
            orderViewRemoveBtn.Size = new Size(86, 40);
            orderViewRemoveBtn.TabIndex = 27;
            orderViewRemoveBtn.Text = "REMOVE";
            orderViewRemoveBtn.UseVisualStyleBackColor = true;
            orderViewRemoveBtn.Click += orderViewRemoveBtn_Click;
            // 
            // orderViewCommentBtn
            // 
            orderViewCommentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewCommentBtn.Location = new Point(27, 1255);
            orderViewCommentBtn.Name = "orderViewCommentBtn";
            orderViewCommentBtn.Size = new Size(86, 40);
            orderViewCommentBtn.TabIndex = 26;
            orderViewCommentBtn.Text = "COMMENT";
            orderViewCommentBtn.UseVisualStyleBackColor = true;
            orderViewCommentBtn.Click += orderViewCommentBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 1049);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 25;
            label1.Text = "Orders";
            // 
            // OrderViewDessertsFLP
            // 
            OrderViewDessertsFLP.AutoScroll = true;
            OrderViewDessertsFLP.Location = new Point(27, 855);
            OrderViewDessertsFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewDessertsFLP.Name = "OrderViewDessertsFLP";
            OrderViewDessertsFLP.Size = new Size(340, 169);
            OrderViewDessertsFLP.TabIndex = 23;
            // 
            // orderViewLbl3
            // 
            orderViewLbl3.AutoSize = true;
            orderViewLbl3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl3.Location = new Point(140, 816);
            orderViewLbl3.Name = "orderViewLbl3";
            orderViewLbl3.Size = new Size(126, 37);
            orderViewLbl3.TabIndex = 24;
            orderViewLbl3.Text = "Desserts";
            // 
            // OrderViewMainFLP
            // 
            OrderViewMainFLP.AutoScroll = true;
            OrderViewMainFLP.Location = new Point(27, 631);
            OrderViewMainFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewMainFLP.Name = "OrderViewMainFLP";
            OrderViewMainFLP.Size = new Size(340, 169);
            OrderViewMainFLP.TabIndex = 17;
            // 
            // orderViewLbl2
            // 
            orderViewLbl2.AutoSize = true;
            orderViewLbl2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl2.Location = new Point(123, 592);
            orderViewLbl2.Name = "orderViewLbl2";
            orderViewLbl2.Size = new Size(170, 37);
            orderViewLbl2.TabIndex = 22;
            orderViewLbl2.Text = "MainCourse";
            // 
            // orderViewLbl1
            // 
            orderViewLbl1.AutoSize = true;
            orderViewLbl1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl1.Location = new Point(144, 120);
            orderViewLbl1.Name = "orderViewLbl1";
            orderViewLbl1.Size = new Size(99, 37);
            orderViewLbl1.TabIndex = 21;
            orderViewLbl1.Text = "Entree";
            // 
            // orderViewTableLbl
            // 
            orderViewTableLbl.AutoSize = true;
            orderViewTableLbl.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewTableLbl.Location = new Point(122, 8);
            orderViewTableLbl.Name = "orderViewTableLbl";
            orderViewTableLbl.Size = new Size(179, 54);
            orderViewTableLbl.TabIndex = 20;
            orderViewTableLbl.Text = "TABLE {}";
            // 
            // orderViewGoToDrinksBtn
            // 
            orderViewGoToDrinksBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToDrinksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToDrinksBtn.Location = new Point(278, 76);
            orderViewGoToDrinksBtn.Name = "orderViewGoToDrinksBtn";
            orderViewGoToDrinksBtn.Size = new Size(93, 41);
            orderViewGoToDrinksBtn.TabIndex = 19;
            orderViewGoToDrinksBtn.Text = "DRINKS";
            orderViewGoToDrinksBtn.UseVisualStyleBackColor = false;
            orderViewGoToDrinksBtn.Click += orderViewGoToDrinksBtn_Click;
            // 
            // orderViewGoToDinnerBtn
            // 
            orderViewGoToDinnerBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToDinnerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToDinnerBtn.Location = new Point(156, 76);
            orderViewGoToDinnerBtn.Name = "orderViewGoToDinnerBtn";
            orderViewGoToDinnerBtn.Size = new Size(93, 41);
            orderViewGoToDinnerBtn.TabIndex = 18;
            orderViewGoToDinnerBtn.Text = "DINNER";
            orderViewGoToDinnerBtn.UseVisualStyleBackColor = false;
            orderViewGoToDinnerBtn.Click += orderViewGoToDinnerBtn_Click;
            // 
            // orderViewGoToLunchBtn
            // 
            orderViewGoToLunchBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToLunchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToLunchBtn.Location = new Point(31, 76);
            orderViewGoToLunchBtn.Name = "orderViewGoToLunchBtn";
            orderViewGoToLunchBtn.Size = new Size(86, 41);
            orderViewGoToLunchBtn.TabIndex = 15;
            orderViewGoToLunchBtn.Text = "LUNCH";
            orderViewGoToLunchBtn.UseVisualStyleBackColor = false;
            orderViewGoToLunchBtn.Click += orderViewGoToLunchBtn_Click;
            // 
            // OrderViewStarterFLP
            // 
            OrderViewStarterFLP.AutoScroll = true;
            OrderViewStarterFLP.Location = new Point(31, 164);
            OrderViewStarterFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewStarterFLP.Name = "OrderViewStarterFLP";
            OrderViewStarterFLP.Size = new Size(340, 169);
            OrderViewStarterFLP.TabIndex = 16;
            // 
            // orderViewSideDish
            // 
            orderViewSideDish.AutoSize = true;
            orderViewSideDish.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewSideDish.Location = new Point(132, 356);
            orderViewSideDish.Name = "orderViewSideDish";
            orderViewSideDish.Size = new Size(128, 37);
            orderViewSideDish.TabIndex = 23;
            orderViewSideDish.Text = "SideDish";
            // 
            // OrderViewSideDishFLP
            // 
            OrderViewSideDishFLP.AutoScroll = true;
            OrderViewSideDishFLP.Location = new Point(27, 395);
            OrderViewSideDishFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewSideDishFLP.Name = "OrderViewSideDishFLP";
            OrderViewSideDishFLP.Size = new Size(340, 169);
            OrderViewSideDishFLP.TabIndex = 22;
            // 
            // OrderViewDinner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 661);
            Controls.Add(orderViewSideDish);
            Controls.Add(OrderViewSideDishFLP);
            Controls.Add(pictureBox1);
            Controls.Add(orderItemLV);
            Controls.Add(orderViewFinishBtn);
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
            MaximumSize = new Size(414, 700);
            Name = "OrderViewDinner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderViewDinner";
            Load += OrderViewDinner_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListView orderItemLV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button orderViewFinishBtn;
        private Button orderViewRemoveBtn;
        private Button orderViewCommentBtn;
        private Label label1;
        private FlowLayoutPanel OrderViewDessertsFLP;
        private Label orderViewLbl3;
        private FlowLayoutPanel OrderViewMainFLP;
        private Label orderViewLbl2;
        private Label orderViewLbl1;
        private Label orderViewTableLbl;
        private Button orderViewGoToDrinksBtn;
        private Button orderViewGoToDinnerBtn;
        private Button orderViewGoToLunchBtn;
        private FlowLayoutPanel OrderViewStarterFLP;
        private Label orderViewSideDish;
        private FlowLayoutPanel OrderViewSideDishFLP;
    }
}