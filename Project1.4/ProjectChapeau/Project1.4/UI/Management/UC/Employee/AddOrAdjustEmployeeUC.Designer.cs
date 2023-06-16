using Project1._4.RoundedItems;

namespace Project1._4.UI.Management.UC
{
    partial class AddOrAdjustEmployeeUC
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
            buttonGoBack = new RoundButton();
            labelEmployeeChanges = new Label();
            Logo = new PictureBox();
            buttonAddAdjustEmployee = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panelAddEmployee
            // 
            panelAddEmployee.AutoScroll = true;
            panelAddEmployee.BackColor = SystemColors.Window;
            panelAddEmployee.Location = new Point(36, 163);
            panelAddEmployee.Name = "panelAddEmployee";
            panelAddEmployee.Size = new Size(357, 449);
            panelAddEmployee.TabIndex = 13;
            // 
            // buttonGoBack
            // 
            buttonGoBack.BackColor = Color.FromArgb(255, 179, 71);
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
            buttonGoBack.Click += NavigateToEmployee;
            // 
            // labelEmployeeChanges
            // 
            labelEmployeeChanges.AutoSize = true;
            labelEmployeeChanges.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmployeeChanges.Location = new Point(30, 121);
            labelEmployeeChanges.Name = "labelEmployeeChanges";
            labelEmployeeChanges.Size = new Size(191, 39);
            labelEmployeeChanges.TabIndex = 15;
            labelEmployeeChanges.Text = "EMPLOYEE";
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
            // buttonAddAdjustEmployee
            // 
            buttonAddAdjustEmployee.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddAdjustEmployee.Cursor = Cursors.Hand;
            buttonAddAdjustEmployee.FlatAppearance.BorderSize = 0;
            buttonAddAdjustEmployee.FlatStyle = FlatStyle.Flat;
            buttonAddAdjustEmployee.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddAdjustEmployee.Location = new Point(36, 633);
            buttonAddAdjustEmployee.Name = "buttonAddAdjustEmployee";
            buttonAddAdjustEmployee.Size = new Size(120, 35);
            buttonAddAdjustEmployee.TabIndex = 17;
            buttonAddAdjustEmployee.Text = "ADD";
            buttonAddAdjustEmployee.UseVisualStyleBackColor = false;
            buttonAddAdjustEmployee.Click += AddAdjustEmployee_Click;
            // 
            // AddOrAdjustEmployeeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(buttonAddAdjustEmployee);
            Controls.Add(Logo);
            Controls.Add(labelEmployeeChanges);
            Controls.Add(buttonGoBack);
            Controls.Add(panelAddEmployee);
            Name = "AddOrAdjustEmployeeUC";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelAddEmployee;
        private RoundLabel labelEmployees;
        private RoundButton buttonGoBack;
        private Label labelEmployeeChanges;
        private PictureBox Logo;
        private RoundButton buttonAddAdjustEmployee;
    }
}
