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
            btnServedKitchen.Location = new Point(1705, 147);
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
            btnPreparedKitchen.Location = new Point(1435, 147);
            btnPreparedKitchen.Name = "btnPreparedKitchen";
            btnPreparedKitchen.Size = new Size(253, 52);
            btnPreparedKitchen.TabIndex = 41;
            btnPreparedKitchen.Text = "Prepared";
            btnPreparedKitchen.UseVisualStyleBackColor = false;
            btnPreparedKitchen.Click += btnPreparedKitchen_Click;
            // 
            // btnPreparationKitchen
            // 
            btnPreparationKitchen.Location = new Point(1164, 147);
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
            lblViewOrderStatusHeaderBar.Location = new Point(1518, 279);
            lblViewOrderStatusHeaderBar.Name = "lblViewOrderStatusHeaderBar";
            lblViewOrderStatusHeaderBar.Size = new Size(222, 37);
            lblViewOrderStatusHeaderBar.TabIndex = 49;
            lblViewOrderStatusHeaderBar.Text = "View order status";
            // 
            // lblChangeStatusHeaderKitchen
            // 
            lblChangeStatusHeaderKitchen.AutoSize = true;
            lblChangeStatusHeaderKitchen.BackColor = Color.Transparent;
            lblChangeStatusHeaderKitchen.Location = new Point(1423, 40);
            lblChangeStatusHeaderKitchen.Name = "lblChangeStatusHeaderKitchen";
            lblChangeStatusHeaderKitchen.Size = new Size(255, 37);
            lblChangeStatusHeaderKitchen.TabIndex = 38;
            lblChangeStatusHeaderKitchen.Text = "Change order status";
            // 
            // lblDescriptionHeaderKitchen
            // 
            lblDescriptionHeaderKitchen.AutoSize = true;
            lblDescriptionHeaderKitchen.Location = new Point(842, 40);
            lblDescriptionHeaderKitchen.Name = "lblDescriptionHeaderKitchen";
            lblDescriptionHeaderKitchen.Size = new Size(152, 37);
            lblDescriptionHeaderKitchen.TabIndex = 37;
            lblDescriptionHeaderKitchen.Text = "Description";
            // 
            // lblCountHeaderKitchen
            // 
            lblCountHeaderKitchen.AutoSize = true;
            lblCountHeaderKitchen.Location = new Point(639, 40);
            lblCountHeaderKitchen.Name = "lblCountHeaderKitchen";
            lblCountHeaderKitchen.Size = new Size(89, 37);
            lblCountHeaderKitchen.TabIndex = 36;
            lblCountHeaderKitchen.Text = "Count";
            // 
            // lblOrderNumberHeaderKitchen
            // 
            lblOrderNumberHeaderKitchen.AutoSize = true;
            lblOrderNumberHeaderKitchen.Location = new Point(333, 40);
            lblOrderNumberHeaderKitchen.Name = "lblOrderNumberHeaderKitchen";
            lblOrderNumberHeaderKitchen.Size = new Size(184, 37);
            lblOrderNumberHeaderKitchen.TabIndex = 35;
            lblOrderNumberHeaderKitchen.Text = "Order number";
            // 
            // lblOrderIDHeaderKitchen
            // 
            lblOrderIDHeaderKitchen.AutoSize = true;
            lblOrderIDHeaderKitchen.BackColor = Color.Transparent;
            lblOrderIDHeaderKitchen.ImageAlign = ContentAlignment.BottomRight;
            lblOrderIDHeaderKitchen.Location = new Point(82, 40);
            lblOrderIDHeaderKitchen.Name = "lblOrderIDHeaderKitchen";
            lblOrderIDHeaderKitchen.Size = new Size(118, 37);
            lblOrderIDHeaderKitchen.TabIndex = 34;
            lblOrderIDHeaderKitchen.Text = "Order ID";
            // 
            // pbxHeaderViewOrderStatusKitchen
            // 
            pbxHeaderViewOrderStatusKitchen.BackColor = Color.Orange;
            pbxHeaderViewOrderStatusKitchen.Location = new Point(1164, 250);
            pbxHeaderViewOrderStatusKitchen.Name = "pbxHeaderViewOrderStatusKitchen";
            pbxHeaderViewOrderStatusKitchen.Size = new Size(835, 112);
            pbxHeaderViewOrderStatusKitchen.TabIndex = 43;
            pbxHeaderViewOrderStatusKitchen.TabStop = false;
            // 
            // pbxHeaderKitchen
            // 
            pbxHeaderKitchen.BackColor = Color.Orange;
            pbxHeaderKitchen.Location = new Point(0, 0);
            pbxHeaderKitchen.Name = "pbxHeaderKitchen";
            pbxHeaderKitchen.Size = new Size(1999, 112);
            pbxHeaderKitchen.TabIndex = 40;
            pbxHeaderKitchen.TabStop = false;
            // 
            // lblStatusOfDish
            // 
            lblStatusOfDish.AutoSize = true;
            lblStatusOfDish.Location = new Point(1705, 438);
            lblStatusOfDish.Name = "lblStatusOfDish";
            lblStatusOfDish.Size = new Size(102, 37);
            lblStatusOfDish.TabIndex = 50;
            lblStatusOfDish.Text = "{status}";
            // 
            // listViewKitchenOrders
            // 
            listViewKitchenOrders.Columns.AddRange(new ColumnHeader[] { kitchenOrderId, kitchenOrderNumber, kitchenOrderCount, kitchenDescription });
            listViewKitchenOrders.Location = new Point(82, 130);
            listViewKitchenOrders.Name = "listViewKitchenOrders";
            listViewKitchenOrders.Size = new Size(1062, 455);
            listViewKitchenOrders.TabIndex = 51;
            listViewKitchenOrders.UseCompatibleStateImageBehavior = false;
            listViewKitchenOrders.View = View.Details;
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
            lblSelectedOrder.Location = new Point(1315, 438);
            lblSelectedOrder.Name = "lblSelectedOrder";
            lblSelectedOrder.Size = new Size(198, 37);
            lblSelectedOrder.TabIndex = 52;
            lblSelectedOrder.Text = "{selectedOrder}";
            // 
            // KitchenOrderControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
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
            Name = "KitchenOrderControl";
            Size = new Size(1999, 635);
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
