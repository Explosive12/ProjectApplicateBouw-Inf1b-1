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
            kitchenDescription = new ColumnHeader();
            kitchenOrderCount = new ColumnHeader();
            kitchenOrderNumber = new ColumnHeader();
            kitchenOrderId = new ColumnHeader();
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
            cbxStatusBar = new ComboBox();
            pbxOrderByStatusBar = new PictureBox();
            pbxHeaderViewOrderStatusBar = new PictureBox();
            lblViewOrderByStatusHeaderBar = new Label();
            btnFilterByStatusBar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxOrderByStatusBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusBar).BeginInit();
            SuspendLayout();
            // 
            // lblBarHeader
            // 
            lblBarHeader.AutoSize = true;
            lblBarHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarHeader.Location = new Point(682, 70);
            lblBarHeader.Name = "lblBarHeader";
            lblBarHeader.Size = new Size(410, 104);
            lblBarHeader.TabIndex = 68;
            lblBarHeader.Text = "Bar Orders";
            // 
            // kitchenDescription
            // 
            kitchenDescription.Text = "kitchen description";
            kitchenDescription.Width = 300;
            // 
            // kitchenOrderCount
            // 
            kitchenOrderCount.Text = "Count";
            kitchenOrderCount.Width = 230;
            // 
            // kitchenOrderNumber
            // 
            kitchenOrderNumber.Text = "kitchen order number";
            kitchenOrderNumber.Width = 280;
            // 
            // kitchenOrderId
            // 
            kitchenOrderId.Text = "Order Id";
            kitchenOrderId.Width = 185;
            // 
            // lblSelectedOrder
            // 
            lblSelectedOrder.AutoSize = true;
            lblSelectedOrder.Location = new Point(1316, 638);
            lblSelectedOrder.Margin = new Padding(2, 0, 2, 0);
            lblSelectedOrder.Name = "lblSelectedOrder";
            lblSelectedOrder.Size = new Size(198, 37);
            lblSelectedOrder.TabIndex = 67;
            lblSelectedOrder.Text = "{selectedOrder}";
            // 
            // lblStatusOfDish
            // 
            lblStatusOfDish.AutoSize = true;
            lblStatusOfDish.Location = new Point(1703, 638);
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
            btnServedBar.Location = new Point(1703, 389);
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
            btnPreparedBar.Location = new Point(1433, 389);
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
            btnPreparationBar.Location = new Point(1161, 389);
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
            lblViewOrderStatusHeaderBar.Location = new Point(1514, 520);
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
            lblChangeStatusHeaderBar.Location = new Point(1420, 280);
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
            lblDescriptionHeaderBar.Location = new Point(779, 280);
            lblDescriptionHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblDescriptionHeaderBar.Name = "lblDescriptionHeaderBar";
            lblDescriptionHeaderBar.Size = new Size(152, 37);
            lblDescriptionHeaderBar.TabIndex = 57;
            lblDescriptionHeaderBar.Text = "Description";
            // 
            // lblCountHeaderBar
            // 
            lblCountHeaderBar.AutoSize = true;
            lblCountHeaderBar.BackColor = Color.Orange;
            lblCountHeaderBar.Location = new Point(549, 280);
            lblCountHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblCountHeaderBar.Name = "lblCountHeaderBar";
            lblCountHeaderBar.Size = new Size(89, 37);
            lblCountHeaderBar.TabIndex = 56;
            lblCountHeaderBar.Text = "Count";
            // 
            // lblOrderNumberHeaderBar
            // 
            lblOrderNumberHeaderBar.AutoSize = true;
            lblOrderNumberHeaderBar.BackColor = Color.Orange;
            lblOrderNumberHeaderBar.Location = new Point(272, 280);
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
            pbxHeaderBar.Size = new Size(1999, 111);
            pbxHeaderBar.TabIndex = 60;
            pbxHeaderBar.TabStop = false;
            // 
            // listViewBarOrders
            // 
            listViewBarOrders.Columns.AddRange(new ColumnHeader[] { kitchenOrderId, kitchenOrderNumber, kitchenOrderCount, kitchenDescription });
            listViewBarOrders.Location = new Point(78, 304);
            listViewBarOrders.Margin = new Padding(2);
            listViewBarOrders.Name = "listViewBarOrders";
            listViewBarOrders.Size = new Size(1030, 563);
            listViewBarOrders.TabIndex = 66;
            listViewBarOrders.UseCompatibleStateImageBehavior = false;
            listViewBarOrders.View = View.Details;
            listViewBarOrders.SelectedIndexChanged += listViewBarOrders_SelectedIndexChanged;
            // 
            // cbxStatusBar
            // 
            cbxStatusBar.FormattingEnabled = true;
            cbxStatusBar.Location = new Point(1265, 871);
            cbxStatusBar.Name = "cbxStatusBar";
            cbxStatusBar.Size = new Size(272, 45);
            cbxStatusBar.TabIndex = 69;
            // 
            // pbxOrderByStatusBar
            // 
            pbxOrderByStatusBar.BackColor = Color.Orange;
            pbxOrderByStatusBar.Location = new Point(1166, 708);
            pbxOrderByStatusBar.Margin = new Padding(2);
            pbxOrderByStatusBar.Name = "pbxOrderByStatusBar";
            pbxOrderByStatusBar.Size = new Size(836, 111);
            pbxOrderByStatusBar.TabIndex = 70;
            pbxOrderByStatusBar.TabStop = false;
            // 
            // pbxHeaderViewOrderStatusBar
            // 
            pbxHeaderViewOrderStatusBar.BackColor = Color.Orange;
            pbxHeaderViewOrderStatusBar.Location = new Point(1166, 489);
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
            lblViewOrderByStatusHeaderBar.Location = new Point(1453, 745);
            lblViewOrderByStatusHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblViewOrderByStatusHeaderBar.Name = "lblViewOrderByStatusHeaderBar";
            lblViewOrderByStatusHeaderBar.Size = new Size(263, 37);
            lblViewOrderByStatusHeaderBar.TabIndex = 71;
            lblViewOrderByStatusHeaderBar.Text = "View Order By Status";
            // 
            // btnFilterByStatusBar
            // 
            btnFilterByStatusBar.Location = new Point(1649, 864);
            btnFilterByStatusBar.Name = "btnFilterByStatusBar";
            btnFilterByStatusBar.Size = new Size(169, 52);
            btnFilterByStatusBar.TabIndex = 72;
            btnFilterByStatusBar.Text = "filter";
            btnFilterByStatusBar.UseVisualStyleBackColor = true;
            btnFilterByStatusBar.Click += btnFilterByStatusBar_Click;
            // 
            // BarOrderControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(2002, 1029);
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
    }
}
