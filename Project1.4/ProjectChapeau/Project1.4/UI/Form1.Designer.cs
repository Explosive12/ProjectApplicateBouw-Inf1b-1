﻿namespace Project1._4
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
            btnLoginview = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(515, 118);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnLoginview
            // 
            btnLoginview.Location = new Point(119, 291);
            btnLoginview.Name = "btnLoginview";
            btnLoginview.Size = new Size(243, 76);
            btnLoginview.TabIndex = 1;
            btnLoginview.Text = "Login ";
            btnLoginview.UseVisualStyleBackColor = true;
            btnLoginview.Click += btnLoginview_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoginview);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnLoginview;
    }
}