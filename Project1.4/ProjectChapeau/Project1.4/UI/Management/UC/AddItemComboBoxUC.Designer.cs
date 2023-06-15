using Project1._4.UI.Management.RoundedItems;

namespace Project1._4.UI.Management.UC
{
    partial class AddItemComboBoxUC
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
            labelAddComboBoxItem = new Label();
            comboBoxType = new RoundComboBox();
            SuspendLayout();
            // 
            // labelAddComboBoxItem
            // 
            labelAddComboBoxItem.AutoSize = true;
            labelAddComboBoxItem.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddComboBoxItem.Location = new Point(3, 8);
            labelAddComboBoxItem.Name = "labelAddComboBoxItem";
            labelAddComboBoxItem.Size = new Size(64, 18);
            labelAddComboBoxItem.TabIndex = 1;
            labelAddComboBoxItem.Text = "{word}";
            // 
            // comboBoxType
            // 
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(201, 8);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(128, 22);
            comboBoxType.TabIndex = 2;
            // 
            // AddItemComboBoxUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(comboBoxType);
            Controls.Add(labelAddComboBoxItem);
            Name = "AddItemComboBoxUC";
            Size = new Size(350, 35);
            Load += FillComboBox;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAddComboBoxItem;
        private RoundComboBox comboBoxType;
    }
}
