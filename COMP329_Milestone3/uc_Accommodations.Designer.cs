namespace COMP329_Milestone3
{
    partial class Uc_Accommodations
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
            this.lb_AName = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_PhoneNO = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.btn_ViewDeal = new System.Windows.Forms.Button();
            this.lb_Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_AName
            // 
            this.lb_AName.AutoSize = true;
            this.lb_AName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AName.Location = new System.Drawing.Point(24, 10);
            this.lb_AName.Name = "lb_AName";
            this.lb_AName.Size = new System.Drawing.Size(266, 33);
            this.lb_AName.TabIndex = 1;
            this.lb_AName.Text = "Accommodation Name";
            this.lb_AName.UseMnemonic = false;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(27, 87);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(66, 21);
            this.lb_Address.TabIndex = 2;
            this.lb_Address.Text = "Address";
            // 
            // lb_PhoneNO
            // 
            this.lb_PhoneNO.AutoSize = true;
            this.lb_PhoneNO.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneNO.Location = new System.Drawing.Point(27, 108);
            this.lb_PhoneNO.Name = "lb_PhoneNO";
            this.lb_PhoneNO.Size = new System.Drawing.Size(78, 21);
            this.lb_PhoneNO.TabIndex = 3;
            this.lb_PhoneNO.Text = "Phone No";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(175, 108);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(48, 21);
            this.lb_Email.TabIndex = 4;
            this.lb_Email.Text = "Email";
            // 
            // btn_ViewDeal
            // 
            this.btn_ViewDeal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewDeal.Location = new System.Drawing.Point(398, 52);
            this.btn_ViewDeal.Name = "btn_ViewDeal";
            this.btn_ViewDeal.Size = new System.Drawing.Size(98, 32);
            this.btn_ViewDeal.TabIndex = 5;
            this.btn_ViewDeal.Text = "View Deal";
            this.btn_ViewDeal.UseVisualStyleBackColor = true;
            this.btn_ViewDeal.Click += new System.EventHandler(this.btn_ViewDeal_Click);
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Description.Location = new System.Drawing.Point(26, 52);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(99, 23);
            this.lb_Description.TabIndex = 6;
            this.lb_Description.Text = "Description";
            // 
            // Uc_Accommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.btn_ViewDeal);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_PhoneNO);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_AName);
            this.Name = "Uc_Accommodations";
            this.Size = new System.Drawing.Size(515, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AName;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_PhoneNO;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Button btn_ViewDeal;
        private System.Windows.Forms.Label lb_Description;
    }
}
