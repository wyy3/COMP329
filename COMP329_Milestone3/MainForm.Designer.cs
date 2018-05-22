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
            this.pn_Search.Location = new System.Drawing.Point(52, 12);
            this.pn_Search.Name = "pn_Search";
            this.pn_Search.Size = new System.Drawing.Size(573, 56);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.pn_Search);
            this.Name = "MainForm";
            this.Text = "Accommodations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pn_Search.ResumeLayout(false);
            this.pn_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_CityName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel pn_Search;
        private System.Windows.Forms.Panel pn_Container;
    }
}

