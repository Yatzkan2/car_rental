namespace project_oop_car_rental
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butt_login = new System.Windows.Forms.Button();
            this.password_input = new System.Windows.Forms.TextBox();
            this.lable_password = new System.Windows.Forms.Label();
            this.is_password_visible = new System.Windows.Forms.Button();
            this.userName_input = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.Label();
            this.butt_Reg = new System.Windows.Forms.Button();
            this.lbl_wrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butt_login
            // 
            this.butt_login.Location = new System.Drawing.Point(43, 96);
            this.butt_login.Name = "butt_login";
            this.butt_login.Size = new System.Drawing.Size(173, 27);
            this.butt_login.TabIndex = 0;
            this.butt_login.Text = "Login";
            this.butt_login.UseVisualStyleBackColor = true;
            this.butt_login.Click += new System.EventHandler(this.butt_login_Click);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(78, 70);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(138, 20);
            this.password_input.TabIndex = 1;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // lable_password
            // 
            this.lable_password.AutoSize = true;
            this.lable_password.Location = new System.Drawing.Point(12, 73);
            this.lable_password.Name = "lable_password";
            this.lable_password.Size = new System.Drawing.Size(56, 13);
            this.lable_password.TabIndex = 2;
            this.lable_password.Text = "Password:";
            // 
            // is_password_visible
            // 
            this.is_password_visible.Location = new System.Drawing.Point(222, 68);
            this.is_password_visible.Name = "is_password_visible";
            this.is_password_visible.Size = new System.Drawing.Size(111, 22);
            this.is_password_visible.TabIndex = 3;
            this.is_password_visible.Text = "Show Password";
            this.is_password_visible.UseVisualStyleBackColor = true;
            this.is_password_visible.Click += new System.EventHandler(this.is_password_visible_Click);
            // 
            // userName_input
            // 
            this.userName_input.Location = new System.Drawing.Point(78, 36);
            this.userName_input.Name = "userName_input";
            this.userName_input.Size = new System.Drawing.Size(138, 20);
            this.userName_input.TabIndex = 4;
            this.userName_input.TextChanged += new System.EventHandler(this.userName_input_TextChanged);
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(12, 39);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(60, 13);
            this.user_name.TabIndex = 5;
            this.user_name.Text = "User Name";
            // 
            // butt_Reg
            // 
            this.butt_Reg.Location = new System.Drawing.Point(240, 34);
            this.butt_Reg.Name = "butt_Reg";
            this.butt_Reg.Size = new System.Drawing.Size(75, 23);
            this.butt_Reg.TabIndex = 6;
            this.butt_Reg.Text = "Register";
            this.butt_Reg.UseVisualStyleBackColor = true;
            this.butt_Reg.Click += new System.EventHandler(this.butt_Reg_Click);
            // 
            // lbl_wrong
            // 
            this.lbl_wrong.AutoSize = true;
            this.lbl_wrong.ForeColor = System.Drawing.Color.Red;
            this.lbl_wrong.Location = new System.Drawing.Point(237, 103);
            this.lbl_wrong.Name = "lbl_wrong";
            this.lbl_wrong.Size = new System.Drawing.Size(78, 13);
            this.lbl_wrong.TabIndex = 7;
            this.lbl_wrong.Text = "*Wrong Details";
            this.lbl_wrong.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 136);
            this.Controls.Add(this.lbl_wrong);
            this.Controls.Add(this.butt_Reg);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.userName_input);
            this.Controls.Add(this.is_password_visible);
            this.Controls.Add(this.lable_password);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.butt_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_login;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label lable_password;
        private System.Windows.Forms.Button is_password_visible;
        private System.Windows.Forms.TextBox userName_input;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Button butt_Reg;
        private System.Windows.Forms.Label lbl_wrong;
    }
}

