namespace Project1._4
{
    partial class KitchenOrderControl
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
            btnServedKitchen = new Button();
            btnPreparedKitchen = new Button();
            btnPreparationKitchen = new Button();
            lblViewOrderStatusHeaderBar = new Label();
            lblChangeStatusHeaderKitchen = new Label();
            lblDescriptionHeaderKitchen = new Label();
            lblCountHeaderKitchen = new Label();
            lblOrderNumberHeaderKitchen = new Label();
            lblOrderIDHeaderKitchen = new Label();
            pbxHeaderViewOrderStatusKitchen = new PictureBox();
            pbxHeaderKitchen = new PictureBox();
            lblStatusOfDish = new Label();
            listViewKitchenOrders = new ListView();
            kitchenOrderId = new ColumnHeader();
            kitchenOrderNumber = new ColumnHeader();
            kitchenOrderCount = new ColumnHeader();
            kitchenDescription = new ColumnHeader();
            lblSelectedOrder = new Label();
            lblKitchenHeader = new Label();
            btnFilterByStatusKitchen = new Button();
            cbxStatusKitchen = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            kitchenWaitingTime = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusKitchen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderKitchen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnServedKitchen
            // 
            btnServedKitchen.BackColor = Color.FromArgb(138, 210, 176);
            btnServedKitchen.ForeColor = Color.Black;
            btnServedKitchen.Location = new Point(1920, 367);
            btnServedKitchen.Margin = new Padding(2);
            btnServedKitchen.Name = "btnServedKitchen";
            btnServedKitchen.Size = new Size(253, 52);
            btnServedKitchen.TabIndex = 42;
            btnServedKitchen.Text = "Served";
            btnServedKitchen.UseVisualStyleBackColor = false;
            btnServedKitchen.Click += btnServedKitchen_Click;
            // 
            // btnPreparedKitchen
            // 
            btnPreparedKitchen.BackColor = Color.FromArgb(255, 179, 71);
            btnPreparedKitchen.Location = new Point(1650, 367);
            btnPreparedKitchen.Margin = new Padding(2);
            btnPreparedKitchen.Name = "btnPreparedKitchen";
            btnPreparedKitchen.Size = new Size(253, 52);
            btnPreparedKitchen.TabIndex = 41;
            btnPreparedKitchen.Text = "Prepared";
            btnPreparedKitchen.UseVisualStyleBackColor = false;
            btnPreparedKitchen.Click += btnPreparedKitchen_Click;
            // 
            // btnPreparationKitchen
            // 
            btnPreparationKitchen.Location = new Point(1378, 367);
            btnPreparationKitchen.Margin = new Padding(2);
            btnPreparationKitchen.Name = "btnPreparationKitchen";
            btnPreparationKitchen.Size = new Size(253, 52);
            btnPreparationKitchen.TabIndex = 39;
            btnPreparationKitchen.Text = "in preparation";
            btnPreparationKitchen.UseVisualStyleBackColor = true;
            btnPreparationKitchen.Click += btnPreparationKitchen_Click;
            // 
            // lblViewOrderStatusHeaderBar
            // 
            lblViewOrderStatusHeaderBar.AutoSize = true;
            lblViewOrderStatusHeaderBar.BackColor = Color.Orange;
            lblViewOrderStatusHeaderBar.Location = new Point(1731, 498);
            lblViewOrderStatusHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblViewOrderStatusHeaderBar.Name = "lblViewOrderStatusHeaderBar";
            lblViewOrderStatusHeaderBar.Size = new Size(222, 37);
            lblViewOrderStatusHeaderBar.TabIndex = 49;
            lblViewOrderStatusHeaderBar.Text = "View order status";
            // 
            // lblChangeStatusHeaderKitchen
            // 
            lblChangeStatusHeaderKitchen.AutoSize = true;
            lblChangeStatusHeaderKitchen.BackColor = Color.Orange;
            lblChangeStatusHeaderKitchen.Location = new Point(1648, 266);
            lblChangeStatusHeaderKitchen.Margin = new Padding(2, 0, 2, 0);
            lblChangeStatusHeaderKitchen.Name = "lblChangeStatusHeaderKitchen";
            lblChangeStatusHeaderKitchen.Size = new Size(255, 37);
            lblChangeStatusHeaderKitchen.TabIndex = 38;
            lblChangeStatusHeaderKitchen.Text = "Change order status";
            // 
            // lblDescriptionHeaderKitchen
            // 
            lblDescriptionHeaderKitchen.AutoSize = true;
            lblDescriptionHeaderKitchen.BackColor = Color.Orange;
            lblDescriptionHeaderKitchen.Location = new Point(781, 266);
            lblDescriptionHeaderKitchen.Margin = new Padding(2, 0, 2, 0);
            lblDescriptionHeaderKitchen.Name = "lblDescriptionHeaderKitchen";
            lblDescriptionHeaderKitchen.Size = new Size(152, 37);
            lblDescriptionHeaderKitchen.TabIndex = 37;
            lblDescriptionHeaderKitchen.Text = "Description";
            // 
            // lblCountHeaderKitchen
            // 
            lblCountHeaderKitchen.AutoSize = true;
            lblCountHeaderKitchen.BackColor = Color.Orange;
            lblCountHeaderKitchen.Location = new Point(551, 266);
            lblCountHeaderKitchen.Margin = new Padding(2, 0, 2, 0);
            lblCountHeaderKitchen.Name = "lblCountHeaderKitchen";
            lblCountHeaderKitchen.Size = new Size(89, 37);
            lblCountHeaderKitchen.TabIndex = 36;
            lblCountHeaderKitchen.Text = "Count";
            // 
            // lblOrderNumberHeaderKitchen
            // 
            lblOrderNumberHeaderKitchen.AutoSize = true;
            lblOrderNumberHeaderKitchen.BackColor = Color.Orange;
            lblOrderNumberHeaderKitchen.Location = new Point(274, 266);
            lblOrderNumberHeaderKitchen.Margin = new Padding(2, 0, 2, 0);
            lblOrderNumberHeaderKitchen.Name = "lblOrderNumberHeaderKitchen";
            lblOrderNumberHeaderKitchen.Size = new Size(184, 37);
            lblOrderNumberHeaderKitchen.TabIndex = 35;
            lblOrderNumberHeaderKitchen.Text = "Order number";
            // 
            // lblOrderIDHeaderKitchen
            // 
            lblOrderIDHeaderKitchen.AutoSize = true;
            lblOrderIDHeaderKitchen.BackColor = Color.Orange;
            lblOrderIDHeaderKitchen.ImageAlign = ContentAlignment.BottomRight;
            lblOrderIDHeaderKitchen.Location = new Point(80, 266);
            lblOrderIDHeaderKitchen.Margin = new Padding(2, 0, 2, 0);
            lblOrderIDHeaderKitchen.Name = "lblOrderIDHeaderKitchen";
            lblOrderIDHeaderKitchen.Size = new Size(118, 37);
            lblOrderIDHeaderKitchen.TabIndex = 34;
            lblOrderIDHeaderKitchen.Text = "Order ID";
            // 
            // pbxHeaderViewOrderStatusKitchen
            // 
            pbxHeaderViewOrderStatusKitchen.BackColor = Color.Orange;
            pbxHeaderViewOrderStatusKitchen.Location = new Point(1378, 468);
            pbxHeaderViewOrderStatusKitchen.Margin = new Padding(2);
            pbxHeaderViewOrderStatusKitchen.Name = "pbxHeaderViewOrderStatusKitchen";
            pbxHeaderViewOrderStatusKitchen.Size = new Size(836, 111);
            pbxHeaderViewOrderStatusKitchen.TabIndex = 43;
            pbxHeaderViewOrderStatusKitchen.TabStop = false;
            // 
            // pbxHeaderKitchen
            // 
            pbxHeaderKitchen.BackColor = Color.Orange;
            pbxHeaderKitchen.Location = new Point(2, 224);
            pbxHeaderKitchen.Margin = new Padding(2);
            pbxHeaderKitchen.Name = "pbxHeaderKitchen";
            pbxHeaderKitchen.Size = new Size(2213, 111);
            pbxHeaderKitchen.TabIndex = 40;
            pbxHeaderKitchen.TabStop = false;
            // 
            // lblStatusOfDish
            // 
            lblStatusOfDish.AutoSize = true;
            lblStatusOfDish.Location = new Point(1962, 612);
            lblStatusOfDish.Margin = new Padding(2, 0, 2, 0);
            lblStatusOfDish.Name = "lblStatusOfDish";
            lblStatusOfDish.Size = new Size(102, 37);
            lblStatusOfDish.TabIndex = 50;
            lblStatusOfDish.Text = "{status}";
            // 
            // listViewKitchenOrders
            // 
            listViewKitchenOrders.Columns.AddRange(new ColumnHeader[] { kitchenOrderId, kitchenOrderNumber, kitchenOrderCount, kitchenDescription, kitchenWaitingTime });
            listViewKitchenOrders.Location = new Point(80, 337);
            listViewKitchenOrders.Margin = new Padding(2);
            listViewKitchenOrders.Name = "listViewKitchenOrders";
            listViewKitchenOrders.Size = new Size(1180, 563);
            listViewKitchenOrders.TabIndex = 51;
            listViewKitchenOrders.UseCompatibleStateImageBehavior = false;
            listViewKitchenOrders.View = View.Details;
            listViewKitchenOrders.SelectedIndexChanged += listViewKitchenOrders_SelectedIndexChanged;
            // 
            // kitchenOrderId
            // 
            kitchenOrderId.Text = "Order Id";
            kitchenOrderId.Width = 185;
            // 
            // kitchenOrderNumber
            // 
            kitchenOrderNumber.Text = "kitchen order number";
            kitchenOrderNumber.Width = 280;
            // 
            // kitchenOrderCount
            // 
            kitchenOrderCount.Text = "Count";
            kitchenOrderCount.Width = 230;
            // 
            // kitchenDescription
            // 
            kitchenDescription.Text = "kitchen description";
            kitchenDescription.Width = 300;
            // 
            // lblSelectedOrder
            // 
            lblSelectedOrder.AutoSize = true;
            lblSelectedOrder.Location = new Point(1572, 612);
            lblSelectedOrder.Margin = new Padding(2, 0, 2, 0);
            lblSelectedOrder.Name = "lblSelectedOrder";
            lblSelectedOrder.Size = new Size(198, 37);
            lblSelectedOrder.TabIndex = 52;
            lblSelectedOrder.Text = "{selectedOrder}";
            // 
            // lblKitchenHeader
            // 
            lblKitchenHeader.AutoSize = true;
            lblKitchenHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblKitchenHeader.Location = new Point(684, 56);
            lblKitchenHeader.Name = "lblKitchenHeader";
            lblKitchenHeader.Size = new Size(553, 104);
            lblKitchenHeader.TabIndex = 53;
            lblKitchenHeader.Text = "Kitchen Orders";
            // 
            // btnFilterByStatusKitchen
            // 
            btnFilterByStatusKitchen.Location = new Point(1920, 826);
            btnFilterByStatusKitchen.Name = "btnFilterByStatusKitchen";
            btnFilterByStatusKitchen.Size = new Size(169, 52);
            btnFilterByStatusKitchen.TabIndex = 74;
            btnFilterByStatusKitchen.Text = "filter";
            btnFilterByStatusKitchen.UseVisualStyleBackColor = true;
            btnFilterByStatusKitchen.Click += btnFilterByStatusKitchen_Click;
            // 
            // cbxStatusKitchen
            // 
            cbxStatusKitchen.FormattingEnabled = true;
            cbxStatusKitchen.Location = new Point(1498, 826);
            cbxStatusKitchen.Name = "cbxStatusKitchen";
            cbxStatusKitchen.Size = new Size(272, 45);
            cbxStatusKitchen.TabIndex = 73;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Location = new Point(1378, 672);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(836, 111);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Location = new Point(1731, 702);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 37);
            label1.TabIndex = 49;
            label1.Text = "View order status";
            // 
            // kitchenWaitingTime
            // 
            kitchenWaitingTime.Text = "Waiting Time";
            kitchenWaitingTime.Width = 200;
            // 
            // KitchenOrderControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnFilterByStatusKitchen);
            Controls.Add(cbxStatusKitchen);
            Controls.Add(lblKitchenHeader);
            Controls.Add(lblSelectedOrder);
            Controls.Add(lblStatusOfDish);
            Controls.Add(btnServedKitchen);
            Controls.Add(btnPreparedKitchen);
            Controls.Add(btnPreparationKitchen);
            Controls.Add(label1);
            Controls.Add(lblViewOrderStatusHeaderBar);
            Controls.Add(lblChangeStatusHeaderKitchen);
            Controls.Add(lblDescriptionHeaderKitchen);
            Controls.Add(lblCountHeaderKitchen);
            Controls.Add(lblOrderNumberHeaderKitchen);
            Controls.Add(pictureBox1);
            Controls.Add(lblOrderIDHeaderKitchen);
            Controls.Add(pbxHeaderViewOrderStatusKitchen);
            Controls.Add(pbxHeaderKitchen);
            Controls.Add(listViewKitchenOrders);
            Margin = new Padding(2);
            Name = "KitchenOrderControl";
            Size = new Size(2213, 1029);
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusKitchen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderKitchen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxOrderStatusKitchen;
        private Button btnServedKitchen;
        private Button btnPreparedKitchen;
        private Button btnPreparationKitchen;
        private Label lblViewOrderStatusHeaderBar;
        private Label lblChangeStatusHeaderKitchen;
        private Label lblDescriptionHeaderKitchen;
        private Label lblCountHeaderKitchen;
        private Label lblOrderNumberHeaderKitchen;
        private Label lblOrderIDHeaderKitchen;
        private PictureBox pbxHeaderViewOrderStatusKitchen;
        private PictureBox pbxHeaderKitchen;
        private Label lblStatusOfDish;
        private ListView listViewKitchenOrders;
        private Label lblSelectedOrder;
        private ColumnHeader kitchenOrderId;
        private ColumnHeader kitchenOrderNumber;
        private ColumnHeader kitchenOrderCount;
        private ColumnHeader kitchenDescription;
        private Label lblKitchenHeader;
        private Button btnFilterByStatusKitchen;
        private ComboBox cbxStatusKitchen;
        private PictureBox pictureBox1;
        private Label label1;
        private ColumnHeader kitchenWaitingTime;
    }
}
