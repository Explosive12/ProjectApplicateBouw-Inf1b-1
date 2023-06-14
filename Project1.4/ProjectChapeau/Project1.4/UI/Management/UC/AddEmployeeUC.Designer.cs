namespace Project1._4.UI.Management.UC
{
    partial class AddEmployeeUC
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
            panelAddEmployee = new FlowLayoutPanel();
            buttonGoBack = new RoundedItems.RoundButton();
            labelNewEmployee = new Label();
            Logo = new PictureBox();
            buttonAddEmployee = new RoundedItems.RoundButton();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panelAddEmployee
            // 
            panelAddEmployee.BackColor = SystemColors.Window;
            panelAddEmployee.Location = new Point(36, 163);
            panelAddEmployee.Name = "panelAddEmployee";
            panelAddEmployee.Size = new Size(357, 449);
            panelAddEmployee.TabIndex = 13;
            // 
            // buttonGoBack
            // 
            buttonGoBack.BackColor = Color.DarkOrange;
            buttonGoBack.Cursor = Cursors.Hand;
            buttonGoBack.FlatAppearance.BorderSize = 0;
            buttonGoBack.FlatStyle = FlatStyle.Flat;
            buttonGoBack.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGoBack.ForeColor = SystemColors.ActiveCaptionText;
            buttonGoBack.Location = new Point(296, 21);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(86, 43);
            buttonGoBack.TabIndex = 14;
            buttonGoBack.Text = "BACK";
            buttonGoBack.UseVisualStyleBackColor = false;
            buttonGoBack.Click += GoBackToEmployee;
            // 
            // labelNewEmployee
            // 
            labelNewEmployee.AutoSize = true;
            labelNewEmployee.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelNewEmployee.Location = new Point(25, 121);
            labelNewEmployee.Name = "labelNewEmployee";
            labelNewEmployee.Size = new Size(278, 39);
            labelNewEmployee.TabIndex = 15;
            labelNewEmployee.Text = "NEW EMPLOYEE";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.chapeagoeie;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(131, 66);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 16;
            Logo.TabStop = false;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddEmployee.Cursor = Cursors.Hand;
            buttonAddEmployee.FlatAppearance.BorderSize = 0;
            buttonAddEmployee.FlatStyle = FlatStyle.Flat;
            buttonAddEmployee.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddEmployee.Location = new Point(36, 633);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(120, 35);
            buttonAddEmployee.TabIndex = 17;
            buttonAddEmployee.Text = "ADD";
            buttonAddEmployee.UseVisualStyleBackColor = false;
            // 
            // AddEmployeeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddEmployee);
            Controls.Add(Logo);
            Controls.Add(labelNewEmployee);
            Controls.Add(buttonGoBack);
            Controls.Add(panelAddEmployee);
            Name = "AddEmployeeUC";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelAddEmployee;
        private RoundedItems.RoundLabel labelEmployees;
        private RoundedItems.RoundButton buttonGoBack;
        private Label labelNewEmployee;
        private PictureBox Logo;
        private RoundedItems.RoundButton buttonAddEmployee;
    }
}
