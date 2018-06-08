namespace COMP329_Milestone3
{
    partial class ViewRooms
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
            this.pn_Container = new System.Windows.Forms.Panel();
            this.lb_NoRoom = new System.Windows.Forms.Label();
            this.lb_AName = new System.Windows.Forms.Label();
            this.btn_NewRoom = new System.Windows.Forms.Button();
            this.btn_EditAccom = new System.Windows.Forms.Button();
            this.llb_Back = new System.Windows.Forms.LinkLabel();
            this.pn_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Container
            // 
            this.pn_Container.AutoScroll = true;
            this.pn_Container.Controls.Add(this.lb_NoRoom);
            this.pn_Container.Location = new System.Drawing.Point(31, 83);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(617, 313);
            this.pn_Container.TabIndex = 4;
            // 
            // lb_NoRoom
            // 
            this.lb_NoRoom.AutoSize = true;
            this.lb_NoRoom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoRoom.ForeColor = System.Drawing.Color.Red;
            this.lb_NoRoom.Location = new System.Drawing.Point(192, 141);
            this.lb_NoRoom.Name = "lb_NoRoom";
            this.lb_NoRoom.Size = new System.Drawing.Size(243, 33);
            this.lb_NoRoom.TabIndex = 28;
            this.lb_NoRoom.Text = "No Room is Available";
            this.lb_NoRoom.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lb_NoRoom.UseMnemonic = false;
            this.lb_NoRoom.Visible = false;
            // 
            // lb_AName
            // 
            this.lb_AName.AutoSize = true;
            this.lb_AName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AName.Location = new System.Drawing.Point(25, 21);
            this.lb_AName.Name = "lb_AName";
            this.lb_AName.Size = new System.Drawing.Size(266, 33);
            this.lb_AName.TabIndex = 1;
            this.lb_AName.Text = "Accommodation Name";
            this.lb_AName.UseMnemonic = false;
            // 
            // btn_NewRoom
            // 
            this.btn_NewRoom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewRoom.Location = new System.Drawing.Point(537, 402);
            this.btn_NewRoom.Name = "btn_NewRoom";
            this.btn_NewRoom.Size = new System.Drawing.Size(111, 37);
            this.btn_NewRoom.TabIndex = 26;
            this.btn_NewRoom.Text = "New Room";
            this.btn_NewRoom.UseVisualStyleBackColor = true;
            this.btn_NewRoom.Click += new System.EventHandler(this.btn_NewRoom_Click);
            // 
            // btn_EditAccom
            // 
            this.btn_EditAccom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditAccom.Location = new System.Drawing.Point(336, 402);
            this.btn_EditAccom.Name = "btn_EditAccom";
            this.btn_EditAccom.Size = new System.Drawing.Size(165, 37);
            this.btn_EditAccom.TabIndex = 27;
            this.btn_EditAccom.Text = "Edit Accommodation";
            this.btn_EditAccom.UseVisualStyleBackColor = true;
            this.btn_EditAccom.Click += new System.EventHandler(this.btn_EditAccom_Click);
            // 
            // llb_Back
            // 
            this.llb_Back.AutoSize = true;
            this.llb_Back.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Back.Location = new System.Drawing.Point(560, 29);
            this.llb_Back.Name = "llb_Back";
            this.llb_Back.Size = new System.Drawing.Size(46, 23);
            this.llb_Back.TabIndex = 28;
            this.llb_Back.TabStop = true;
            this.llb_Back.Text = "Back";
            this.llb_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Back_LinkClicked);
            // 
            // ViewRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.llb_Back);
            this.Controls.Add(this.btn_EditAccom);
            this.Controls.Add(this.btn_NewRoom);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.lb_AName);
            this.Name = "ViewRooms";
            this.Text = "View Rooms";
            this.Load += new System.EventHandler(this.ViewRooms_Load);
            this.pn_Container.ResumeLayout(false);
            this.pn_Container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn_Container;
        private System.Windows.Forms.Label lb_AName;
        private System.Windows.Forms.Button btn_NewRoom;
        private System.Windows.Forms.Button btn_EditAccom;
        private System.Windows.Forms.Label lb_NoRoom;
        private System.Windows.Forms.LinkLabel llb_Back;
    }
}