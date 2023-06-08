namespace Project1._4.UI.Payment
{
    partial class commentPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(commentPayment));
            logo = new PictureBox();
            confirmPayment = new Button();
            backToCommentOrContinue = new Button();
            commentCustomerBox = new TextBox();
            labelCustomerComment = new Label();
            commentHasBeenSaved = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(-1, 1);
            logo.Name = "logo";
            logo.Size = new Size(115, 58);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 4;
            logo.TabStop = false;
            // 
            // confirmPayment
            // 
            confirmPayment.BackColor = Color.FromArgb(138, 210, 176);
            confirmPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPayment.Location = new Point(77, 468);
            confirmPayment.Name = "confirmPayment";
            confirmPayment.Size = new Size(243, 44);
            confirmPayment.TabIndex = 14;
            confirmPayment.Text = "CONFIRM";
            confirmPayment.UseVisualStyleBackColor = false;
            confirmPayment.Click += confirmPayment_Click;
            // 
            // backToCommentOrContinue
            // 
            backToCommentOrContinue.BackColor = Color.Orange;
            backToCommentOrContinue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backToCommentOrContinue.Location = new Point(300, 12);
            backToCommentOrContinue.Name = "backToCommentOrContinue";
            backToCommentOrContinue.Size = new Size(86, 38);
            backToCommentOrContinue.TabIndex = 15;
            backToCommentOrContinue.Text = "BACK";
            backToCommentOrContinue.UseVisualStyleBackColor = false;
            backToCommentOrContinue.Click += backToCommentOrContinue_Click;
            // 
            // commentCustomerBox
            // 
            commentCustomerBox.Location = new Point(55, 170);
            commentCustomerBox.Multiline = true;
            commentCustomerBox.Name = "commentCustomerBox";
            commentCustomerBox.Size = new Size(293, 274);
            commentCustomerBox.TabIndex = 16;
            commentCustomerBox.TextChanged += commentCustomerBox_TextChanged;
            // 
            // labelCustomerComment
            // 
            labelCustomerComment.AutoSize = true;
            labelCustomerComment.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerComment.Location = new Point(12, 122);
            labelCustomerComment.Name = "labelCustomerComment";
            labelCustomerComment.Size = new Size(377, 30);
            labelCustomerComment.TabIndex = 17;
            labelCustomerComment.Text = "TYPE CUSTOMER COMMENT HERE:";
            // 
            // commentHasBeenSaved
            // 
            commentHasBeenSaved.AutoSize = true;
            commentHasBeenSaved.BackColor = Color.White;
            commentHasBeenSaved.ForeColor = Color.FromArgb(138, 210, 176);
            commentHasBeenSaved.Location = new Point(114, 529);
            commentHasBeenSaved.Name = "commentHasBeenSaved";
            commentHasBeenSaved.Size = new Size(0, 15);
            commentHasBeenSaved.TabIndex = 18;
            // 
            // commentPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(commentHasBeenSaved);
            Controls.Add(labelCustomerComment);
            Controls.Add(commentCustomerBox);
            Controls.Add(backToCommentOrContinue);
            Controls.Add(confirmPayment);
            Controls.Add(logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "commentPayment";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Button confirmPayment;
        private Button backToCommentOrContinue;
        private TextBox commentCustomerBox;
        private Label labelCustomerComment;
        private Label commentHasBeenSaved;
    }
}