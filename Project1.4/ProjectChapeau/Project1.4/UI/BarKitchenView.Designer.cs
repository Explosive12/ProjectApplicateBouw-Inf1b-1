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
            flpKitchenOrders = new FlowLayoutPanel();
            btnLoadKitchenOrders = new Button();
            btnKitchenToMain = new Button();
            SuspendLayout();
            // 
            // flpKitchenOrders
            // 
            flpKitchenOrders.Location = new Point(215, 39);
            flpKitchenOrders.Name = "flpKitchenOrders";
            flpKitchenOrders.Size = new Size(1927, 1549);
            flpKitchenOrders.TabIndex = 3;
            // 
            // btnLoadKitchenOrders
            // 
            btnLoadKitchenOrders.Location = new Point(12, 178);
            btnLoadKitchenOrders.Name = "btnLoadKitchenOrders";
            btnLoadKitchenOrders.Size = new Size(169, 52);
            btnLoadKitchenOrders.TabIndex = 4;
            btnLoadKitchenOrders.Text = "button";
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
            // BarKitchenView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2237, 1005);
            Controls.Add(btnKitchenToMain);
            Controls.Add(btnLoadKitchenOrders);
            Controls.Add(flpKitchenOrders);
            Name = "BarKitchenView";
            Text = "BarKitchenView";
            ResumeLayout(false);
        }

        #endregion
        private Button btnLoad2004;
        private FlowLayoutPanel flpKitchenOrders;
        private Button button2;
        private Button btnLoadKitchenOrders;
        private Button btnKitchenToMain;
    }
}