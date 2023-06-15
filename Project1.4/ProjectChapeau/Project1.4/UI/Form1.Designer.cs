namespace Project1._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBarResOverview = new Button();
            var x= btnBarResOverview.Text;
            buttonStartManagerView = new Button();
            panelManagerView = new Panel();
            panelManagerView.SuspendLayout();
            SuspendLayout();
            // 
            // btnBarResOverview
            // 
            btnBarResOverview.Location = new Point(994, 1052);
            btnBarResOverview.Margin = new Padding(1, 2, 1, 2);
            btnBarResOverview.Name = "btnBarResOverview";
            btnBarResOverview.Size = new Size(357, 113);
            btnBarResOverview.TabIndex = 1;
            btnBarResOverview.Text = "ga naar bar / restaurant overzicht";
            btnBarResOverview.UseVisualStyleBackColor = true;
            btnBarResOverview.Click += btnBarResOverview_Click;
            // 
            // buttonStartManagerView
            // 
            buttonStartManagerView.Location = new Point(1261, 14);
            buttonStartManagerView.Margin = new Padding(4, 5, 4, 5);
            buttonStartManagerView.Name = "buttonStartManagerView";
            buttonStartManagerView.Size = new Size(236, 82);
            buttonStartManagerView.TabIndex = 2;
            buttonStartManagerView.Text = "Show Manager View";
            buttonStartManagerView.UseVisualStyleBackColor = true;
            buttonStartManagerView.Click += buttonStartManagerView_Click;
            // 
            // panelManagerView
            // 
            panelManagerView.Controls.Add(btnBarResOverview);
            panelManagerView.Location = new Point(36, 55);
            panelManagerView.Margin = new Padding(4, 5, 4, 5);
            panelManagerView.Name = "panelManagerView";
            panelManagerView.Size = new Size(1339, 1250);
            panelManagerView.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1856, 1410);
            Controls.Add(buttonStartManagerView);
            Controls.Add(panelManagerView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            panelManagerView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnBarResOverview;
        private Button buttonStartManagerView;
        private Panel panelManagerView;
    }
}