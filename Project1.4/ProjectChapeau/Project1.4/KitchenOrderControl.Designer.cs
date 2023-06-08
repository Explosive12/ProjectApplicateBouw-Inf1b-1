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
            cbxSelectOrderKitchen = new ComboBox();
            btnServedKitchen = new Button();
            btnPreparedKitchen = new Button();
            btnPreparationKitchen = new Button();
            lblViewOrderStatusHeaderBar = new Label();
            lblDescriptionKitchen = new Label();
            lblCountKitchen = new Label();
            lblOrderIdKitchen = new Label();
            lblChangeStatusHeaderKitchen = new Label();
            lblDescriptionHeaderKitchen = new Label();
            lblCountHeaderKitchen = new Label();
            lblOrderNumberHeaderKitchen = new Label();
            lblOrderIDHeaderKitchen = new Label();
            lblBestelregelIdKitchen = new Label();
            pbxHeaderViewOrderStatusKitchen = new PictureBox();
            pbxHeaderKitchen = new PictureBox();
            lblStatusOfDish = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusKitchen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderKitchen).BeginInit();
            SuspendLayout();
            // 
            // cbxSelectOrderKitchen
            // 
            cbxSelectOrderKitchen.AllowDrop = true;
            cbxSelectOrderKitchen.FormattingEnabled = true;
            cbxSelectOrderKitchen.Location = new Point(1226, 435);
            cbxSelectOrderKitchen.Name = "cbxSelectOrderKitchen";
            cbxSelectOrderKitchen.Size = new Size(272, 45);
            cbxSelectOrderKitchen.TabIndex = 47;
            cbxSelectOrderKitchen.Text = "Selected order ID";
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
            // lblDescriptionKitchen
            // 
            lblDescriptionKitchen.AutoSize = true;
            lblDescriptionKitchen.Location = new Point(842, 155);
            lblDescriptionKitchen.Name = "lblDescriptionKitchen";
            lblDescriptionKitchen.Size = new Size(165, 37);
            lblDescriptionKitchen.TabIndex = 46;
            lblDescriptionKitchen.Text = "{description}";
            // 
            // lblCountKitchen
            // 
            lblCountKitchen.AutoSize = true;
            lblCountKitchen.Location = new Point(628, 162);
            lblCountKitchen.Name = "lblCountKitchen";
            lblCountKitchen.Size = new Size(100, 37);
            lblCountKitchen.TabIndex = 45;
            lblCountKitchen.Text = "{count}";
            // 
            // lblOrderIdKitchen
            // 
            lblOrderIdKitchen.AutoSize = true;
            lblOrderIdKitchen.Location = new Point(362, 155);
            lblOrderIdKitchen.Name = "lblOrderIdKitchen";
            lblOrderIdKitchen.Size = new Size(120, 37);
            lblOrderIdKitchen.TabIndex = 44;
            lblOrderIdKitchen.Text = "{orderId}";
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
            // lblBestelregelIdKitchen
            // 
            lblBestelregelIdKitchen.AutoSize = true;
            lblBestelregelIdKitchen.Location = new Point(59, 155);
            lblBestelregelIdKitchen.Name = "lblBestelregelIdKitchen";
            lblBestelregelIdKitchen.Size = new Size(187, 37);
            lblBestelregelIdKitchen.TabIndex = 33;
            lblBestelregelIdKitchen.Text = "{bestelregelId}";
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
            lblStatusOfDish.Location = new Point(1705, 435);
            lblStatusOfDish.Name = "lblStatusOfDish";
            lblStatusOfDish.Size = new Size(102, 37);
            lblStatusOfDish.TabIndex = 50;
            lblStatusOfDish.Text = "{status}";
            // 
            // KitchenOrderControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblStatusOfDish);
            Controls.Add(cbxSelectOrderKitchen);
            Controls.Add(btnServedKitchen);
            Controls.Add(btnPreparedKitchen);
            Controls.Add(btnPreparationKitchen);
            Controls.Add(lblViewOrderStatusHeaderBar);
            Controls.Add(lblDescriptionKitchen);
            Controls.Add(lblCountKitchen);
            Controls.Add(lblOrderIdKitchen);
            Controls.Add(lblChangeStatusHeaderKitchen);
            Controls.Add(lblDescriptionHeaderKitchen);
            Controls.Add(lblCountHeaderKitchen);
            Controls.Add(lblOrderNumberHeaderKitchen);
            Controls.Add(lblOrderIDHeaderKitchen);
            Controls.Add(lblBestelregelIdKitchen);
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
        private ComboBox cbxSelectOrderKitchen;
        private Button btnServedKitchen;
        private Button btnPreparedKitchen;
        private Button btnPreparationKitchen;
        private Label lblViewOrderStatusHeaderBar;
        private Label lblDescriptionKitchen;
        private Label lblCountKitchen;
        private Label lblOrderIdKitchen;
        private Label lblChangeStatusHeaderKitchen;
        private Label lblDescriptionHeaderKitchen;
        private Label lblCountHeaderKitchen;
        private Label lblOrderNumberHeaderKitchen;
        private Label lblOrderIDHeaderKitchen;
        private Label lblBestelregelIdKitchen;
        private PictureBox pbxHeaderViewOrderStatusKitchen;
        private PictureBox pbxHeaderKitchen;
        private Label lblStatusOfDish;
    }
}
