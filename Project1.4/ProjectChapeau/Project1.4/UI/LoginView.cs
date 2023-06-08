using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }
        public void Getlogin()
        {

        }
        public string GetUsername()
        {
            throw new NotImplementedException();
        }

        public string GetPassword()
        {
            throw new NotImplementedException();
        }
        public void ForgetPassword()
        {

        }

        public void ManagerView()
        {
            throw new NotImplementedException();
        }

        public void WaitressView()
        {
            throw new NotImplementedException();
        }

        public void BartenderView()
        {
            throw new NotImplementedException();
        }

        public void ChefView()
        {
            throw new NotImplementedException();
        }


        private void InitializeComponent()
        {
            txtInlogNaam = new TextBox();
            txtWachtwoord = new TextBox();
            lblUsername = new Label();
            label2 = new Label();
            btnLoginHandheld = new Button();
            lblForgotPassword = new Label();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtInlogNaam
            // 
            txtInlogNaam.Location = new Point(190, 325);
            txtInlogNaam.Name = "txtInlogNaam";
            txtInlogNaam.Size = new Size(100, 23);
            txtInlogNaam.TabIndex = 1;
            // 
            // txtWachtwoord
            // 
            txtWachtwoord.Location = new Point(190, 383);
            txtWachtwoord.Name = "txtWachtwoord";
            txtWachtwoord.Size = new Size(100, 23);
            txtWachtwoord.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(78, 325);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(101, 19);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 387);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
            // 
            // btnLoginHandheld
            // 
            btnLoginHandheld.BackColor = Color.FromArgb(138, 210, 176);
            btnLoginHandheld.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginHandheld.ForeColor = SystemColors.ControlText;
            btnLoginHandheld.Location = new Point(133, 453);
            btnLoginHandheld.Name = "btnLoginHandheld";
            btnLoginHandheld.Size = new Size(118, 46);
            btnLoginHandheld.TabIndex = 5;
            btnLoginHandheld.Text = "Login";
            btnLoginHandheld.UseMnemonic = false;
            btnLoginHandheld.UseVisualStyleBackColor = false;
            btnLoginHandheld.Click += btnLoginHandheld_Click;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblForgotPassword.Location = new Point(133, 514);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(111, 14);
            lblForgotPassword.TabIndex = 6;
            lblForgotPassword.Text = "Forgot password";
            lblForgotPassword.TextAlign = ContentAlignment.MiddleCenter;
            lblForgotPassword.UseMnemonic = false;
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chapeagoeie;
            pictureBox1.Location = new Point(78, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 167);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 697);
            Controls.Add(pictureBox1);
            Controls.Add(lblForgotPassword);
            Controls.Add(btnLoginHandheld);
            Controls.Add(label2);
            Controls.Add(lblUsername);
            Controls.Add(txtWachtwoord);
            Controls.Add(txtInlogNaam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            Text = "Login";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLoginHandheld_Click(object sender, EventArgs e)
        {
            Getlogin();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword();
        }
    }
}
