namespace Project1._4.UI
{
    partial class TableView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            FLPTableView = new FlowLayoutPanel();
            lblLoginName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.chapeagoeie;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FLPTableView
            // 
            FLPTableView.Location = new Point(28, 125);
            FLPTableView.Name = "FLPTableView";
            FLPTableView.Size = new Size(367, 445);
            FLPTableView.TabIndex = 1;
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.BackColor = Color.FromArgb(255, 179, 71);
            lblLoginName.BorderStyle = BorderStyle.FixedSingle;
            lblLoginName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginName.Location = new Point(317, 9);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(2, 21);
            lblLoginName.TabIndex = 2;
            // 
            // TableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 697);
            Controls.Add(lblLoginName);
            Controls.Add(FLPTableView);
            Controls.Add(pictureBox1);
            Name = "TableView";
            Text = "Table";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel FLPTableView;
        private Label lblLoginName;
    }
}