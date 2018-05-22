namespace COMP329_Milestone3
{
    partial class Rooms
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_CheckInDate = new System.Windows.Forms.DateTimePicker();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_AName
            // 
            this.lb_AName.AutoSize = true;
            this.lb_AName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AName.Location = new System.Drawing.Point(36, 26);
            this.lb_AName.Name = "lb_AName";
            this.lb_AName.Size = new System.Drawing.Size(266, 33);
            this.lb_AName.TabIndex = 0;
            this.lb_AName.Text = "Accommodation Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check-in:";
            // 
            // dtp_CheckInDate
            // 
            this.dtp_CheckInDate.Location = new System.Drawing.Point(446, 35);
            this.dtp_CheckInDate.Name = "dtp_CheckInDate";
            this.dtp_CheckInDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_CheckInDate.TabIndex = 2;
            // 
            // pn_Container
            // 
            this.pn_Container.AutoScroll = true;
            this.pn_Container.Location = new System.Drawing.Point(29, 100);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(617, 313);
            this.pn_Container.TabIndex = 3;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.dtp_CheckInDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_AName);
            this.Name = "Rooms";
            this.Text = "Accommodation Name";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_CheckInDate;
        private System.Windows.Forms.Panel pn_Container;
    }
}

