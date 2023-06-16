using Project1._4.RoundedItems;

namespace Project1._4.UI
{
    partial class ItemButtonUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSelectOption = new RoundButton();
            textBox = new RoundTextBox();
            SuspendLayout();
            // 
            // buttonSelectOption
            // 
            buttonSelectOption.BackColor = SystemColors.ActiveBorder;
            buttonSelectOption.FlatAppearance.BorderSize = 0;
            buttonSelectOption.FlatStyle = FlatStyle.Flat;
            buttonSelectOption.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSelectOption.Location = new Point(0, 0);
            buttonSelectOption.Name = "buttonSelectOption";
            buttonSelectOption.Padding = new Padding(0, 0, 40, 0);
            buttonSelectOption.Size = new Size(350, 35);
            buttonSelectOption.TabIndex = 2;
            buttonSelectOption.Text = "{Name}";
            buttonSelectOption.TextAlign = ContentAlignment.MiddleLeft;
            buttonSelectOption.UseVisualStyleBackColor = false;
            buttonSelectOption.Click += OptionSelected;
            // 
            // textBoxStock
            // 
            textBox.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox.Location = new Point(201, 8);
            textBox.Name = "textBoxStock";
            textBox.ReadOnly = true;
            textBox.Size = new Size(128, 22);
            textBox.TabIndex = 1;
            textBox.Text = "{Type}";
            textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ItemButtonUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox);
            Controls.Add(buttonSelectOption);
            Name = "ItemButtonUC";
            Size = new Size(350, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label labelName;
        private RoundTextBox textBox;
        private RoundButton buttonSelectOption;
    }

}
