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
            buttonEmployee = new RoundButton();
            textBoxType = new RoundTextBox();
            SuspendLayout();
            // 
            // buttonEmployee
            // 
            buttonEmployee.BackColor = SystemColors.ActiveBorder;
            buttonEmployee.FlatAppearance.BorderSize = 0;
            buttonEmployee.FlatStyle = FlatStyle.Flat;
            buttonEmployee.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmployee.Location = new Point(0, 0);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(350, 35);
            buttonEmployee.TabIndex = 2;
            buttonEmployee.Text = "{name}";
            buttonEmployee.TextAlign = ContentAlignment.MiddleLeft;
            buttonEmployee.UseVisualStyleBackColor = false;
            // 
            // textBoxType
            // 
            textBoxType.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxType.Location = new Point(201, 7);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(128, 22);
            textBoxType.TabIndex = 1;
            textBoxType.Text = "{Type}";
            textBoxType.TextAlign = HorizontalAlignment.Center;
            // 
            // UserEmployeeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxType);
            Controls.Add(buttonEmployee);
            Name = "UserEmployeeUC";
            Size = new Size(350, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label labelName;
        private RoundTextBox textBoxType;
        private RoundButton buttonEmployee;
    }

}
