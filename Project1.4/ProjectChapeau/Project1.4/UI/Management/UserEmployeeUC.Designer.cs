using Project1._4.UI.Management.RoundedItems;

namespace Project1._4.UI
{
    partial class UserEmployeeUC
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
            labelName = new Label();
            textBoxType = new RoundTextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(12, 12);
            labelName.Name = "labelName";
            labelName.Size = new Size(54, 14);
            labelName.TabIndex = 0;
            labelName.Text = "{Name}";
            // 
            // textBoxType
            // 
            textBoxType.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxType.Location = new Point(201, 9);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(128, 22);
            textBoxType.TabIndex = 1;
            textBoxType.Text = "{Type}";
            textBoxType.TextChanged += textBoxType_TextChanged;
            // 
            // UserEmployeeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(textBoxType);
            Controls.Add(labelName);
            Name = "UserEmployeeUC";
            Size = new Size(345, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private RoundTextBox textBoxType;
    }

}
