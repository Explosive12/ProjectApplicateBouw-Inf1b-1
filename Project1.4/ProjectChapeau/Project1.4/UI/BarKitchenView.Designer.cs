namespace Project1._4.UI
{
    partial class BarKitchenView
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
            lblKitchenHeader = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblKitchenHeader
            // 
            lblKitchenHeader.AutoSize = true;
            lblKitchenHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblKitchenHeader.Location = new Point(819, 85);
            lblKitchenHeader.Name = "lblKitchenHeader";
            lblKitchenHeader.Size = new Size(553, 104);
            lblKitchenHeader.TabIndex = 0;
            lblKitchenHeader.Text = "Kitchen Orders";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(244, 85);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // BarKitchenView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2237, 1005);
            Controls.Add(button1);
            Controls.Add(lblKitchenHeader);
            Name = "BarKitchenView";
            Text = "BarKitchenView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKitchenHeader;
        private Button button1;
    }
}