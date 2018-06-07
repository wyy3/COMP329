namespace COMP329_Milestone3
{
    partial class CompanyRegister
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
            this.lb_AName = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_PhoneNo = new System.Windows.Forms.Label();
            this.tb_CName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_PhoneNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.llb_Back = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_AName
            // 
            this.lb_AName.AutoSize = true;
            this.lb_AName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AName.Location = new System.Drawing.Point(59, 84);
            this.lb_AName.Name = "lb_AName";
            this.lb_AName.Size = new System.Drawing.Size(162, 33);
            this.lb_AName.TabIndex = 23;
            this.lb_AName.Text = "Register Page";
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(481, 341);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(93, 28);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(251, 237);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(323, 27);
            this.tb_Email.TabIndex = 3;
            this.tb_Email.Text = "test@gmail.com";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(251, 204);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(323, 27);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.Text = "TestCompany";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(145, 237);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(56, 23);
            this.lb_Email.TabIndex = 25;
            this.lb_Email.Text = "Email:";
            // 
            // lb_PhoneNo
            // 
            this.lb_PhoneNo.AutoSize = true;
            this.lb_PhoneNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneNo.Location = new System.Drawing.Point(111, 204);
            this.lb_PhoneNo.Name = "lb_PhoneNo";
            this.lb_PhoneNo.Size = new System.Drawing.Size(91, 23);
            this.lb_PhoneNo.TabIndex = 24;
            this.lb_PhoneNo.Text = "Password:";
            // 
            // tb_CName
            // 
            this.tb_CName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CName.Location = new System.Drawing.Point(251, 171);
            this.tb_CName.Name = "tb_CName";
            this.tb_CName.Size = new System.Drawing.Size(323, 27);
            this.tb_CName.TabIndex = 1;
            this.tb_CName.Text = "Test Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Company Name:";
            // 
            // tb_PhoneNO
            // 
            this.tb_PhoneNO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PhoneNO.Location = new System.Drawing.Point(251, 270);
            this.tb_PhoneNO.Name = "tb_PhoneNO";
            this.tb_PhoneNO.Size = new System.Drawing.Size(323, 27);
            this.tb_PhoneNO.TabIndex = 4;
            this.tb_PhoneNO.Text = "123456789";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Phone NO:";
            // 
            // llb_Back
            // 
            this.llb_Back.AutoSize = true;
            this.llb_Back.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Back.Location = new System.Drawing.Point(523, 49);
            this.llb_Back.Name = "llb_Back";
            this.llb_Back.Size = new System.Drawing.Size(51, 23);
            this.llb_Back.TabIndex = 7;
            this.llb_Back.TabStop = true;
            this.llb_Back.Text = "BACK";
            this.llb_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Back_LinkClicked);
            // 
            // CompanyRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.llb_Back);
            this.Controls.Add(this.tb_PhoneNO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_CName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_PhoneNo);
            this.Controls.Add(this.lb_AName);
            this.Name = "CompanyRegister";
            this.Text = "Company Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AName;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_PhoneNo;
        private System.Windows.Forms.TextBox tb_CName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_PhoneNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llb_Back;
    }
}