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
            listView1 = new ListView();
            btnBarResOverview = new Button();
            buttonStartManagerView = new Button();
            panelManagerView = new Panel();
            panelManagerView.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(584, 161);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnBarResOverview
            // 
            btnBarResOverview.Location = new Point(696, 631);
            btnBarResOverview.Margin = new Padding(1);
            btnBarResOverview.Name = "btnBarResOverview";
            btnBarResOverview.Size = new Size(250, 68);
            btnBarResOverview.TabIndex = 1;
            btnBarResOverview.Text = "ga naar bar / restaurant overzicht";
            btnBarResOverview.UseVisualStyleBackColor = true;
            btnBarResOverview.Click += btnBarResOverview_Click;
            // 
            // buttonStartManagerView
            // 
            buttonStartManagerView.Location = new Point(229, -22);
            buttonStartManagerView.Name = "buttonStartManagerView";
            buttonStartManagerView.Size = new Size(165, 49);
            buttonStartManagerView.TabIndex = 2;
            buttonStartManagerView.Text = "Show Manager View";
            buttonStartManagerView.UseVisualStyleBackColor = true;
            buttonStartManagerView.Click += buttonStartManagerView_Click;
            // 
            // panelManagerView
            // 
            panelManagerView.Controls.Add(btnBarResOverview);
            panelManagerView.Location = new Point(25, 33);
            panelManagerView.Name = "panelManagerView";
            panelManagerView.Size = new Size(937, 750);
            panelManagerView.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 931);
            Controls.Add(buttonStartManagerView);
            Controls.Add(listView1);
            Controls.Add(panelManagerView);
            Name = "Form1";
            Text = "Form1";
            panelManagerView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnBarResOverview;
        private Button buttonStartManagerView;
        private Panel panelManagerView;
    }
}