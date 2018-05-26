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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NewAccommodation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EditAccom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pn_Container
            // 
            this.pn_Container.AutoScroll = true;
            this.pn_Container.Location = new System.Drawing.Point(31, 83);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(617, 313);
            this.pn_Container.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accommodation Name";
            // 
            // btn_NewAccommodation
            // 
            this.btn_NewAccommodation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewAccommodation.Location = new System.Drawing.Point(537, 402);
            this.btn_NewAccommodation.Name = "btn_NewAccommodation";
            this.btn_NewAccommodation.Size = new System.Drawing.Size(111, 37);
            this.btn_NewAccommodation.TabIndex = 26;
            this.btn_NewAccommodation.Text = "New Room";
            this.btn_NewAccommodation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(31, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 313);
            this.panel1.TabIndex = 4;
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
            // 
            // ViewRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.btn_EditAccom);
            this.Controls.Add(this.btn_NewAccommodation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.label1);
            this.Name = "ViewRooms";
            this.Text = "Company Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn_Container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NewAccommodation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EditAccom;
    }
}