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
            orderViewBtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(571, 201);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(138, 128);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnBarResOverview
            // 
            btnBarResOverview.Location = new Point(149, 169);
            btnBarResOverview.Margin = new Padding(2, 2, 2, 2);
            btnBarResOverview.Name = "btnBarResOverview";
            btnBarResOverview.Size = new Size(285, 91);
            btnBarResOverview.TabIndex = 1;
            btnBarResOverview.Text = "ga naar bar / restaurant overzicht";
            btnBarResOverview.UseVisualStyleBackColor = true;
            btnBarResOverview.Click += btnBarResOverview_Click;
            // 
            // orderViewBtn
            // 
            orderViewBtn.Location = new Point(149, 283);
            orderViewBtn.Name = "orderViewBtn";
            orderViewBtn.Size = new Size(285, 89);
            orderViewBtn.TabIndex = 2;
            orderViewBtn.Text = "ga naar Bestellingen maken";
            orderViewBtn.UseVisualStyleBackColor = true;
            orderViewBtn.Click += orderViewBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(orderViewBtn);
            Controls.Add(btnBarResOverview);
            Controls.Add(listView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panelManagerView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnBarResOverview;
        private Button orderViewBtn;
    }
}