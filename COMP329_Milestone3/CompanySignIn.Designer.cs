namespace COMP329_Milestone3
{
    partial class CompanySignIn
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
            this.btn_Signin = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_PhoneNo = new System.Windows.Forms.Label();
            this.lb_AName = new System.Windows.Forms.Label();
            this.llb_Back = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_Signin
            // 
            this.btn_Signin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signin.Location = new System.Drawing.Point(474, 314);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(93, 28);
            this.btn_Signin.TabIndex = 21;
            this.btn_Signin.Text = "Sign in";
            this.btn_Signin.UseVisualStyleBackColor = true;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(334, 314);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(93, 28);
            this.btn_Register.TabIndex = 20;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(244, 198);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(323, 27);
            this.tb_Email.TabIndex = 19;
            this.tb_Email.Text = "test@gmail.com";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(244, 255);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(323, 27);
            this.tb_Password.TabIndex = 18;
            this.tb_Password.Text = "0220708002";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(138, 198);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(56, 23);
            this.lb_Email.TabIndex = 17;
            this.lb_Email.Text = "Email:";
            // 
            // lb_PhoneNo
            // 
            this.lb_PhoneNo.AutoSize = true;
            this.lb_PhoneNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneNo.Location = new System.Drawing.Point(104, 255);
            this.lb_PhoneNo.Name = "lb_PhoneNo";
            this.lb_PhoneNo.Size = new System.Drawing.Size(91, 23);
            this.lb_PhoneNo.TabIndex = 16;
            this.lb_PhoneNo.Text = "Password:";
            // 
            // lb_AName
            // 
            this.lb_AName.AutoSize = true;
            this.lb_AName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AName.Location = new System.Drawing.Point(65, 96);
            this.lb_AName.Name = "lb_AName";
            this.lb_AName.Size = new System.Drawing.Size(190, 33);
            this.lb_AName.TabIndex = 22;
            this.lb_AName.Text = "Operator Sign in";
            // 
            // llb_Back
            // 
            this.llb_Back.AutoSize = true;
            this.llb_Back.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Back.Location = new System.Drawing.Point(507, 51);
            this.llb_Back.Name = "llb_Back";
            this.llb_Back.Size = new System.Drawing.Size(51, 23);
            this.llb_Back.TabIndex = 23;
            this.llb_Back.TabStop = true;
            this.llb_Back.Text = "BACK";
            this.llb_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Back_LinkClicked);
            // 
            // CompanySignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.llb_Back);
            this.Controls.Add(this.lb_AName);
            this.Controls.Add(this.btn_Signin);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_PhoneNo);
            this.Name = "CompanySignIn";
            this.Text = "Company Sign in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Signin;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_PhoneNo;
        private System.Windows.Forms.Label lb_AName;
        private System.Windows.Forms.LinkLabel llb_Back;
    }
}