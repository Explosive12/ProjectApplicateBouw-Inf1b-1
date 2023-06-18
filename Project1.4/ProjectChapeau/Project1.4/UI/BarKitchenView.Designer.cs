namespace Project1._4.UI
{
    partial class BarKitchenView
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
            flpOrders = new FlowLayoutPanel();
            btnLoadKitchenOrders = new Button();
            btnKitchenToMain = new Button();
            btnLoadBarOrders = new Button();
            SuspendLayout();
            // 
            // flpOrders
            // 
            flpOrders.ForeColor = Color.Black;
            flpOrders.Location = new Point(215, 39);
            flpOrders.Name = "flpOrders";
            flpOrders.Size = new Size(2456, 943);
            flpOrders.TabIndex = 3;
            // 
            // btnLoadKitchenOrders
            // 
            btnLoadKitchenOrders.Location = new Point(12, 178);
            btnLoadKitchenOrders.Name = "btnLoadKitchenOrders";
            btnLoadKitchenOrders.Size = new Size(169, 52);
            btnLoadKitchenOrders.TabIndex = 4;
            btnLoadKitchenOrders.Text = "Kitchen";
            btnLoadKitchenOrders.UseVisualStyleBackColor = true;
            btnLoadKitchenOrders.Click += btnLoadKitchenOrders_Click;
            // 
            // btnKitchenToMain
            // 
            btnKitchenToMain.Location = new Point(12, 104);
            btnKitchenToMain.Name = "btnKitchenToMain";
            btnKitchenToMain.Size = new Size(169, 52);
            btnKitchenToMain.TabIndex = 5;
            btnKitchenToMain.Text = "Back";
            btnKitchenToMain.UseVisualStyleBackColor = true;
            btnKitchenToMain.Click += btnKitchenToMain_Click;
            // 
            // btnLoadBarOrders
            // 
            btnLoadBarOrders.Location = new Point(12, 251);
            btnLoadBarOrders.Name = "btnLoadBarOrders";
            btnLoadBarOrders.Size = new Size(169, 52);
            btnLoadBarOrders.TabIndex = 6;
            btnLoadBarOrders.Text = "Bar";
            btnLoadBarOrders.UseVisualStyleBackColor = true;
            btnLoadBarOrders.Click += btnLoadBarOrders_Click;
            // 
            // BarKitchenView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2702, 1370);
            Controls.Add(btnLoadBarOrders);
            Controls.Add(btnKitchenToMain);
            Controls.Add(btnLoadKitchenOrders);
            Controls.Add(flpOrders);
            Name = "BarKitchenView";
            Text = "BarKitchenView";
            ResumeLayout(false);
        }

        #endregion
        private Button btnLoad2004;
        private FlowLayoutPanel flpOrders;
        private Button btnLoadKitchenOrders;
        private Button btnKitchenToMain;
        private Button btnLoadBarOrders;
    }
}