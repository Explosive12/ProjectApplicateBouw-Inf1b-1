namespace Project1._4
{
    partial class ManagerViewForm
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
            MenuPannel = new Panel();
            GoToChangeStockPanel = new Button();
            GoToChangeEmployeePanel = new Button();
            GoToChangeMenuPanel = new Button();
            ChangeMenuPanel = new Panel();
            MenuItemsListView = new ListView();
            ChangeEmployeePanel = new Panel();
            textBoxPassword = new TextBox();
            comboBoxEmployeeFunction = new ComboBox();
            textBoxUserName = new TextBox();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            labelFunction = new Label();
            labelPassword = new Label();
            labelUserName = new Label();
            labelName = new Label();
            labelId = new Label();
            buttonDeleteEmployee = new Button();
            buttonAddEmployee = new Button();
            buttonEmployeeUpdate = new Button();
            listViewEmployees = new ListView();
            EmployeeName = new ColumnHeader();
            EmployeeUserName = new ColumnHeader();
            EmployeeFunction = new ColumnHeader();
            ChangeStockPanel = new Panel();
            MenuPannel.SuspendLayout();
            ChangeMenuPanel.SuspendLayout();
            ChangeEmployeePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPannel
            // 
            MenuPannel.Controls.Add(GoToChangeStockPanel);
            MenuPannel.Controls.Add(GoToChangeEmployeePanel);
            MenuPannel.Controls.Add(GoToChangeMenuPanel);
            MenuPannel.Location = new Point(0, 0);
            MenuPannel.Name = "MenuPannel";
            MenuPannel.Size = new Size(1456, 1038);
            MenuPannel.TabIndex = 2;
            // 
            // GoToChangeStockPanel
            // 
            GoToChangeStockPanel.Location = new Point(1045, 478);
            GoToChangeStockPanel.Name = "GoToChangeStockPanel";
            GoToChangeStockPanel.Size = new Size(221, 162);
            GoToChangeStockPanel.TabIndex = 2;
            GoToChangeStockPanel.Text = "Change Stock";
            GoToChangeStockPanel.UseVisualStyleBackColor = true;
            // 
            // GoToChangeEmployeePanel
            // 
            GoToChangeEmployeePanel.Location = new Point(663, 478);
            GoToChangeEmployeePanel.Name = "GoToChangeEmployeePanel";
            GoToChangeEmployeePanel.Size = new Size(221, 162);
            GoToChangeEmployeePanel.TabIndex = 1;
            GoToChangeEmployeePanel.Text = "Employees";
            GoToChangeEmployeePanel.UseVisualStyleBackColor = true;
            GoToChangeEmployeePanel.Click += GoToChangeEmployeePanel_Click;
            // 
            // GoToChangeMenuPanel
            // 
            GoToChangeMenuPanel.Location = new Point(283, 478);
            GoToChangeMenuPanel.Name = "GoToChangeMenuPanel";
            GoToChangeMenuPanel.Size = new Size(221, 162);
            GoToChangeMenuPanel.TabIndex = 0;
            GoToChangeMenuPanel.Text = "Change Menu";
            GoToChangeMenuPanel.UseVisualStyleBackColor = true;
            // 
            // ChangeMenuPanel
            // 
            ChangeMenuPanel.Controls.Add(MenuItemsListView);
            ChangeMenuPanel.Location = new Point(0, 0);
            ChangeMenuPanel.Name = "ChangeMenuPanel";
            ChangeMenuPanel.Size = new Size(1440, 1024);
            ChangeMenuPanel.TabIndex = 3;
            // 
            // MenuItemsListView
            // 
            MenuItemsListView.Location = new Point(89, 130);
            MenuItemsListView.Name = "MenuItemsListView";
            MenuItemsListView.Size = new Size(359, 309);
            MenuItemsListView.TabIndex = 0;
            MenuItemsListView.UseCompatibleStateImageBehavior = false;
            // 
            // ChangeEmployeePanel
            // 
            ChangeEmployeePanel.Controls.Add(textBoxPassword);
            ChangeEmployeePanel.Controls.Add(comboBoxEmployeeFunction);
            ChangeEmployeePanel.Controls.Add(textBoxUserName);
            ChangeEmployeePanel.Controls.Add(textBoxName);
            ChangeEmployeePanel.Controls.Add(textBoxId);
            ChangeEmployeePanel.Controls.Add(labelFunction);
            ChangeEmployeePanel.Controls.Add(labelPassword);
            ChangeEmployeePanel.Controls.Add(labelUserName);
            ChangeEmployeePanel.Controls.Add(labelName);
            ChangeEmployeePanel.Controls.Add(labelId);
            ChangeEmployeePanel.Controls.Add(buttonDeleteEmployee);
            ChangeEmployeePanel.Controls.Add(buttonAddEmployee);
            ChangeEmployeePanel.Controls.Add(buttonEmployeeUpdate);
            ChangeEmployeePanel.Controls.Add(listViewEmployees);
            ChangeEmployeePanel.Location = new Point(0, 0);
            ChangeEmployeePanel.Name = "ChangeEmployeePanel";
            ChangeEmployeePanel.Size = new Size(1440, 1024);
            ChangeEmployeePanel.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(152, 524);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(121, 23);
            textBoxPassword.TabIndex = 14;
            // 
            // comboBoxEmployeeFunction
            // 
            comboBoxEmployeeFunction.FormattingEnabled = true;
            comboBoxEmployeeFunction.Items.AddRange(new object[] { "Waitress", "Chef", "Bartender", "Manager" });
            comboBoxEmployeeFunction.Location = new Point(152, 564);
            comboBoxEmployeeFunction.Name = "comboBoxEmployeeFunction";
            comboBoxEmployeeFunction.Size = new Size(121, 23);
            comboBoxEmployeeFunction.TabIndex = 13;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(152, 486);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(121, 23);
            textBoxUserName.TabIndex = 11;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(152, 452);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 23);
            textBoxName.TabIndex = 10;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(152, 416);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(41, 23);
            textBoxId.TabIndex = 9;
            // 
            // labelFunction
            // 
            labelFunction.AutoSize = true;
            labelFunction.Location = new Point(38, 567);
            labelFunction.Name = "labelFunction";
            labelFunction.Size = new Size(54, 15);
            labelFunction.TabIndex = 8;
            labelFunction.Text = "Function";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(38, 532);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(38, 489);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(60, 15);
            labelUserName.TabIndex = 6;
            labelUserName.Text = "Username";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(38, 455);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(38, 419);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 4;
            labelId.Text = "Id";
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Location = new Point(471, 304);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(297, 114);
            buttonDeleteEmployee.TabIndex = 3;
            buttonDeleteEmployee.Text = "Delete";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            buttonDeleteEmployee.Click += buttonDeleteEmployee_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(471, 25);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(297, 114);
            buttonAddEmployee.TabIndex = 2;
            buttonAddEmployee.Text = "Add";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // buttonEmployeeUpdate
            // 
            buttonEmployeeUpdate.Location = new Point(471, 171);
            buttonEmployeeUpdate.Name = "buttonEmployeeUpdate";
            buttonEmployeeUpdate.Size = new Size(297, 114);
            buttonEmployeeUpdate.TabIndex = 1;
            buttonEmployeeUpdate.Text = "Update";
            buttonEmployeeUpdate.UseVisualStyleBackColor = true;
            buttonEmployeeUpdate.Click += buttonEmployeeUpdate_Click;
            // 
            // listViewEmployees
            // 
            listViewEmployees.BorderStyle = BorderStyle.FixedSingle;
            listViewEmployees.Columns.AddRange(new ColumnHeader[] { EmployeeName, EmployeeUserName, EmployeeFunction });
            listViewEmployees.Location = new Point(23, 25);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(393, 357);
            listViewEmployees.TabIndex = 0;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            listViewEmployees.View = View.Details;
            listViewEmployees.SelectedIndexChanged += listViewEmployees_SelectedIndexChanged;
            // 
            // EmployeeName
            // 
            EmployeeName.Text = "Name";
            EmployeeName.Width = 200;
            // 
            // EmployeeUserName
            // 
            EmployeeUserName.Text = "UserName";
            EmployeeUserName.Width = 100;
            // 
            // EmployeeFunction
            // 
            EmployeeFunction.Text = "Function";
            EmployeeFunction.Width = 100;
            // 
            // ChangeStockPanel
            // 
            ChangeStockPanel.Location = new Point(0, 0);
            ChangeStockPanel.Name = "ChangeStockPanel";
            ChangeStockPanel.Size = new Size(1440, 1024);
            ChangeStockPanel.TabIndex = 3;
            // 
            // ManagerViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChangeEmployeePanel);
            Controls.Add(ChangeMenuPanel);
            Controls.Add(MenuPannel);
            Controls.Add(ChangeStockPanel);
            Name = "ManagerViewForm";
            Size = new Size(1440, 1024);
            Load += ManagerViewForm_Load;
            MenuPannel.ResumeLayout(false);
            ChangeMenuPanel.ResumeLayout(false);
            ChangeEmployeePanel.ResumeLayout(false);
            ChangeEmployeePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPannel;
        private Button GoToChangeEmployeePanel;
        private Button GoToChangeMenuPanel;
        private Button GoToChangeStockPanel;
        private Panel ChangeMenuPanel;
        private Panel ChangeEmployeePanel;
        private Panel ChangeStockPanel;
        private ListView MenuItemsListView;
        private ListView listViewEmployees;
        private ColumnHeader EmployeeName;
        private ColumnHeader EmployeeUserName;
        private ColumnHeader EmployeeFunction;
        private Button buttonEmployeeUpdate;
        private Button buttonDeleteEmployee;
        private Button buttonAddEmployee;
        private Label labelFunction;
        private Label labelPassword;
        private Label labelUserName;
        private Label labelName;
        private Label labelId;
        private TextBox textBoxId;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBoxUserName;
        private TextBox textBoxName;
        private ComboBox comboBoxEmployeeFunction;
        private TextBox textBoxPassword;
    }
}
