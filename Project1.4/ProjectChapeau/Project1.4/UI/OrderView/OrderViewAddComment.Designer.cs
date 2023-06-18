namespace Project1._4.UI
{
    partial class OrderViewAddComment
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
            CommentTxtBox = new TextBox();
            orderViewCommentBackBtn = new Button();
            orderViewCommentAddBtn = new Button();
            SuspendLayout();
            // 
            // CommentTxtBox
            // 
            CommentTxtBox.Location = new Point(96, 124);
            CommentTxtBox.Multiline = true;
            CommentTxtBox.Name = "CommentTxtBox";
            CommentTxtBox.Size = new Size(175, 102);
            CommentTxtBox.TabIndex = 0;
            // 
            // orderViewCommentBackBtn
            // 
            orderViewCommentBackBtn.BackColor = Color.DarkOrange;
            orderViewCommentBackBtn.Location = new Point(-6, 12);
            orderViewCommentBackBtn.Name = "orderViewCommentBackBtn";
            orderViewCommentBackBtn.Size = new Size(86, 41);
            orderViewCommentBackBtn.TabIndex = 1;
            orderViewCommentBackBtn.Text = "BACK";
            orderViewCommentBackBtn.UseVisualStyleBackColor = false;
            orderViewCommentBackBtn.Click += orderViewCommentBackBtn_Click;
            // 
            // orderViewCommentAddBtn
            // 
            orderViewCommentAddBtn.BackColor = Color.DarkOrange;
            orderViewCommentAddBtn.Location = new Point(104, 232);
            orderViewCommentAddBtn.Name = "orderViewCommentAddBtn";
            orderViewCommentAddBtn.Size = new Size(157, 70);
            orderViewCommentAddBtn.TabIndex = 2;
            orderViewCommentAddBtn.Text = "ADD";
            orderViewCommentAddBtn.UseVisualStyleBackColor = false;
            orderViewCommentAddBtn.Click += orderViewCommentAddBtn_Click;
            // 
            // OrderViewAddComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 611);
            Controls.Add(orderViewCommentAddBtn);
            Controls.Add(orderViewCommentBackBtn);
            Controls.Add(CommentTxtBox);
            Name = "OrderViewAddComment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderViewAddComment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CommentTxtBox;
        private Button orderViewCommentBackBtn;
        private Button orderViewCommentAddBtn;
    }
}