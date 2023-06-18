namespace Project1._4
{
    partial class tableStatusControl
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
            lblTableIdStatusControl = new Label();
            lblTable = new Label();
            btnFreeTableControl = new Button();
            btnOccupiedTableControl = new Button();
            btnReservedTableControl = new Button();
            btnGoToTableControl = new Button();
            btnBackTableControl = new Button();
            SuspendLayout();
            // 
            // lblTableIdStatusControl
            // 
            lblTableIdStatusControl.AutoSize = true;
            lblTableIdStatusControl.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableIdStatusControl.Location = new Point(215, 67);
            lblTableIdStatusControl.Name = "lblTableIdStatusControl";
            lblTableIdStatusControl.Size = new Size(0, 33);
            lblTableIdStatusControl.TabIndex = 0;
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTable.Location = new Point(119, 67);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(101, 33);
            lblTable.TabIndex = 1;
            lblTable.Text = "TABLE";
            // 
            // btnFreeTableControl
            // 
            btnFreeTableControl.BackColor = Color.FromArgb(138, 210, 176);
            btnFreeTableControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFreeTableControl.ForeColor = SystemColors.ControlText;
            btnFreeTableControl.Location = new Point(27, 158);
            btnFreeTableControl.Name = "btnFreeTableControl";
            btnFreeTableControl.Size = new Size(100, 37);
            btnFreeTableControl.TabIndex = 2;
            btnFreeTableControl.Text = "FREE";
            btnFreeTableControl.UseVisualStyleBackColor = false;
            // 
            // btnOccupiedTableControl
            // 
            btnOccupiedTableControl.BackColor = Color.FromArgb(255, 179, 71);
            btnOccupiedTableControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOccupiedTableControl.Location = new Point(133, 158);
            btnOccupiedTableControl.Name = "btnOccupiedTableControl";
            btnOccupiedTableControl.Size = new Size(100, 37);
            btnOccupiedTableControl.TabIndex = 3;
            btnOccupiedTableControl.Text = "OCCUPIED";
            btnOccupiedTableControl.UseVisualStyleBackColor = false;
            // 
            // btnReservedTableControl
            // 
            btnReservedTableControl.BackColor = Color.FromArgb(196, 196, 196);
            btnReservedTableControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservedTableControl.Location = new Point(239, 158);
            btnReservedTableControl.Name = "btnReservedTableControl";
            btnReservedTableControl.Size = new Size(100, 37);
            btnReservedTableControl.TabIndex = 4;
            btnReservedTableControl.Text = "RESERVED";
            btnReservedTableControl.UseVisualStyleBackColor = false;
            // 
            // btnGoToTableControl
            // 
            btnGoToTableControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoToTableControl.Location = new Point(102, 244);
            btnGoToTableControl.Name = "btnGoToTableControl";
            btnGoToTableControl.Size = new Size(155, 37);
            btnGoToTableControl.TabIndex = 5;
            btnGoToTableControl.Text = "Go to table";
            btnGoToTableControl.UseVisualStyleBackColor = true;
            // 
            // btnBackTableControl
            // 
            btnBackTableControl.BackColor = Color.FromArgb(255, 179, 71);
            btnBackTableControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackTableControl.Location = new Point(0, 369);
            btnBackTableControl.Name = "btnBackTableControl";
            btnBackTableControl.Size = new Size(87, 37);
            btnBackTableControl.TabIndex = 6;
            btnBackTableControl.Text = "BACK";
            btnBackTableControl.UseVisualStyleBackColor = false;
            btnBackTableControl.Click += Back;
            // 
            // tableStatusControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBackTableControl);
            Controls.Add(btnGoToTableControl);
            Controls.Add(btnReservedTableControl);
            Controls.Add(btnOccupiedTableControl);
            Controls.Add(btnFreeTableControl);
            Controls.Add(lblTable);
            Controls.Add(lblTableIdStatusControl);
            Name = "tableStatusControl";
            Size = new Size(367, 445);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTableIdStatusControl;
        private Label lblTable;
        private Button btnFreeTableControl;
        private Button btnOccupiedTableControl;
        private Button btnReservedTableControl;
        private Button btnGoToTableControl;
        private Button btnBackTableControl;
    }
}
