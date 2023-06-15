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
            cbxOrderStatusBar = new ComboBox();
            cbxSelectOrderBar = new ComboBox();
            lblDescriptionBar = new Label();
            lblCountBar = new Label();
            lblOrderIdBar = new Label();
            pbxHeaderViewOrderStatusBar = new PictureBox();
            btnServedBar = new Button();
            btnPreparedBar = new Button();
            btnPreparationBar = new Button();
            lblChangeStatusHeaderBar = new Label();
            lblDescriptionHeaderBar = new Label();
            lblCountHeaderBar = new Label();
            lblOrderNumberHeaderBar = new Label();
            lblOrderIDHeaderBar = new Label();
            lblBestelregelIdBar = new Label();
            pbxHeaderBar = new PictureBox();
            lblViewOrderStatusHeaderBar = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderBar).BeginInit();
            SuspendLayout();
            // 
            // cbxOrderStatusBar
            // 
            cbxOrderStatusBar.FormattingEnabled = true;
            cbxOrderStatusBar.Location = new Point(1619, 435);
            cbxOrderStatusBar.Name = "cbxOrderStatusBar";
            cbxOrderStatusBar.Size = new Size(272, 45);
            cbxOrderStatusBar.TabIndex = 31;
            cbxOrderStatusBar.Text = "Order status";
            // 
            // cbxSelectOrderBar
            // 
            cbxSelectOrderBar.AllowDrop = true;
            cbxSelectOrderBar.FormattingEnabled = true;
            cbxSelectOrderBar.Location = new Point(1226, 435);
            cbxSelectOrderBar.Name = "cbxSelectOrderBar";
            cbxSelectOrderBar.Size = new Size(272, 45);
            cbxSelectOrderBar.TabIndex = 30;
            cbxSelectOrderBar.Text = "Selected order ID";
            // 
            // lblDescriptionBar
            // 
            lblDescriptionBar.AutoSize = true;
            lblDescriptionBar.Location = new Point(842, 155);
            lblDescriptionBar.Name = "lblDescriptionBar";
            lblDescriptionBar.Size = new Size(165, 37);
            lblDescriptionBar.TabIndex = 29;
            lblDescriptionBar.Text = "{description}";
            // 
            // lblCountBar
            // 
            lblCountBar.AutoSize = true;
            lblCountBar.Location = new Point(628, 162);
            lblCountBar.Name = "lblCountBar";
            lblCountBar.Size = new Size(100, 37);
            lblCountBar.TabIndex = 28;
            lblCountBar.Text = "{count}";
            // 
            // lblOrderIdBar
            // 
            lblOrderIdBar.AutoSize = true;
            lblOrderIdBar.Location = new Point(362, 155);
            lblOrderIdBar.Name = "lblOrderIdBar";
            lblOrderIdBar.Size = new Size(120, 37);
            lblOrderIdBar.TabIndex = 27;
            lblOrderIdBar.Text = "{orderId}";
            // 
            // pbxHeaderViewOrderStatusBar
            // 
            pbxHeaderViewOrderStatusBar.BackColor = Color.DarkOrange;
            pbxHeaderViewOrderStatusBar.Location = new Point(1164, 250);
            pbxHeaderViewOrderStatusBar.Name = "pbxHeaderViewOrderStatusBar";
            pbxHeaderViewOrderStatusBar.Size = new Size(835, 112);
            pbxHeaderViewOrderStatusBar.TabIndex = 26;
            pbxHeaderViewOrderStatusBar.TabStop = false;
            // 
            // btnServedBar
            // 
            btnServedBar.BackColor = Color.FromArgb(138, 210, 176);
            btnServedBar.ForeColor = Color.Black;
            btnServedBar.Location = new Point(1705, 147);
            btnServedBar.Name = "btnServedBar";
            btnServedBar.Size = new Size(253, 52);
            btnServedBar.TabIndex = 25;
            btnServedBar.Text = "Served";
            btnServedBar.UseVisualStyleBackColor = false;
            // 
            // btnPreparedBar
            // 
            btnPreparedBar.BackColor = Color.FromArgb(255, 179, 71);
            btnPreparedBar.Location = new Point(1435, 147);
            btnPreparedBar.Name = "btnPreparedBar";
            btnPreparedBar.Size = new Size(253, 52);
            btnPreparedBar.TabIndex = 24;
            btnPreparedBar.Text = "Prepared";
            btnPreparedBar.UseVisualStyleBackColor = false;
            // 
            // btnPreparationBar
            // 
            btnPreparationBar.Location = new Point(1164, 147);
            btnPreparationBar.Name = "btnPreparationBar";
            btnPreparationBar.Size = new Size(253, 52);
            btnPreparationBar.TabIndex = 22;
            btnPreparationBar.Text = "in preparation";
            btnPreparationBar.UseVisualStyleBackColor = true;
            // 
            // lblChangeStatusHeaderBar
            // 
            lblChangeStatusHeaderBar.AutoSize = true;
            lblChangeStatusHeaderBar.Location = new Point(1423, 40);
            lblChangeStatusHeaderBar.Name = "lblChangeStatusHeaderBar";
            lblChangeStatusHeaderBar.Size = new Size(255, 37);
            lblChangeStatusHeaderBar.TabIndex = 21;
            lblChangeStatusHeaderBar.Text = "Change order status";
            // 
            // lblDescriptionHeaderBar
            // 
            lblDescriptionHeaderBar.AutoSize = true;
            lblDescriptionHeaderBar.Location = new Point(842, 40);
            lblDescriptionHeaderBar.Name = "lblDescriptionHeaderBar";
            lblDescriptionHeaderBar.Size = new Size(152, 37);
            lblDescriptionHeaderBar.TabIndex = 20;
            lblDescriptionHeaderBar.Text = "Description";
            // 
            // lblCountHeaderBar
            // 
            lblCountHeaderBar.AutoSize = true;
            lblCountHeaderBar.Location = new Point(639, 40);
            lblCountHeaderBar.Name = "lblCountHeaderBar";
            lblCountHeaderBar.Size = new Size(89, 37);
            lblCountHeaderBar.TabIndex = 19;
            lblCountHeaderBar.Text = "Count";
            // 
            // lblOrderNumberHeaderBar
            // 
            lblOrderNumberHeaderBar.AutoSize = true;
            lblOrderNumberHeaderBar.Location = new Point(333, 40);
            lblOrderNumberHeaderBar.Name = "lblOrderNumberHeaderBar";
            lblOrderNumberHeaderBar.Size = new Size(184, 37);
            lblOrderNumberHeaderBar.TabIndex = 18;
            lblOrderNumberHeaderBar.Text = "Order number";
            // 
            // lblOrderIDHeaderBar
            // 
            lblOrderIDHeaderBar.AutoSize = true;
            lblOrderIDHeaderBar.BackColor = Color.Transparent;
            lblOrderIDHeaderBar.ImageAlign = ContentAlignment.BottomRight;
            lblOrderIDHeaderBar.Location = new Point(82, 40);
            lblOrderIDHeaderBar.Name = "lblOrderIDHeaderBar";
            lblOrderIDHeaderBar.Size = new Size(118, 37);
            lblOrderIDHeaderBar.TabIndex = 17;
            lblOrderIDHeaderBar.Text = "Order ID";
            // 
            // lblBestelregelIdBar
            // 
            lblBestelregelIdBar.AutoSize = true;
            lblBestelregelIdBar.Location = new Point(59, 155);
            lblBestelregelIdBar.Name = "lblBestelregelIdBar";
            lblBestelregelIdBar.Size = new Size(187, 37);
            lblBestelregelIdBar.TabIndex = 16;
            lblBestelregelIdBar.Text = "{bestelregelId}";
            // 
            // pbxHeaderBar
            // 
            pbxHeaderBar.BackColor = Color.DarkOrange;
            pbxHeaderBar.Location = new Point(0, 0);
            pbxHeaderBar.Name = "pbxHeaderBar";
            pbxHeaderBar.Size = new Size(1999, 112);
            pbxHeaderBar.TabIndex = 23;
            pbxHeaderBar.TabStop = false;
            // 
            // lblViewOrderStatusHeaderBar
            // 
            lblViewOrderStatusHeaderBar.AutoSize = true;
            lblViewOrderStatusHeaderBar.Location = new Point(1518, 279);
            lblViewOrderStatusHeaderBar.Name = "lblViewOrderStatusHeaderBar";
            lblViewOrderStatusHeaderBar.Size = new Size(222, 37);
            lblViewOrderStatusHeaderBar.TabIndex = 32;
            lblViewOrderStatusHeaderBar.Text = "View order status";
            // 
            // BarOrderControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbxOrderStatusBar);
            Controls.Add(cbxSelectOrderBar);
            Controls.Add(btnServedBar);
            Controls.Add(btnPreparedBar);
            Controls.Add(btnPreparationBar);
            Controls.Add(lblViewOrderStatusHeaderBar);
            Controls.Add(lblDescriptionBar);
            Controls.Add(lblCountBar);
            Controls.Add(lblOrderIdBar);
            Controls.Add(lblChangeStatusHeaderBar);
            Controls.Add(lblDescriptionHeaderBar);
            Controls.Add(lblCountHeaderBar);
            Controls.Add(lblOrderNumberHeaderBar);
            Controls.Add(lblOrderIDHeaderBar);
            Controls.Add(lblBestelregelIdBar);
            Controls.Add(pbxHeaderViewOrderStatusBar);
            Controls.Add(pbxHeaderBar);
            Name = "BarOrderControl";
            Size = new Size(1988, 787);
            ((System.ComponentModel.ISupportInitialize)pbxHeaderViewOrderStatusBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHeaderBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxOrderStatusBar;
        private ComboBox cbxSelectOrderBar;
        private Label lblDescriptionBar;
        private Label lblCountBar;
        private Label lblOrderIdBar;
        private PictureBox pbxHeaderViewOrderStatusBar;
        private Button btnServedBar;
        private Button btnPreparedBar;
        private Button btnPreparationBar;
        private Label lblChangeStatusHeaderBar;
        private Label lblDescriptionHeaderBar;
        private Label lblCountHeaderBar;
        private Label lblOrderNumberHeaderBar;
        private Label lblOrderIDHeaderBar;
        private Label lblBestelregelIdBar;
        private PictureBox pbxHeaderBar;
        private Label lblViewOrderStatusHeaderBar;
    }
}
