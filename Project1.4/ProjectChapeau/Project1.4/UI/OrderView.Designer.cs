namespace Project1._4
{
    partial class OrderView
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
            testBtn = new Button();
            OrderViewFLP = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // testBtn
            // 
            testBtn.Location = new Point(116, 371);
            testBtn.Margin = new Padding(3, 2, 3, 2);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(146, 22);
            testBtn.TabIndex = 0;
            testBtn.Text = "Load All test button";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
            // 
            // OrderViewFLP
            // 
            OrderViewFLP.AutoScroll = true;
            OrderViewFLP.Location = new Point(3, 50);
            OrderViewFLP.Margin = new Padding(3, 2, 3, 2);
            OrderViewFLP.Name = "OrderViewFLP";
            OrderViewFLP.Size = new Size(340, 296);
            OrderViewFLP.TabIndex = 1;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(OrderViewFLP);
            Controls.Add(testBtn);
            Name = "OrderView";
            Text = "OrderView";
            ResumeLayout(false);
        }

        #endregion

        private Button testBtn;
        private FlowLayoutPanel OrderViewFLP;
    }
}