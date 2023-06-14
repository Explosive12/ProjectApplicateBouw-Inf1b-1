namespace Project1._4
{
    partial class TableButtonsControl
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
            btnTableButton = new Button();
            SuspendLayout();
            // 
            // btnTableButton
            // 
            btnTableButton.Location = new Point(0, 0);
            btnTableButton.Name = "btnTableButton";
            btnTableButton.Size = new Size(140, 72);
            btnTableButton.TabIndex = 0;
            btnTableButton.UseVisualStyleBackColor = true;
            // 
            // TableButtonsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTableButton);
            Name = "TableButtonsControl";
            Size = new Size(140, 72);
            ResumeLayout(false);
        }

        #endregion

        private Button btnTableButton;
    }
}
