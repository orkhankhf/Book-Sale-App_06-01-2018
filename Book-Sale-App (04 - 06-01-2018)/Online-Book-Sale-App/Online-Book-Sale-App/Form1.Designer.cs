namespace Online_Book_Sale_App
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
            this.adminpanel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminpanel_btn
            // 
            this.adminpanel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adminpanel_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.adminpanel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminpanel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpanel_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.adminpanel_btn.Location = new System.Drawing.Point(12, 12);
            this.adminpanel_btn.Name = "adminpanel_btn";
            this.adminpanel_btn.Size = new System.Drawing.Size(94, 32);
            this.adminpanel_btn.TabIndex = 0;
            this.adminpanel_btn.Text = "Adminpanel";
            this.adminpanel_btn.UseVisualStyleBackColor = false;
            this.adminpanel_btn.Click += new System.EventHandler(this.adminpanel_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.adminpanel_btn);
            this.Name = "Form1";
            this.Text = "Online Book Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.ResumeLayout(false);

        }
        
        

        #endregion

        private System.Windows.Forms.Button adminpanel_btn;
    }
}

