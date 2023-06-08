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
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(1071, 372);
            listView1.Margin = new Padding(6, 7, 6, 7);
            listView1.Name = "listView1";
            listView1.Size = new Size(255, 233);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnBarResOverview
            // 
            btnBarResOverview.Location = new Point(280, 312);
            btnBarResOverview.Name = "btnBarResOverview";
            btnBarResOverview.Size = new Size(535, 168);
            btnBarResOverview.TabIndex = 1;
            btnBarResOverview.Text = "ga naar bar / restaurant overzicht";
            btnBarResOverview.UseVisualStyleBackColor = true;
            btnBarResOverview.Click += btnBarResOverview_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 1110);
            Controls.Add(btnBarResOverview);
            Controls.Add(listView1);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnBarResOverview;
    }
}