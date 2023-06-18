namespace Project1._4
{
    partial class tableGereseveerdControl
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
            lblNaamControl = new Label();
            lblDatumControl = new Label();
            lblTijdControl = new Label();
            lblNummerControl = new Label();
            lblOpmerkingControl = new Label();
            btnOpslaanControl = new Button();
            txtNaamGegevens = new TextBox();
            txtDatumGegevens = new TextBox();
            txtTijdGegevens = new TextBox();
            txtNummerGegevens = new TextBox();
            txtOpmerkingGegevens = new TextBox();
            lblGegevens = new Label();
            SuspendLayout();
            // 
            // lblNaamControl
            // 
            lblNaamControl.AutoSize = true;
            lblNaamControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNaamControl.Location = new Point(62, 93);
            lblNaamControl.Name = "lblNaamControl";
            lblNaamControl.Size = new Size(48, 14);
            lblNaamControl.TabIndex = 0;
            lblNaamControl.Text = "Naam :";
            // 
            // lblDatumControl
            // 
            lblDatumControl.AutoSize = true;
            lblDatumControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatumControl.Location = new Point(62, 140);
            lblDatumControl.Name = "lblDatumControl";
            lblDatumControl.Size = new Size(56, 14);
            lblDatumControl.TabIndex = 1;
            lblDatumControl.Text = "Datum :";
            // 
            // lblTijdControl
            // 
            lblTijdControl.AutoSize = true;
            lblTijdControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTijdControl.Location = new Point(62, 186);
            lblTijdControl.Name = "lblTijdControl";
            lblTijdControl.Size = new Size(41, 14);
            lblTijdControl.TabIndex = 2;
            lblTijdControl.Text = "Tijd : ";
            // 
            // lblNummerControl
            // 
            lblNummerControl.AutoSize = true;
            lblNummerControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNummerControl.Location = new Point(62, 236);
            lblNummerControl.Name = "lblNummerControl";
            lblNummerControl.Size = new Size(65, 14);
            lblNummerControl.TabIndex = 3;
            lblNummerControl.Text = "Nummer :";
            // 
            // lblOpmerkingControl
            // 
            lblOpmerkingControl.AutoSize = true;
            lblOpmerkingControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpmerkingControl.Location = new Point(62, 290);
            lblOpmerkingControl.Name = "lblOpmerkingControl";
            lblOpmerkingControl.Size = new Size(81, 14);
            lblOpmerkingControl.TabIndex = 4;
            lblOpmerkingControl.Text = "Opmerking :";
            // 
            // btnOpslaanControl
            // 
            btnOpslaanControl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpslaanControl.Location = new Point(104, 366);
            btnOpslaanControl.Name = "btnOpslaanControl";
            btnOpslaanControl.Size = new Size(155, 37);
            btnOpslaanControl.TabIndex = 6;
            btnOpslaanControl.Text = "Opslaan";
            btnOpslaanControl.UseVisualStyleBackColor = true;
            btnOpslaanControl.Click += Opslaan;
            // 
            // txtNaamGegevens
            // 
            txtNaamGegevens.Location = new Point(191, 85);
            txtNaamGegevens.Name = "txtNaamGegevens";
            txtNaamGegevens.Size = new Size(100, 23);
            txtNaamGegevens.TabIndex = 7;
            // 
            // txtDatumGegevens
            // 
            txtDatumGegevens.Location = new Point(191, 132);
            txtDatumGegevens.Name = "txtDatumGegevens";
            txtDatumGegevens.Size = new Size(100, 23);
            txtDatumGegevens.TabIndex = 8;
            // 
            // txtTijdGegevens
            // 
            txtTijdGegevens.Location = new Point(191, 178);
            txtTijdGegevens.Name = "txtTijdGegevens";
            txtTijdGegevens.Size = new Size(100, 23);
            txtTijdGegevens.TabIndex = 9;
            // 
            // txtNummerGegevens
            // 
            txtNummerGegevens.Location = new Point(191, 228);
            txtNummerGegevens.Name = "txtNummerGegevens";
            txtNummerGegevens.Size = new Size(100, 23);
            txtNummerGegevens.TabIndex = 10;
            // 
            // txtOpmerkingGegevens
            // 
            txtOpmerkingGegevens.Location = new Point(191, 282);
            txtOpmerkingGegevens.Name = "txtOpmerkingGegevens";
            txtOpmerkingGegevens.Size = new Size(100, 23);
            txtOpmerkingGegevens.TabIndex = 11;
            // 
            // lblGegevens
            // 
            lblGegevens.AutoSize = true;
            lblGegevens.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblGegevens.Location = new Point(104, 27);
            lblGegevens.Name = "lblGegevens";
            lblGegevens.Size = new Size(162, 33);
            lblGegevens.TabIndex = 12;
            lblGegevens.Text = "GEGEVENS";
            // 
            // tableGereseveerdControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblGegevens);
            Controls.Add(txtOpmerkingGegevens);
            Controls.Add(txtNummerGegevens);
            Controls.Add(txtTijdGegevens);
            Controls.Add(txtDatumGegevens);
            Controls.Add(txtNaamGegevens);
            Controls.Add(btnOpslaanControl);
            Controls.Add(lblOpmerkingControl);
            Controls.Add(lblNummerControl);
            Controls.Add(lblTijdControl);
            Controls.Add(lblDatumControl);
            Controls.Add(lblNaamControl);
            Name = "tableGereseveerdControl";
            Size = new Size(367, 445);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaamControl;
        private Label lblDatumControl;
        private Label lblTijdControl;
        private Label lblNummerControl;
        private Label lblOpmerkingControl;
        private Button btnOpslaanControl;
        private TextBox txtNaamGegevens;
        private TextBox txtDatumGegevens;
        private TextBox txtTijdGegevens;
        private TextBox txtNummerGegevens;
        private TextBox txtOpmerkingGegevens;
        private Label lblGegevens;
    }
}
