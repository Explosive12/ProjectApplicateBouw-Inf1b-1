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
            pbxHeaderViewOrderStatusKitchen = new PictureBox();
            lblStatusOfDish = new Label();
            lblSelectedOrder = new Label();
            lblKitchenHeader = new Label();
            btnFilterByStatusKitchen = new Button();
            cbxStatusKitchen = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblWaitingTimeHeader = new Label();
            lblDescriptionHeaderBar = new Label();
            lblCountHeaderBar = new Label();
            lblOrderNumberHeaderBar = new Label();
            lblOrderIDHeaderBar = new Label();
            pbxHeaderBar = new PictureBox();
            listViewKitchenOrders = new ListView();
            barOrderId = new ColumnHeader();
            barTableNumber = new ColumnHeader();
            barOrderTime = new ColumnHeader();
            barWaitTime = new ColumnHeader();
            barOrderItems = new ColumnHeader();
            barAmount = new ColumnHeader();
            barComment = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusKitchen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderBar).BeginInit();
            SuspendLayout();
            // 
            // btnServedKitchen
            // 
            btnServedKitchen.BackColor = Color.FromArgb(138, 210, 176);
            btnServedKitchen.ForeColor = Color.Black;
            btnServedKitchen.Location = new Point(2128, 367);
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
            btnPreparedKitchen.Location = new Point(1858, 367);
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
            btnPreparationKitchen.Location = new Point(1586, 367);
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
            lblViewOrderStatusHeaderBar.Location = new Point(1939, 498);
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
            // pbxHeaderViewOrderStatusKitchen
            // 
            pbxHeaderViewOrderStatusKitchen.BackColor = Color.Orange;
            pbxHeaderViewOrderStatusKitchen.Location = new Point(1586, 468);
            pbxHeaderViewOrderStatusKitchen.Margin = new Padding(2);
            pbxHeaderViewOrderStatusKitchen.Name = "pbxHeaderViewOrderStatusKitchen";
            pbxHeaderViewOrderStatusKitchen.Size = new Size(836, 111);
            pbxHeaderViewOrderStatusKitchen.TabIndex = 43;
            pbxHeaderViewOrderStatusKitchen.TabStop = false;
            // 
            // lblStatusOfDish
            // 
            lblStatusOfDish.AutoSize = true;
            lblStatusOfDish.Location = new Point(2170, 612);
            lblStatusOfDish.Margin = new Padding(2, 0, 2, 0);
            lblStatusOfDish.Name = "lblStatusOfDish";
            lblStatusOfDish.Size = new Size(102, 37);
            lblStatusOfDish.TabIndex = 50;
            lblStatusOfDish.Text = "{status}";
            // 
            // lblSelectedOrder
            // 
            lblSelectedOrder.AutoSize = true;
            lblSelectedOrder.Location = new Point(1780, 612);
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
            btnFilterByStatusKitchen.Location = new Point(2128, 826);
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
            cbxStatusKitchen.Location = new Point(1706, 826);
            cbxStatusKitchen.Name = "cbxStatusKitchen";
            cbxStatusKitchen.Size = new Size(272, 45);
            cbxStatusKitchen.TabIndex = 73;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Location = new Point(1586, 672);
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
            label1.Location = new Point(1939, 702);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 37);
            label1.TabIndex = 49;
            label1.Text = "View order status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Location = new Point(275, 263);
            label2.Name = "label2";
            label2.Size = new Size(183, 37);
            label2.TabIndex = 84;
            label2.Text = "Table Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Orange;
            label3.Location = new Point(478, 263);
            label3.Name = "label3";
            label3.Size = new Size(150, 37);
            label3.TabIndex = 83;
            label3.Text = "Order Time";
            // 
            // lblWaitingTimeHeader
            // 
            lblWaitingTimeHeader.AutoSize = true;
            lblWaitingTimeHeader.BackColor = Color.Orange;
            lblWaitingTimeHeader.Location = new Point(663, 263);
            lblWaitingTimeHeader.Margin = new Padding(2, 0, 2, 0);
            lblWaitingTimeHeader.Name = "lblWaitingTimeHeader";
            lblWaitingTimeHeader.Size = new Size(174, 37);
            lblWaitingTimeHeader.TabIndex = 82;
            lblWaitingTimeHeader.Text = "Waiting Time";
            // 
            // lblDescriptionHeaderBar
            // 
            lblDescriptionHeaderBar.AutoSize = true;
            lblDescriptionHeaderBar.BackColor = Color.Orange;
            lblDescriptionHeaderBar.Location = new Point(1279, 263);
            lblDescriptionHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblDescriptionHeaderBar.Name = "lblDescriptionHeaderBar";
            lblDescriptionHeaderBar.Size = new Size(134, 37);
            lblDescriptionHeaderBar.TabIndex = 79;
            lblDescriptionHeaderBar.Text = "Comment";
            // 
            // lblCountHeaderBar
            // 
            lblCountHeaderBar.AutoSize = true;
            lblCountHeaderBar.BackColor = Color.Orange;
            lblCountHeaderBar.Location = new Point(1075, 263);
            lblCountHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblCountHeaderBar.Name = "lblCountHeaderBar";
            lblCountHeaderBar.Size = new Size(112, 37);
            lblCountHeaderBar.TabIndex = 78;
            lblCountHeaderBar.Text = "Amount";
            // 
            // lblOrderNumberHeaderBar
            // 
            lblOrderNumberHeaderBar.AutoSize = true;
            lblOrderNumberHeaderBar.BackColor = Color.Orange;
            lblOrderNumberHeaderBar.Location = new Point(866, 263);
            lblOrderNumberHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblOrderNumberHeaderBar.Name = "lblOrderNumberHeaderBar";
            lblOrderNumberHeaderBar.Size = new Size(184, 37);
            lblOrderNumberHeaderBar.TabIndex = 77;
            lblOrderNumberHeaderBar.Text = "Order number";
            // 
            // lblOrderIDHeaderBar
            // 
            lblOrderIDHeaderBar.AutoSize = true;
            lblOrderIDHeaderBar.BackColor = Color.Orange;
            lblOrderIDHeaderBar.ImageAlign = ContentAlignment.BottomRight;
            lblOrderIDHeaderBar.Location = new Point(77, 263);
            lblOrderIDHeaderBar.Margin = new Padding(2, 0, 2, 0);
            lblOrderIDHeaderBar.Name = "lblOrderIDHeaderBar";
            lblOrderIDHeaderBar.Size = new Size(118, 37);
            lblOrderIDHeaderBar.TabIndex = 76;
            lblOrderIDHeaderBar.Text = "Order ID";
            // 
            // pbxHeaderBar
            // 
            pbxHeaderBar.BackColor = Color.Orange;
            pbxHeaderBar.Location = new Point(-1, 221);
            pbxHeaderBar.Margin = new Padding(2);
            pbxHeaderBar.Name = "pbxHeaderBar";
            pbxHeaderBar.Size = new Size(2420, 111);
            pbxHeaderBar.TabIndex = 80;
            pbxHeaderBar.TabStop = false;
            // 
            // listViewKitchenOrders
            // 
            listViewKitchenOrders.Columns.AddRange(new ColumnHeader[] { barOrderId, barTableNumber, barOrderTime, barWaitTime, barOrderItems, barAmount, barComment });
            listViewKitchenOrders.Location = new Point(77, 331);
            listViewKitchenOrders.Margin = new Padding(2);
            listViewKitchenOrders.Name = "listViewKitchenOrders";
            listViewKitchenOrders.Size = new Size(1386, 563);
            listViewKitchenOrders.TabIndex = 81;
            listViewKitchenOrders.UseCompatibleStateImageBehavior = false;
            listViewKitchenOrders.View = View.Details;
            listViewKitchenOrders.SelectedIndexChanged += listViewKitchenOrders_SelectedIndexChanged_1;
            // 
            // barOrderId
            // 
            barOrderId.Text = "Order Id";
            barOrderId.Width = 200;
            // 
            // barTableNumber
            // 
            barTableNumber.Text = "table number";
            barTableNumber.Width = 200;
            // 
            // barOrderTime
            // 
            barOrderTime.Text = "order time";
            barOrderTime.Width = 200;
            // 
            // barWaitTime
            // 
            barWaitTime.Text = "wait time";
            barWaitTime.Width = 200;
            // 
            // barOrderItems
            // 
            barOrderItems.Text = "order items";
            barOrderItems.Width = 200;
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
            // KitchenOrderControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblWaitingTimeHeader);
            Controls.Add(lblDescriptionHeaderBar);
            Controls.Add(lblCountHeaderBar);
            Controls.Add(lblOrderNumberHeaderBar);
            Controls.Add(lblOrderIDHeaderBar);
            Controls.Add(listViewKitchenOrders);
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
            Controls.Add(pictureBox1);
            Controls.Add(pbxHeaderViewOrderStatusKitchen);
            Controls.Add(pbxHeaderBar);
            Margin = new Padding(2);
            Name = "KitchenOrderControl";
            Size = new Size(2421, 1031);
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusKitchen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderBar).EndInit();
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
        private PictureBox pbxHeaderViewOrderStatusKitchen;
        private Label lblStatusOfDish;
        private Label lblSelectedOrder;
        private Label lblKitchenHeader;
        private Button btnFilterByStatusKitchen;
        private ComboBox cbxStatusKitchen;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblWaitingTimeHeader;
        private Label lblDescriptionHeaderBar;
        private Label lblCountHeaderBar;
        private Label lblOrderNumberHeaderBar;
        private Label lblOrderIDHeaderBar;
        private PictureBox pbxHeaderBar;
        private ListView listViewKitchenOrders;
        private ColumnHeader barOrderId;
        private ColumnHeader barTableNumber;
        private ColumnHeader barOrderTime;
        private ColumnHeader barWaitTime;
        private ColumnHeader barOrderItems;
        private ColumnHeader barAmount;
        private ColumnHeader barComment;
    }
}
