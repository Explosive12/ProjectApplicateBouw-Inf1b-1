namespace Project1._4.UI.Payment
{
    partial class commentOrContinuePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(commentOrContinuePayment));
            logo = new PictureBox();
            labelCustomerComment = new Label();
            buttonContinuePayment = new Button();
            buttonAddComment = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(0, -3);
            logo.Name = "logo";
            logo.Size = new Size(115, 58);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // labelCustomerComment
            // 
            labelCustomerComment.AutoSize = true;
            labelCustomerComment.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomerComment.Location = new Point(101, 191);
            labelCustomerComment.Name = "labelCustomerComment";
            labelCustomerComment.Size = new Size(201, 30);
            labelCustomerComment.TabIndex = 18;
            labelCustomerComment.Text = "ANY COMMENTS?";
            // 
            // buttonContinuePayment
            // 
            buttonContinuePayment.BackColor = Color.FromArgb(138, 210, 176);
            buttonContinuePayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinuePayment.Location = new Point(80, 352);
            buttonContinuePayment.Name = "buttonContinuePayment";
            buttonContinuePayment.Size = new Size(243, 44);
            buttonContinuePayment.TabIndex = 20;
            buttonContinuePayment.Text = "CONTINUE WITH PAYMENT";
            buttonContinuePayment.UseVisualStyleBackColor = false;
            buttonContinuePayment.Click += buttonContinuePayment_Click;
            // 
            // buttonAddComment
            // 
            buttonAddComment.BackColor = Color.Orange;
            buttonAddComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddComment.Location = new Point(80, 279);
            buttonAddComment.Name = "buttonAddComment";
            buttonAddComment.Size = new Size(243, 44);
            buttonAddComment.TabIndex = 21;
            buttonAddComment.Text = "ADD A COMMENT";
            buttonAddComment.UseVisualStyleBackColor = false;
            buttonAddComment.Click += buttonAddComment_Click;
            // 
            // commentOrContinuePayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(buttonAddComment);
            Controls.Add(buttonContinuePayment);
            Controls.Add(labelCustomerComment);
            Controls.Add(logo);
            Name = "commentOrContinuePayment";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label labelCustomerComment;
        private Button buttonContinuePayment;
        private Button buttonAddComment;
    }
}