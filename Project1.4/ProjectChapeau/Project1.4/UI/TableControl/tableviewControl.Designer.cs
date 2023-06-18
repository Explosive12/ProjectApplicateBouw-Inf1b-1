namespace Project1._4
{
    partial class tableviewControl
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
            tableLayoutPanel = new TableLayoutPanel();
            pnlFree = new Panel();
            pnlAccupied = new Panel();
            pnlReserved = new Panel();
            pnlOrdered = new Panel();
            lblFree = new Label();
            lblOccupied = new Label();
            lblReserved = new Label();
            lblOrdered = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Size = new Size(367, 374);
            tableLayoutPanel.TabIndex = 0;
            // 
            // pnlFree
            // 
            pnlFree.BackColor = Color.FromArgb(138, 210, 176);
            pnlFree.Location = new Point(28, 393);
            pnlFree.Name = "pnlFree";
            pnlFree.Size = new Size(19, 20);
            pnlFree.TabIndex = 0;
            // 
            // pnlAccupied
            // 
            pnlAccupied.BackColor = Color.FromArgb(255, 179, 71);
            pnlAccupied.Location = new Point(108, 393);
            pnlAccupied.Name = "pnlAccupied";
            pnlAccupied.Size = new Size(19, 20);
            pnlAccupied.TabIndex = 1;
            // 
            // pnlReserved
            // 
            pnlReserved.BackColor = Color.FromArgb(196, 196, 196);
            pnlReserved.Location = new Point(196, 393);
            pnlReserved.Name = "pnlReserved";
            pnlReserved.Size = new Size(19, 20);
            pnlReserved.TabIndex = 1;
            // 
            // pnlOrdered
            // 
            pnlOrdered.BackColor = Color.FromArgb(248, 102, 39);
            pnlOrdered.Location = new Point(274, 393);
            pnlOrdered.Name = "pnlOrdered";
            pnlOrdered.Size = new Size(19, 20);
            pnlOrdered.TabIndex = 1;
            // 
            // lblFree
            // 
            lblFree.AutoSize = true;
            lblFree.Location = new Point(18, 416);
            lblFree.Name = "lblFree";
            lblFree.Size = new Size(29, 15);
            lblFree.TabIndex = 0;
            lblFree.Text = "Free";
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.Location = new Point(88, 416);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(58, 15);
            lblOccupied.TabIndex = 2;
            lblOccupied.Text = "Occupied";
            // 
            // lblReserved
            // 
            lblReserved.AutoSize = true;
            lblReserved.Location = new Point(177, 416);
            lblReserved.Name = "lblReserved";
            lblReserved.Size = new Size(54, 15);
            lblReserved.TabIndex = 3;
            lblReserved.Text = "Reserved";
            // 
            // lblOrdered
            // 
            lblOrdered.AutoSize = true;
            lblOrdered.Location = new Point(259, 416);
            lblOrdered.Name = "lblOrdered";
            lblOrdered.Size = new Size(50, 15);
            lblOrdered.TabIndex = 4;
            lblOrdered.Text = "Ordered";
            // 
            // tableviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblOrdered);
            Controls.Add(lblReserved);
            Controls.Add(lblOccupied);
            Controls.Add(lblFree);
            Controls.Add(pnlOrdered);
            Controls.Add(pnlReserved);
            Controls.Add(pnlAccupied);
            Controls.Add(pnlFree);
            Controls.Add(tableLayoutPanel);
            Location = new Point(22, 37);
            Name = "tableviewControl";
            Size = new Size(367, 445);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel pnlFree;
        private Panel pnlAccupied;
        private Panel pnlReserved;
        private Panel pnlOrdered;
        private Label lblFree;
        private Label lblOccupied;
        private Label lblReserved;
        private Label lblOrdered;
    }
}
