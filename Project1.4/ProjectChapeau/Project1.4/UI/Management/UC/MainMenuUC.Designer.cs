using Project1._4.RoundedItems;

namespace Project1._4
{
    partial class MainMenuUC
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
            buttonToMenu = new RoundButton();
            buttonToEmployeeManagement = new RoundButton();
            Logo = new PictureBox();
            labelUserName = new RoundLabel();
            buttonToTableView = new RoundButton();
            labelLastMonth = new Label();
            labelThisMonth = new Label();
            labelLastMonthIncome = new Label();
            labelThisMonthIncome = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // buttonToMenu
            // 
            buttonToMenu.BackColor = Color.FromArgb(138, 210, 176);
            buttonToMenu.Cursor = Cursors.Hand;
            buttonToMenu.FlatAppearance.BorderSize = 0;
            buttonToMenu.FlatStyle = FlatStyle.Flat;
            buttonToMenu.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToMenu.Location = new Point(81, 496);
            buttonToMenu.Name = "buttonToMenu";
            buttonToMenu.Size = new Size(284, 73);
            buttonToMenu.TabIndex = 0;
            buttonToMenu.Text = "MENU";
            buttonToMenu.UseVisualStyleBackColor = false;
            buttonToMenu.Click += NavigateToMenu;
            // 
            // buttonToEmployeeManagement
            // 
            buttonToEmployeeManagement.BackColor = Color.FromArgb(138, 210, 176);
            buttonToEmployeeManagement.Cursor = Cursors.Hand;
            buttonToEmployeeManagement.FlatAppearance.BorderSize = 0;
            buttonToEmployeeManagement.FlatStyle = FlatStyle.Flat;
            buttonToEmployeeManagement.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToEmployeeManagement.Location = new Point(81, 360);
            buttonToEmployeeManagement.Name = "buttonToEmployeeManagement";
            buttonToEmployeeManagement.Size = new Size(284, 69);
            buttonToEmployeeManagement.TabIndex = 1;
            buttonToEmployeeManagement.Text = "EMPLOYEE MANAGEMENT";
            buttonToEmployeeManagement.UseVisualStyleBackColor = false;
            buttonToEmployeeManagement.Click += NavigateToEmployee;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.chapeagoeie;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(131, 66);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.BackColor = Color.FromArgb(255, 179, 71);
            labelUserName.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.Location = new Point(296, 21);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(86, 43);
            labelUserName.TabIndex = 3;
            labelUserName.Text = "{Name}";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonToTableView
            // 
            buttonToTableView.BackColor = Color.FromArgb(138, 210, 176);
            buttonToTableView.Cursor = Cursors.Hand;
            buttonToTableView.FlatAppearance.BorderSize = 0;
            buttonToTableView.FlatStyle = FlatStyle.Flat;
            buttonToTableView.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToTableView.Location = new Point(81, 218);
            buttonToTableView.Name = "buttonToTableView";
            buttonToTableView.Size = new Size(284, 69);
            buttonToTableView.TabIndex = 4;
            buttonToTableView.Text = "TABLE VIEW";
            buttonToTableView.UseVisualStyleBackColor = false;
            // 
            // labelLastMonth
            // 
            labelLastMonth.AutoSize = true;
            labelLastMonth.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastMonth.Location = new Point(58, 641);
            labelLastMonth.Name = "labelLastMonth";
            labelLastMonth.Size = new Size(145, 18);
            labelLastMonth.TabIndex = 5;
            labelLastMonth.Text = "Income last month";
            // 
            // labelThisMonth
            // 
            labelThisMonth.AutoSize = true;
            labelThisMonth.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelThisMonth.Location = new Point(237, 641);
            labelThisMonth.Name = "labelThisMonth";
            labelThisMonth.Size = new Size(145, 18);
            labelThisMonth.TabIndex = 6;
            labelThisMonth.Text = "Income this month";
            // 
            // labelLastMonthIncome
            // 
            labelLastMonthIncome.AutoSize = true;
            labelLastMonthIncome.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastMonthIncome.Location = new Point(58, 684);
            labelLastMonthIncome.Name = "labelLastMonthIncome";
            labelLastMonthIncome.Size = new Size(89, 18);
            labelLastMonthIncome.TabIndex = 7;
            labelLastMonthIncome.Text = "{income1}";
            // 
            // labelThisMonthIncome
            // 
            labelThisMonthIncome.AutoSize = true;
            labelThisMonthIncome.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelThisMonthIncome.Location = new Point(237, 684);
            labelThisMonthIncome.Name = "labelThisMonthIncome";
            labelThisMonthIncome.Size = new Size(89, 18);
            labelThisMonthIncome.TabIndex = 8;
            labelThisMonthIncome.Text = "{income2}";
            // 
            // MainMenuUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(labelThisMonthIncome);
            Controls.Add(labelLastMonthIncome);
            Controls.Add(labelThisMonth);
            Controls.Add(labelLastMonth);
            Controls.Add(buttonToTableView);
            Controls.Add(labelUserName);
            Controls.Add(buttonToEmployeeManagement);
            Controls.Add(buttonToMenu);
            Controls.Add(Logo);
            Name = "MainMenuUC";
            Size = new Size(414, 736);
            Load += MainMenuUC_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private TextBox textBox3;
        private RoundButton buttonToMenu;
        private RoundButton buttonToEmployeeManagement;
        private PictureBox Logo;
        private RoundLabel labelUserName;
        private RoundButton buttonToTableView;
        private Label labelLastMonth;
        private Label labelThisMonth;
        private Label labelLastMonthIncome;
        private Label labelThisMonthIncome;
    }
}
