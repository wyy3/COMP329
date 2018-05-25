namespace COMP329_Milestone3
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CityName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pn_Search = new System.Windows.Forms.Panel();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.llb_SignIn = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.llb_Register = new System.Windows.Forms.LinkLabel();
            this.pn_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // tb_CityName
            // 
            this.tb_CityName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CityName.Location = new System.Drawing.Point(139, 12);
            this.tb_CityName.Name = "tb_CityName";
            this.tb_CityName.Size = new System.Drawing.Size(247, 31);
            this.tb_CityName.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(403, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 28);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pn_Search
            // 
            this.pn_Search.Controls.Add(this.btn_Search);
            this.pn_Search.Controls.Add(this.label1);
            this.pn_Search.Controls.Add(this.tb_CityName);
            this.pn_Search.Location = new System.Drawing.Point(47, 51);
            this.pn_Search.Name = "pn_Search";
            this.pn_Search.Size = new System.Drawing.Size(573, 47);
            this.pn_Search.TabIndex = 3;
            // 
            // pn_Container
            // 
            this.pn_Container.AutoScroll = true;
            this.pn_Container.Location = new System.Drawing.Point(22, 104);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(627, 319);
            this.pn_Container.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operator:";
            // 
            // llb_SignIn
            // 
            this.llb_SignIn.AutoSize = true;
            this.llb_SignIn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_SignIn.Location = new System.Drawing.Point(475, 25);
            this.llb_SignIn.Name = "llb_SignIn";
            this.llb_SignIn.Size = new System.Drawing.Size(60, 23);
            this.llb_SignIn.TabIndex = 5;
            this.llb_SignIn.TabStop = true;
            this.llb_SignIn.Text = "Sign in";
            this.llb_SignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_SignIn_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "/";
            // 
            // llb_Register
            // 
            this.llb_Register.AutoSize = true;
            this.llb_Register.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Register.Location = new System.Drawing.Point(564, 25);
            this.llb_Register.Name = "llb_Register";
            this.llb_Register.Size = new System.Drawing.Size(72, 23);
            this.llb_Register.TabIndex = 7;
            this.llb_Register.TabStop = true;
            this.llb_Register.Text = "Register";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.llb_Register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.llb_SignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.pn_Search);
            this.Name = "MainForm";
            this.Text = "Accommodations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pn_Search.ResumeLayout(false);
            this.pn_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_CityName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel pn_Search;
        private System.Windows.Forms.Panel pn_Container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llb_SignIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llb_Register;
    }
}

