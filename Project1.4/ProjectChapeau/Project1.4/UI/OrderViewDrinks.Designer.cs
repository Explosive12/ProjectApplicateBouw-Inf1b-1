namespace Project1._4.UI
{
    partial class OrderViewDrinks
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
            orderViewBeersLbl = new Label();
            OrderViewBeersFLP = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            orderItemLV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            orderViewFinishBtn = new Button();
            orderViewRemoveBtn = new Button();
            orderViewCommentBtn = new Button();
            label1 = new Label();
            OrderViewHotDrinksFLP = new FlowLayoutPanel();
            orderViewLbl3 = new Label();
            OrderViewWinesFLP = new FlowLayoutPanel();
            orderViewLbl2 = new Label();
            orderViewLbl1 = new Label();
            orderViewTableLbl = new Label();
            orderViewGoToDrinksBtn = new Button();
            orderViewGoToDinnerBtn = new Button();
            orderViewGoToLunchBtn = new Button();
            OrderViewSoftDrinksFLP = new FlowLayoutPanel();
            OrderViewSpiritsFLP = new FlowLayoutPanel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // orderViewBeersLbl
            // 
            orderViewBeersLbl.AutoSize = true;
            orderViewBeersLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewBeersLbl.Location = new Point(156, 357);
            orderViewBeersLbl.Name = "orderViewBeersLbl";
            orderViewBeersLbl.Size = new Size(87, 37);
            orderViewBeersLbl.TabIndex = 41;
            orderViewBeersLbl.Text = "Beers";
            // 
            // OrderViewBeersFLP
            // 
            OrderViewBeersFLP.AutoScroll = true;
            OrderViewBeersFLP.Location = new Point(27, 396);
            OrderViewBeersFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewBeersFLP.Name = "OrderViewBeersFLP";
            OrderViewBeersFLP.Size = new Size(340, 169);
            OrderViewBeersFLP.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chapeagoeie;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // orderItemLV
            // 
            orderItemLV.Activation = ItemActivation.OneClick;
            orderItemLV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            orderItemLV.Location = new Point(27, 1328);
            orderItemLV.MultiSelect = false;
            orderItemLV.Name = "orderItemLV";
            orderItemLV.Size = new Size(340, 167);
            orderItemLV.TabIndex = 47;
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
            orderViewFinishBtn.Location = new Point(215, 1501);
            orderViewFinishBtn.Name = "orderViewFinishBtn";
            orderViewFinishBtn.Size = new Size(152, 40);
            orderViewFinishBtn.TabIndex = 46;
            orderViewFinishBtn.Text = "FINISH";
            orderViewFinishBtn.UseVisualStyleBackColor = false;
            orderViewFinishBtn.Click += orderViewFinishBtn_Click;
            // 
            // orderViewRemoveBtn
            // 
            orderViewRemoveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewRemoveBtn.Location = new Point(123, 1501);
            orderViewRemoveBtn.Name = "orderViewRemoveBtn";
            orderViewRemoveBtn.Size = new Size(86, 40);
            orderViewRemoveBtn.TabIndex = 45;
            orderViewRemoveBtn.Text = "REMOVE";
            orderViewRemoveBtn.UseVisualStyleBackColor = true;
            orderViewRemoveBtn.Click += orderViewRemoveBtn_Click;
            // 
            // orderViewCommentBtn
            // 
            orderViewCommentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewCommentBtn.Location = new Point(27, 1501);
            orderViewCommentBtn.Name = "orderViewCommentBtn";
            orderViewCommentBtn.Size = new Size(86, 40);
            orderViewCommentBtn.TabIndex = 44;
            orderViewCommentBtn.Text = "COMMENT";
            orderViewCommentBtn.UseVisualStyleBackColor = true;
            orderViewCommentBtn.Click += orderViewCommentBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 1295);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 43;
            label1.Text = "Orders";
            // 
            // OrderViewHotDrinksFLP
            // 
            OrderViewHotDrinksFLP.AutoScroll = true;
            OrderViewHotDrinksFLP.Location = new Point(27, 1101);
            OrderViewHotDrinksFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewHotDrinksFLP.Name = "OrderViewHotDrinksFLP";
            OrderViewHotDrinksFLP.Size = new Size(340, 169);
            OrderViewHotDrinksFLP.TabIndex = 40;
            // 
            // orderViewLbl3
            // 
            orderViewLbl3.AutoSize = true;
            orderViewLbl3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl3.Location = new Point(121, 1062);
            orderViewLbl3.Name = "orderViewLbl3";
            orderViewLbl3.Size = new Size(148, 37);
            orderViewLbl3.TabIndex = 42;
            orderViewLbl3.Text = "HotDrinks";
            // 
            // OrderViewWinesFLP
            // 
            OrderViewWinesFLP.AutoScroll = true;
            OrderViewWinesFLP.Location = new Point(27, 632);
            OrderViewWinesFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewWinesFLP.Name = "OrderViewWinesFLP";
            OrderViewWinesFLP.Size = new Size(340, 169);
            OrderViewWinesFLP.TabIndex = 33;
            // 
            // orderViewLbl2
            // 
            orderViewLbl2.AutoSize = true;
            orderViewLbl2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl2.Location = new Point(148, 593);
            orderViewLbl2.Name = "orderViewLbl2";
            orderViewLbl2.Size = new Size(95, 37);
            orderViewLbl2.TabIndex = 39;
            orderViewLbl2.Text = "Wines";
            // 
            // orderViewLbl1
            // 
            orderViewLbl1.AccessibleRole = AccessibleRole.TitleBar;
            orderViewLbl1.AutoSize = true;
            orderViewLbl1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewLbl1.Location = new Point(123, 126);
            orderViewLbl1.Name = "orderViewLbl1";
            orderViewLbl1.Size = new Size(153, 37);
            orderViewLbl1.TabIndex = 37;
            orderViewLbl1.Text = "SoftDrinks";
            // 
            // orderViewTableLbl
            // 
            orderViewTableLbl.AutoSize = true;
            orderViewTableLbl.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewTableLbl.Location = new Point(122, 9);
            orderViewTableLbl.Name = "orderViewTableLbl";
            orderViewTableLbl.Size = new Size(179, 54);
            orderViewTableLbl.TabIndex = 36;
            orderViewTableLbl.Text = "TABLE {}";
            // 
            // orderViewGoToDrinksBtn
            // 
            orderViewGoToDrinksBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToDrinksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToDrinksBtn.Location = new Point(278, 77);
            orderViewGoToDrinksBtn.Name = "orderViewGoToDrinksBtn";
            orderViewGoToDrinksBtn.Size = new Size(93, 41);
            orderViewGoToDrinksBtn.TabIndex = 35;
            orderViewGoToDrinksBtn.Text = "DRINKS";
            orderViewGoToDrinksBtn.UseVisualStyleBackColor = false;
            orderViewGoToDrinksBtn.Click += orderViewGoToDrinksBtn_Click;
            // 
            // orderViewGoToDinnerBtn
            // 
            orderViewGoToDinnerBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToDinnerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToDinnerBtn.Location = new Point(156, 77);
            orderViewGoToDinnerBtn.Name = "orderViewGoToDinnerBtn";
            orderViewGoToDinnerBtn.Size = new Size(93, 41);
            orderViewGoToDinnerBtn.TabIndex = 34;
            orderViewGoToDinnerBtn.Text = "DINNER";
            orderViewGoToDinnerBtn.UseVisualStyleBackColor = false;
            orderViewGoToDinnerBtn.Click += orderViewGoToDinnerBtn_Click;
            // 
            // orderViewGoToLunchBtn
            // 
            orderViewGoToLunchBtn.BackColor = Color.FromArgb(138, 210, 176);
            orderViewGoToLunchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderViewGoToLunchBtn.Location = new Point(31, 77);
            orderViewGoToLunchBtn.Name = "orderViewGoToLunchBtn";
            orderViewGoToLunchBtn.Size = new Size(86, 41);
            orderViewGoToLunchBtn.TabIndex = 31;
            orderViewGoToLunchBtn.Text = "LUNCH";
            orderViewGoToLunchBtn.UseVisualStyleBackColor = false;
            orderViewGoToLunchBtn.Click += orderViewGoToLunchBtn_Click;
            // 
            // OrderViewSoftDrinksFLP
            // 
            OrderViewSoftDrinksFLP.AutoScroll = true;
            OrderViewSoftDrinksFLP.Location = new Point(31, 165);
            OrderViewSoftDrinksFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewSoftDrinksFLP.Name = "OrderViewSoftDrinksFLP";
            OrderViewSoftDrinksFLP.Size = new Size(340, 169);
            OrderViewSoftDrinksFLP.TabIndex = 32;
            // 
            // OrderViewSpiritsFLP
            // 
            OrderViewSpiritsFLP.AutoScroll = true;
            OrderViewSpiritsFLP.Location = new Point(27, 857);
            OrderViewSpiritsFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewSpiritsFLP.Name = "OrderViewSpiritsFLP";
            OrderViewSpiritsFLP.Size = new Size(340, 169);
            OrderViewSpiritsFLP.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(144, 818);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 50;
            label2.Text = "Spirits";
            // 
            // OrderViewDrinks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(398, 661);
            Controls.Add(OrderViewSpiritsFLP);
            Controls.Add(label2);
            Controls.Add(orderViewBeersLbl);
            Controls.Add(OrderViewBeersFLP);
            Controls.Add(pictureBox1);
            Controls.Add(orderItemLV);
            Controls.Add(orderViewFinishBtn);
            Controls.Add(orderViewRemoveBtn);
            Controls.Add(orderViewCommentBtn);
            Controls.Add(label1);
            Controls.Add(OrderViewHotDrinksFLP);
            Controls.Add(orderViewLbl3);
            Controls.Add(OrderViewWinesFLP);
            Controls.Add(orderViewLbl2);
            Controls.Add(orderViewLbl1);
            Controls.Add(orderViewTableLbl);
            Controls.Add(orderViewGoToDrinksBtn);
            Controls.Add(orderViewGoToDinnerBtn);
            Controls.Add(orderViewGoToLunchBtn);
            Controls.Add(OrderViewSoftDrinksFLP);
            MaximumSize = new Size(414, 1500);
            Name = "OrderViewDrinks";
            Text = "OrderViewDrinks";
            Load += OrderViewDrinks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderViewBeersLbl;
        private FlowLayoutPanel OrderViewBeersFLP;
        private PictureBox pictureBox1;
        private ListView orderItemLV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button orderViewFinishBtn;
        private Button orderViewRemoveBtn;
        private Button orderViewCommentBtn;
        private Label label1;
        private FlowLayoutPanel OrderViewHotDrinksFLP;
        private Label orderViewLbl3;
        private FlowLayoutPanel OrderViewWinesFLP;
        private Label orderViewLbl2;
        private Label orderViewLbl1;
        private Label orderViewTableLbl;
        private Button orderViewGoToDrinksBtn;
        private Button orderViewGoToDinnerBtn;
        private Button orderViewGoToLunchBtn;
        private FlowLayoutPanel OrderViewSoftDrinksFLP;
        private FlowLayoutPanel OrderViewSpiritsFLP;
        private Label label2;
    }
}