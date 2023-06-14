using Project1._4.UI.Management.RoundedItems;

namespace Project1._4.UI.Management
{
    partial class EmployeeManagementUC
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
            Logo = new PictureBox();
            listBoxEmployee = new RoundListBox();
            labelEmployees = new RoundLabel();
            buttonGoBack = new RoundButton();
            buttonAddNew = new RoundButton();
            buttonRemove = new RoundButton();
            buttonAdjust = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.chapeagoeie;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(131, 66);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            // 
            // listBoxEmployee
            // 
            listBoxEmployee.BackColor = Color.White;
            listBoxEmployee.FormattingEnabled = true;
            listBoxEmployee.ItemHeight = 15;
            listBoxEmployee.Location = new Point(32, 156);
            listBoxEmployee.Name = "listBoxEmployee";
            listBoxEmployee.Size = new Size(357, 439);
            listBoxEmployee.TabIndex = 4;
            // 
            // labelEmployees
            // 
            labelEmployees.AutoSize = true;
            labelEmployees.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmployees.Location = new Point(22, 114);
            labelEmployees.Name = "labelEmployees";
            labelEmployees.Size = new Size(211, 39);
            labelEmployees.TabIndex = 5;
            labelEmployees.Text = "EMPLOYEES";
            // 
            // buttonGoBack
            // 
            buttonGoBack.BackColor = Color.DarkOrange;
            buttonGoBack.FlatAppearance.BorderSize = 0;
            buttonGoBack.FlatStyle = FlatStyle.Flat;
            buttonGoBack.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGoBack.ForeColor = SystemColors.ActiveCaptionText;
            buttonGoBack.Location = new Point(296, 21);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(86, 43);
            buttonGoBack.TabIndex = 6;
            buttonGoBack.Text = "BACK";
            buttonGoBack.UseVisualStyleBackColor = false;
            // 
            // buttonAddNew
            // 
            buttonAddNew.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddNew.FlatAppearance.BorderSize = 0;
            buttonAddNew.FlatStyle = FlatStyle.Flat;
            buttonAddNew.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNew.Location = new Point(246, 84);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(133, 69);
            buttonAddNew.TabIndex = 7;
            buttonAddNew.Text = "ADD NEW";
            buttonAddNew.UseVisualStyleBackColor = false;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(255, 128, 128);
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.Location = new Point(256, 601);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(133, 69);
            buttonRemove.TabIndex = 9;
            buttonRemove.Text = "REMOVE";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // buttonAdjust
            // 
            buttonAdjust.BackColor = Color.FromArgb(138, 210, 176);
            buttonAdjust.FlatAppearance.BorderSize = 0;
            buttonAdjust.FlatStyle = FlatStyle.Flat;
            buttonAdjust.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdjust.Location = new Point(32, 601);
            buttonAdjust.Name = "buttonAdjust";
            buttonAdjust.Size = new Size(133, 69);
            buttonAdjust.TabIndex = 10;
            buttonAdjust.Text = "Adjust";
            buttonAdjust.UseVisualStyleBackColor = false;
            // 
            // EmployeeManagementUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAdjust);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonGoBack);
            Controls.Add(labelEmployees);
            Controls.Add(listBoxEmployee);
            Controls.Add(Logo);
            Name = "EmployeeManagementUC";
            Size = new Size(414, 736);
            Load += OnLoad;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private RoundLabel labelEmployees;
        private RoundButton buttonGoBack;
        private RoundButton buttonAddNew;
        private RoundButton buttonRemove;
        private RoundButton buttonAdjust;
        private RoundListBox listBoxEmployee;
    }
}
