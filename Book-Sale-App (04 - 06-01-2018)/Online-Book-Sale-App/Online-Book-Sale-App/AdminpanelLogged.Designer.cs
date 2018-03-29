namespace Online_Book_Sale_App
{
    partial class AdminpanelLogged
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
            this.button1 = new System.Windows.Forms.Button();
            this.add_book_btn = new System.Windows.Forms.Button();
            this.delete_book_btn = new System.Windows.Forms.Button();
            this.update_book_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(55, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_book_btn
            // 
            this.add_book_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.add_book_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.add_book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_book_btn.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_book_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.add_book_btn.Location = new System.Drawing.Point(12, 12);
            this.add_book_btn.Name = "add_book_btn";
            this.add_book_btn.Size = new System.Drawing.Size(348, 32);
            this.add_book_btn.TabIndex = 1;
            this.add_book_btn.Text = "Add Book";
            this.add_book_btn.UseVisualStyleBackColor = false;
            this.add_book_btn.Click += new System.EventHandler(this.add_book_btn_Click);
            // 
            // delete_book_btn
            // 
            this.delete_book_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.delete_book_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.delete_book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_book_btn.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_book_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.delete_book_btn.Location = new System.Drawing.Point(12, 63);
            this.delete_book_btn.Name = "delete_book_btn";
            this.delete_book_btn.Size = new System.Drawing.Size(348, 32);
            this.delete_book_btn.TabIndex = 2;
            this.delete_book_btn.Text = "Remove Book";
            this.delete_book_btn.UseVisualStyleBackColor = false;
            this.delete_book_btn.Click += new System.EventHandler(this.delete_book_btn_Click);
            // 
            // update_book_btn
            // 
            this.update_book_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.update_book_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.update_book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_book_btn.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_book_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.update_book_btn.Location = new System.Drawing.Point(12, 114);
            this.update_book_btn.Name = "update_book_btn";
            this.update_book_btn.Size = new System.Drawing.Size(348, 32);
            this.update_book_btn.TabIndex = 3;
            this.update_book_btn.Text = "Update Book";
            this.update_book_btn.UseVisualStyleBackColor = false;
            this.update_book_btn.Click += new System.EventHandler(this.update_book_btn_Click);
            // 
            // AdminpanelLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(372, 298);
            this.Controls.Add(this.update_book_btn);
            this.Controls.Add(this.delete_book_btn);
            this.Controls.Add(this.add_book_btn);
            this.Controls.Add(this.button1);
            this.Name = "AdminpanelLogged";
            this.Text = "Adminpanel";
            this.Load += new System.EventHandler(this.AdminpanelLogged_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_book_btn;
        private System.Windows.Forms.Button delete_book_btn;
        private System.Windows.Forms.Button update_book_btn;
    }
}