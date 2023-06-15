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
            SuspendLayout();
            // 
            // lblTableIdStatusControl
            // 
            lblTableIdStatusControl.AutoSize = true;
            lblTableIdStatusControl.Location = new Point(153, 87);
            lblTableIdStatusControl.Name = "lblTableIdStatusControl";
            lblTableIdStatusControl.Size = new Size(38, 15);
            lblTableIdStatusControl.TabIndex = 0;
            lblTableIdStatusControl.Text = "label1";
            // 
            // tableStatusControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTableIdStatusControl);
            Name = "tableStatusControl";
            Size = new Size(367, 445);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTableIdStatusControl;
    }
}
