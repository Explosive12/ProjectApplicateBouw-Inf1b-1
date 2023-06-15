using Project1._4.RoundedItems;

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
            buttonSelectOption = new RoundButton();
            textBoxType = new RoundTextBox();
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
            buttonSelectOption.Size = new Size(350, 35);
            buttonSelectOption.TabIndex = 2;
            buttonSelectOption.Text = "{Name}";
            buttonSelectOption.TextAlign = ContentAlignment.MiddleLeft;
            buttonSelectOption.UseVisualStyleBackColor = false;
            // 
            // textBoxType
            // 
            textBoxType.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxType.Location = new Point(201, 8);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(128, 22);
            textBoxType.TabIndex = 1;
            textBoxType.Text = "{Type}";
            textBoxType.TextAlign = HorizontalAlignment.Center;
            textBoxType.TextChanged += textBoxType_TextChanged;
            // 
            // UserEmployeeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxType);
            Controls.Add(buttonSelectOption);
            Name = "UserEmployeeUC";
            Size = new Size(350, 35);
            Click += textBoxType_TextChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label labelName;
        private RoundTextBox textBoxType;
        private RoundButton buttonSelectOption;
    }

}
