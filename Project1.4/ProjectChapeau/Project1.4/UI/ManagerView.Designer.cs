namespace Project1._4.UI
{
    partial class ManagerView
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
            panelManagerView = new Panel();
            button1 = new Button();
            panelManagerView.SuspendLayout();
            SuspendLayout();
            // 
            // panelManagerView
            // 
            panelManagerView.Controls.Add(button1);
            panelManagerView.Location = new Point(0, 0);
            panelManagerView.Margin = new Padding(2);
            panelManagerView.Name = "panelManagerView";
            panelManagerView.Size = new Size(246, 565);
            panelManagerView.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(40, 508);
            button1.Name = "button1";
            button1.Size = new Size(65, 32);
            button1.TabIndex = 0;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManagerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 565);
            Controls.Add(panelManagerView);
            Margin = new Padding(2);
            Name = "ManagerView";
            Text = "ManagerView";
            Load += ManagerView_Load;
            panelManagerView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelManagerView;
        private Button button1;
    }
}