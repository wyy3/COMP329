namespace COMP329_Milestone3
{
    partial class Uc_Rooms
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
            this.lb_RName = new System.Windows.Forms.Label();
            this.lb_Description = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.btn_Book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_RName
            // 
            this.lb_RName.AutoSize = true;
            this.lb_RName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RName.Location = new System.Drawing.Point(15, 10);
            this.lb_RName.Name = "lb_RName";
            this.lb_RName.Size = new System.Drawing.Size(150, 33);
            this.lb_RName.TabIndex = 2;
            this.lb_RName.Text = "Room Name";
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lb_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Description.Location = new System.Drawing.Point(17, 43);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(83, 19);
            this.lb_Description.TabIndex = 7;
            this.lb_Description.Text = "Description";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Price.Location = new System.Drawing.Point(249, 24);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(111, 29);
            this.lb_Price.TabIndex = 8;
            this.lb_Price.Text = "NZ $25.59";
            // 
            // btn_Book
            // 
            this.btn_Book.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.Location = new System.Drawing.Point(366, 21);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(98, 32);
            this.btn_Book.TabIndex = 9;
            this.btn_Book.Text = "Book Now";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // Uc_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.lb_RName);
            this.Name = "Uc_Rooms";
            this.Size = new System.Drawing.Size(486, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_RName;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Button btn_Book;
    }
}
