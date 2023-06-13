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
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusKitchen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderKitchen).BeginInit();
            SuspendLayout();
            // 
            // btnServedKitchen
            // 
            btnServedKitchen.BackColor = Color.FromArgb(138, 210, 176);
            btnServedKitchen.ForeColor = Color.Black;
            btnServedKitchen.Location = new Point(796, 60);
            btnServedKitchen.Margin = new Padding(1, 1, 1, 1);
            btnServedKitchen.Name = "btnServedKitchen";
            btnServedKitchen.Size = new Size(118, 21);
            btnServedKitchen.TabIndex = 42;
            btnServedKitchen.Text = "Served";
            btnServedKitchen.UseVisualStyleBackColor = false;
            btnServedKitchen.Click += btnServedKitchen_Click;
            // 
            // btnPreparedKitchen
            // 
            btnPreparedKitchen.BackColor = Color.FromArgb(255, 179, 71);
            btnPreparedKitchen.Location = new Point(670, 60);
            btnPreparedKitchen.Margin = new Padding(1, 1, 1, 1);
            btnPreparedKitchen.Name = "btnPreparedKitchen";
            btnPreparedKitchen.Size = new Size(118, 21);
            btnPreparedKitchen.TabIndex = 41;
            btnPreparedKitchen.Text = "Prepared";
            btnPreparedKitchen.UseVisualStyleBackColor = false;
            btnPreparedKitchen.Click += btnPreparedKitchen_Click;
            // 
            // btnPreparationKitchen
            // 
            btnPreparationKitchen.Location = new Point(543, 60);
            btnPreparationKitchen.Margin = new Padding(1, 1, 1, 1);
            btnPreparationKitchen.Name = "btnPreparationKitchen";
            btnPreparationKitchen.Size = new Size(118, 21);
            btnPreparationKitchen.TabIndex = 39;
            btnPreparationKitchen.Text = "in preparation";
            btnPreparationKitchen.UseVisualStyleBackColor = true;
            btnPreparationKitchen.Click += btnPreparationKitchen_Click;
            // 
            // lblViewOrderStatusHeaderBar
            // 
            lblViewOrderStatusHeaderBar.AutoSize = true;
            lblViewOrderStatusHeaderBar.Location = new Point(708, 113);
            lblViewOrderStatusHeaderBar.Margin = new Padding(1, 0, 1, 0);
            lblViewOrderStatusHeaderBar.Name = "lblViewOrderStatusHeaderBar";
            lblViewOrderStatusHeaderBar.Size = new Size(97, 15);
            lblViewOrderStatusHeaderBar.TabIndex = 49;
            lblViewOrderStatusHeaderBar.Text = "View order status";
            // 
            // lblChangeStatusHeaderKitchen
            // 
            lblChangeStatusHeaderKitchen.AutoSize = true;
            lblChangeStatusHeaderKitchen.BackColor = Color.Transparent;
            lblChangeStatusHeaderKitchen.Location = new Point(664, 16);
            lblChangeStatusHeaderKitchen.Margin = new Padding(1, 0, 1, 0);
            lblChangeStatusHeaderKitchen.Name = "lblChangeStatusHeaderKitchen";
            lblChangeStatusHeaderKitchen.Size = new Size(113, 15);
            lblChangeStatusHeaderKitchen.TabIndex = 38;
            lblChangeStatusHeaderKitchen.Text = "Change order status";
            // 
            // lblDescriptionHeaderKitchen
            // 
            lblDescriptionHeaderKitchen.AutoSize = true;
            lblDescriptionHeaderKitchen.Location = new Point(393, 16);
            lblDescriptionHeaderKitchen.Margin = new Padding(1, 0, 1, 0);
            lblDescriptionHeaderKitchen.Name = "lblDescriptionHeaderKitchen";
            lblDescriptionHeaderKitchen.Size = new Size(67, 15);
            lblDescriptionHeaderKitchen.TabIndex = 37;
            lblDescriptionHeaderKitchen.Text = "Description";
            // 
            // lblCountHeaderKitchen
            // 
            lblCountHeaderKitchen.AutoSize = true;
            lblCountHeaderKitchen.Location = new Point(298, 16);
            lblCountHeaderKitchen.Margin = new Padding(1, 0, 1, 0);
            lblCountHeaderKitchen.Name = "lblCountHeaderKitchen";
            lblCountHeaderKitchen.Size = new Size(40, 15);
            lblCountHeaderKitchen.TabIndex = 36;
            lblCountHeaderKitchen.Text = "Count";
            // 
            // lblOrderNumberHeaderKitchen
            // 
            lblOrderNumberHeaderKitchen.AutoSize = true;
            lblOrderNumberHeaderKitchen.Location = new Point(155, 16);
            lblOrderNumberHeaderKitchen.Margin = new Padding(1, 0, 1, 0);
            lblOrderNumberHeaderKitchen.Name = "lblOrderNumberHeaderKitchen";
            lblOrderNumberHeaderKitchen.Size = new Size(82, 15);
            lblOrderNumberHeaderKitchen.TabIndex = 35;
            lblOrderNumberHeaderKitchen.Text = "Order number";
            // 
            // lblOrderIDHeaderKitchen
            // 
            lblOrderIDHeaderKitchen.AutoSize = true;
            lblOrderIDHeaderKitchen.BackColor = Color.Transparent;
            lblOrderIDHeaderKitchen.ImageAlign = ContentAlignment.BottomRight;
            lblOrderIDHeaderKitchen.Location = new Point(38, 16);
            lblOrderIDHeaderKitchen.Margin = new Padding(1, 0, 1, 0);
            lblOrderIDHeaderKitchen.Name = "lblOrderIDHeaderKitchen";
            lblOrderIDHeaderKitchen.Size = new Size(51, 15);
            lblOrderIDHeaderKitchen.TabIndex = 34;
            lblOrderIDHeaderKitchen.Text = "Order ID";
            // 
            // pbxHeaderViewOrderStatusKitchen
            // 
            pbxHeaderViewOrderStatusKitchen.BackColor = Color.Orange;
            pbxHeaderViewOrderStatusKitchen.Location = new Point(543, 101);
            pbxHeaderViewOrderStatusKitchen.Margin = new Padding(1, 1, 1, 1);
            pbxHeaderViewOrderStatusKitchen.Name = "pbxHeaderViewOrderStatusKitchen";
            pbxHeaderViewOrderStatusKitchen.Size = new Size(390, 45);
            pbxHeaderViewOrderStatusKitchen.TabIndex = 43;
            pbxHeaderViewOrderStatusKitchen.TabStop = false;
            // 
            // pbxHeaderKitchen
            // 
            pbxHeaderKitchen.BackColor = Color.Orange;
            pbxHeaderKitchen.Location = new Point(0, 0);
            pbxHeaderKitchen.Margin = new Padding(1, 1, 1, 1);
            pbxHeaderKitchen.Name = "pbxHeaderKitchen";
            pbxHeaderKitchen.Size = new Size(933, 45);
            pbxHeaderKitchen.TabIndex = 40;
            pbxHeaderKitchen.TabStop = false;
            // 
            // lblStatusOfDish
            // 
            lblStatusOfDish.AutoSize = true;
            lblStatusOfDish.Location = new Point(796, 178);
            lblStatusOfDish.Margin = new Padding(1, 0, 1, 0);
            lblStatusOfDish.Name = "lblStatusOfDish";
            lblStatusOfDish.Size = new Size(46, 15);
            lblStatusOfDish.TabIndex = 50;
            lblStatusOfDish.Text = "{status}";
            // 
            // listViewKitchenOrders
            // 
            listViewKitchenOrders.Columns.AddRange(new ColumnHeader[] { kitchenOrderId, kitchenOrderNumber, kitchenOrderCount, kitchenDescription });
            listViewKitchenOrders.Location = new Point(38, 60);
            listViewKitchenOrders.Margin = new Padding(1, 1, 1, 1);
            listViewKitchenOrders.Name = "listViewKitchenOrders";
            listViewKitchenOrders.Size = new Size(483, 187);
            listViewKitchenOrders.TabIndex = 51;
            listViewKitchenOrders.UseCompatibleStateImageBehavior = false;
            listViewKitchenOrders.View = View.Details;
            listViewKitchenOrders.SelectedIndexChanged += listViewKitchenOrders_SelectedIndexChanged;
            // 
            // kitchenOrderId
            // 
            kitchenOrderId.Text = "Order Id";
            kitchenOrderId.Width = 200;
            // 
            // kitchenOrderNumber
            // 
            kitchenOrderNumber.Text = "kitchen order number";
            kitchenOrderNumber.Width = 300;
            // 
            // kitchenOrderCount
            // 
            kitchenOrderCount.Text = "Count";
            kitchenOrderCount.Width = 200;
            // 
            // kitchenDescription
            // 
            kitchenDescription.Text = "kitchen description";
            kitchenDescription.Width = 200;
            // 
            // lblSelectedOrder
            // 
            lblSelectedOrder.AutoSize = true;
            lblSelectedOrder.Location = new Point(614, 178);
            lblSelectedOrder.Margin = new Padding(1, 0, 1, 0);
            lblSelectedOrder.Name = "lblSelectedOrder";
            lblSelectedOrder.Size = new Size(88, 15);
            lblSelectedOrder.TabIndex = 52;
            lblSelectedOrder.Text = "{selectedOrder}";
            // 
            // KitchenOrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblSelectedOrder);
            Controls.Add(listViewKitchenOrders);
            Controls.Add(lblStatusOfDish);
            Controls.Add(btnServedKitchen);
            Controls.Add(btnPreparedKitchen);
            Controls.Add(btnPreparationKitchen);
            Controls.Add(lblViewOrderStatusHeaderBar);
            Controls.Add(lblChangeStatusHeaderKitchen);
            Controls.Add(lblDescriptionHeaderKitchen);
            Controls.Add(lblCountHeaderKitchen);
            Controls.Add(lblOrderNumberHeaderKitchen);
            Controls.Add(lblOrderIDHeaderKitchen);
            Controls.Add(pbxHeaderViewOrderStatusKitchen);
            Controls.Add(pbxHeaderKitchen);
            Margin = new Padding(1, 1, 1, 1);
            Name = "KitchenOrderControl";
            Size = new Size(933, 257);
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusKitchen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderKitchen).EndInit();
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
    }
}
