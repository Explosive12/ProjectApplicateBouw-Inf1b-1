namespace Project1._4
{
    partial class BarOrderControl
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
            lblBarHeader = new Label();
            barOrderItems = new ColumnHeader();
            barWaitTime = new ColumnHeader();
            barOrderTime = new ColumnHeader();
            barTableNumber = new ColumnHeader();
            lblSelectedOrder = new Label();
            lblStatusOfDish = new Label();
            btnServedBar = new Button();
            btnPreparedBar = new Button();
            btnPreparationBar = new Button();
            lblViewOrderStatusHeaderBar = new Label();
            lblChangeStatusHeaderBar = new Label();
            lblDescriptionHeaderBar = new Label();
            lblCountHeaderBar = new Label();
            lblOrderNumberHeaderBar = new Label();
            lblOrderIDHeaderBar = new Label();
            pbxHeaderBar = new PictureBox();
            listViewBarOrders = new ListView();
            barOrderId = new ColumnHeader();
            barAmount = new ColumnHeader();
            barComment = new ColumnHeader();
            cbxStatusBar = new ComboBox();
            pbxOrderByStatusBar = new PictureBox();
            pbxHeaderViewOrderStatusBar = new PictureBox();
            lblViewOrderByStatusHeaderBar = new Label();
            btnFilterByStatusBar = new Button();
            lblWaitingTimeHeader = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxOrderByStatusBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusBar).BeginInit();
            SuspendLayout();
            // 
            // lblBarHeader
            // 
            lblBarHeader.AutoSize = true;
            lblBarHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarHeader.Location = new Point(887, 70);
            lblBarHeader.Name = "lblBarHeader";
            lblBarHeader.Size = new Size(410, 104);
            lblBarHeader.TabIndex = 68;
            lblBarHeader.Text = "Bar Orders";
            lblBarHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // barOrderItems
            // 
            barOrderItems.Text = "order items";
            barOrderItems.Width = 200;
            // 
            // barWaitTime
            // 
            barWaitTime.Text = "wait time";
            barWaitTime.Width = 200;
            // 
            // barOrderTime
            // 
            barOrderTime.Text = "order time";
            barOrderTime.Width = 200;
            // 
            // barTableNumber
            // 
            barTableNumber.Text = "table number";
            barTableNumber.Width = 200;
            // 
            // lblSelectedOrder
            // 
            lblSelectedOrder.AutoSize = true;
            lblSelectedOrder.Location = new Point(1722, 638);
            lblSelectedOrder.Margin = new Padding(2, 0, 2, 0);
            lblSelectedOrder.Name = "lblSelectedOrder";
            lblSelectedOrder.Size = new Size(198, 37);
            lblSelectedOrder.TabIndex = 67;
            lblSelectedOrder.Text = "{selectedOrder}";
            // 
            // lblStatusOfDish
            // 
            lblStatusOfDish.AutoSize = true;
            lblStatusOfDish.Location = new Point(2097, 638);
            lblStatusOfDish.Margin = new Padding(2, 0, 2, 0);
            lblStatusOfDish.Name = "lblStatusOfDish";
            lblStatusOfDish.Size = new Size(102, 37);
            lblStatusOfDish.TabIndex = 65;
            lblStatusOfDish.Text = "{status}";
            // 
            // btnServedBar
            // 
            btnServedBar.BackColor = Color.FromArgb(138, 210, 176);
            btnServedBar.ForeColor = Color.Black;
            btnServedBar.Location = new Point(2128, 386);
            btnServedBar.Margin = new Padding(2);
            btnServedBar.Name = "btnServedBar";
            btnServedBar.Size = new Size(253, 52);
            btnServedBar.TabIndex = 62;
            btnServedBar.Text = "Served";
            btnServedBar.UseVisualStyleBackColor = false;
            btnServedBar.Click += btnServedBar_Click;
            // 
            // btnPreparedBar
            // 
            btnPreparedBar.BackColor = Color.FromArgb(255, 179, 71);
            btnPreparedBar.Location = new Point(1858, 386);
            btnPreparedBar.Margin = new Padding(2);
            btnPreparedBar.Name = "btnPreparedBar";
            btnPreparedBar.Size = new Size(253, 52);
            btnPreparedBar.TabIndex = 61;
            btnPreparedBar.Text = "Prepared";
            btnPreparedBar.UseVisualStyleBackColor = false;
            btnPreparedBar.Click += btnPreparedBar_Click;
            // 
            // btnPreparationBar
            // 
            btnPreparationBar.Location = new Point(1586, 386);
            btnPreparationBar.Margin = new Padding(2);
            btnPreparationBar.Name = "btnPreparationBar";
            btnPreparationBar.Size = new Size(253, 52);
            btnPreparationBar.TabIndex = 59;
            btnPreparationBar.Text = "in preparation";
            btnPreparationBar.UseVisualStyleBackColor = true;
            btnPreparationBar.Click += btnPreparationBar_Click;
            // 
            // lblViewOrderStatusHeaderBar
            // 
            lblViewOrderStatusHeaderBar.AutoSize = true;
            lblViewOrderStatusHeaderBar.BackColor = Color.Orange;
            lblViewOrderStatusHeaderBar.Location = new Point(1870, 520);
            lblViewOrderStatusHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblViewOrderStatusHeaderBar.Name = "lblViewOrderStatusHeaderBar";
            lblViewOrderStatusHeaderBar.Size = new Size(222, 37);
            lblViewOrderStatusHeaderBar.TabIndex = 64;
            lblViewOrderStatusHeaderBar.Text = "View order status";
            // 
            // lblChangeStatusHeaderBar
            // 
            lblChangeStatusHeaderBar.AutoSize = true;
            lblChangeStatusHeaderBar.BackColor = Color.Orange;
            lblChangeStatusHeaderBar.Location = new Point(1870, 280);
            lblChangeStatusHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblChangeStatusHeaderBar.Name = "lblChangeStatusHeaderBar";
            lblChangeStatusHeaderBar.Size = new Size(255, 37);
            lblChangeStatusHeaderBar.TabIndex = 58;
            lblChangeStatusHeaderBar.Text = "Change order status";
            // 
            // lblDescriptionHeaderBar
            // 
            lblDescriptionHeaderBar.AutoSize = true;
            lblDescriptionHeaderBar.BackColor = Color.Orange;
            lblDescriptionHeaderBar.Location = new Point(1280, 280);
            lblDescriptionHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblDescriptionHeaderBar.Name = "lblDescriptionHeaderBar";
            lblDescriptionHeaderBar.Size = new Size(134, 37);
            lblDescriptionHeaderBar.TabIndex = 57;
            lblDescriptionHeaderBar.Text = "Comment";
            // 
            // lblCountHeaderBar
            // 
            lblCountHeaderBar.AutoSize = true;
            lblCountHeaderBar.BackColor = Color.Orange;
            lblCountHeaderBar.Location = new Point(1076, 280);
            lblCountHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblCountHeaderBar.Name = "lblCountHeaderBar";
            lblCountHeaderBar.Size = new Size(112, 37);
            lblCountHeaderBar.TabIndex = 56;
            lblCountHeaderBar.Text = "Amount";
            // 
            // lblOrderNumberHeaderBar
            // 
            lblOrderNumberHeaderBar.AutoSize = true;
            lblOrderNumberHeaderBar.BackColor = Color.Orange;
            lblOrderNumberHeaderBar.Location = new Point(867, 280);
            lblOrderNumberHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblOrderNumberHeaderBar.Name = "lblOrderNumberHeaderBar";
            lblOrderNumberHeaderBar.Size = new Size(184, 37);
            lblOrderNumberHeaderBar.TabIndex = 55;
            lblOrderNumberHeaderBar.Text = "Order number";
            // 
            // lblOrderIDHeaderBar
            // 
            lblOrderIDHeaderBar.AutoSize = true;
            lblOrderIDHeaderBar.BackColor = Color.Orange;
            lblOrderIDHeaderBar.ImageAlign = ContentAlignment.BottomRight;
            lblOrderIDHeaderBar.Location = new Point(78, 280);
            lblOrderIDHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblOrderIDHeaderBar.Name = "lblOrderIDHeaderBar";
            lblOrderIDHeaderBar.Size = new Size(118, 37);
            lblOrderIDHeaderBar.TabIndex = 54;
            lblOrderIDHeaderBar.Text = "Order ID";
            // 
            // pbxHeaderBar
            // 
            pbxHeaderBar.BackColor = Color.Orange;
            pbxHeaderBar.Location = new Point(0, 238);
            pbxHeaderBar.Margin = new Padding(2);
            pbxHeaderBar.Name = "pbxHeaderBar";
            pbxHeaderBar.Size = new Size(2420, 111);
            pbxHeaderBar.TabIndex = 60;
            pbxHeaderBar.TabStop = false;
            // 
            // listViewBarOrders
            // 
            listViewBarOrders.Columns.AddRange(new ColumnHeader[] { barOrderId, barTableNumber, barOrderTime, barWaitTime, barOrderItems, barAmount, barComment });
            listViewBarOrders.Location = new Point(78, 348);
            listViewBarOrders.Margin = new Padding(2);
            listViewBarOrders.Name = "listViewBarOrders";
            listViewBarOrders.Size = new Size(1386, 563);
            listViewBarOrders.TabIndex = 66;
            listViewBarOrders.UseCompatibleStateImageBehavior = false;
            listViewBarOrders.View = View.Details;
            listViewBarOrders.SelectedIndexChanged += listViewBarOrders_SelectedIndexChanged;
            // 
            // barOrderId
            // 
            barOrderId.Text = "Order Id";
            barOrderId.Width = 200;
            // 
            // barAmount
            // 
            barAmount.Text = "Amount";
            barAmount.Width = 200;
            // 
            // barComment
            // 
            barComment.Text = "comment";
            barComment.Width = 200;
            // 
            // cbxStatusBar
            // 
            cbxStatusBar.FormattingEnabled = true;
            cbxStatusBar.Location = new Point(1653, 871);
            cbxStatusBar.Name = "cbxStatusBar";
            cbxStatusBar.Size = new Size(272, 45);
            cbxStatusBar.TabIndex = 69;
            // 
            // pbxOrderByStatusBar
            // 
            pbxOrderByStatusBar.BackColor = Color.Orange;
            pbxOrderByStatusBar.Location = new Point(1586, 708);
            pbxOrderByStatusBar.Margin = new Padding(2);
            pbxOrderByStatusBar.Name = "pbxOrderByStatusBar";
            pbxOrderByStatusBar.Size = new Size(836, 111);
            pbxOrderByStatusBar.TabIndex = 70;
            pbxOrderByStatusBar.TabStop = false;
            // 
            // pbxHeaderViewOrderStatusBar
            // 
            pbxHeaderViewOrderStatusBar.BackColor = Color.Orange;
            pbxHeaderViewOrderStatusBar.Location = new Point(1586, 489);
            pbxHeaderViewOrderStatusBar.Margin = new Padding(2);
            pbxHeaderViewOrderStatusBar.Name = "pbxHeaderViewOrderStatusBar";
            pbxHeaderViewOrderStatusBar.Size = new Size(836, 111);
            pbxHeaderViewOrderStatusBar.TabIndex = 63;
            pbxHeaderViewOrderStatusBar.TabStop = false;
            // 
            // lblViewOrderByStatusHeaderBar
            // 
            lblViewOrderByStatusHeaderBar.AutoSize = true;
            lblViewOrderByStatusHeaderBar.BackColor = Color.Orange;
            lblViewOrderByStatusHeaderBar.Location = new Point(1809, 745);
            lblViewOrderByStatusHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblViewOrderByStatusHeaderBar.Name = "lblViewOrderByStatusHeaderBar";
            lblViewOrderByStatusHeaderBar.Size = new Size(263, 37);
            lblViewOrderByStatusHeaderBar.TabIndex = 71;
            lblViewOrderByStatusHeaderBar.Text = "View Order By Status";
            // 
            // btnFilterByStatusBar
            // 
            btnFilterByStatusBar.Location = new Point(2073, 864);
            btnFilterByStatusBar.Name = "btnFilterByStatusBar";
            btnFilterByStatusBar.Size = new Size(169, 52);
            btnFilterByStatusBar.TabIndex = 72;
            btnFilterByStatusBar.Text = "filter";
            btnFilterByStatusBar.UseVisualStyleBackColor = true;
            btnFilterByStatusBar.Click += btnFilterByStatusBar_Click;
            // 
            // lblWaitingTimeHeader
            // 
            lblWaitingTimeHeader.AutoSize = true;
            lblWaitingTimeHeader.BackColor = Color.Orange;
            lblWaitingTimeHeader.Location = new Point(664, 280);
            lblWaitingTimeHeader.Margin = new Padding(2, 0, 2, 0);
            lblWaitingTimeHeader.Name = "lblWaitingTimeHeader";
            lblWaitingTimeHeader.Size = new Size(174, 37);
            lblWaitingTimeHeader.TabIndex = 73;
            lblWaitingTimeHeader.Text = "Waiting Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Location = new Point(479, 280);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 74;
            label1.Text = "Order Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Location = new Point(276, 280);
            label2.Name = "label2";
            label2.Size = new Size(183, 37);
            label2.TabIndex = 75;
            label2.Text = "Table Number";
            // 
            // BarOrderControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblWaitingTimeHeader);
            Controls.Add(btnFilterByStatusBar);
            Controls.Add(lblViewOrderByStatusHeaderBar);
            Controls.Add(pbxOrderByStatusBar);
            Controls.Add(cbxStatusBar);
            Controls.Add(lblBarHeader);
            Controls.Add(lblSelectedOrder);
            Controls.Add(lblStatusOfDish);
            Controls.Add(btnServedBar);
            Controls.Add(btnPreparedBar);
            Controls.Add(btnPreparationBar);
            Controls.Add(lblViewOrderStatusHeaderBar);
            Controls.Add(lblChangeStatusHeaderBar);
            Controls.Add(lblDescriptionHeaderBar);
            Controls.Add(lblCountHeaderBar);
            Controls.Add(lblOrderNumberHeaderBar);
            Controls.Add(lblOrderIDHeaderBar);
            Controls.Add(pbxHeaderViewOrderStatusBar);
            Controls.Add(pbxHeaderBar);
            Controls.Add(listViewBarOrders);
            Name = "BarOrderControl";
            Size = new Size(2422, 1029);
            ((System.ComponentModel.ISupportInitialize)pbxHeaderBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxOrderByStatusBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBarHeader;
        private ColumnHeader kitchenDescription;
        private ColumnHeader kitchenOrderCount;
        private ColumnHeader kitchenOrderNumber;
        private ColumnHeader kitchenOrderId;
        private Label lblSelectedOrder;
        private Label lblStatusOfDish;
        private Button btnServedBar;
        private Button btnPreparedBar;
        private Button btnPreparationBar;
        private Label lblViewOrderStatusHeaderBar;
        private Label lblChangeStatusHeaderBar;
        private Label lblDescriptionHeaderBar;
        private Label lblCountHeaderBar;
        private Label lblOrderNumberHeaderBar;
        private Label lblOrderIDHeaderBar;
        private PictureBox pbxHeaderBar;
        private ListView listViewBarOrders;
        private ComboBox cbxStatusBar;
        private PictureBox pbxOrderByStatusBar;
        private PictureBox pbxHeaderViewOrderStatusBar;
        private Label lblViewOrderByStatusHeaderBar;
        private Button btnFilterByStatusBar;
        private ColumnHeader barWaitingTime;
        private Label lblWaitingTimeHeader;
        private ColumnHeader kitchenTableNumber;
        private ColumnHeader kitchenOrderTime;
        private ColumnHeader kitchenWaitTime;
        private ColumnHeader kitchenOrderItems;
        private ColumnHeader barComment;
        private ColumnHeader columnHeader1;
        private ColumnHeader barAmount;
        private ColumnHeader barOrderItems;
        private ColumnHeader barWaitTime;
        private ColumnHeader barOrderTime;
        private ColumnHeader barTableNumber;
        private ColumnHeader columnHeader2;
        private ColumnHeader barOrderId;
        private Label label1;
        private Label label2;
    }
}
