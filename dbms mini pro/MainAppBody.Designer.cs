namespace dbms_mini_pro
{
    partial class MainAppBody
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
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.TenantButton = new System.Windows.Forms.Button();
            this.OthersButton = new System.Windows.Forms.Button();
            this.OwnerLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "APARTMENT MANAGEMENT SYSTEM";
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AdminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginButton.Location = new System.Drawing.Point(138, 175);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(200, 49);
            this.AdminLoginButton.TabIndex = 1;
            this.AdminLoginButton.Text = "ADMIN LOGIN";
            this.AdminLoginButton.UseVisualStyleBackColor = false;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // TenantButton
            // 
            this.TenantButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TenantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantButton.Location = new System.Drawing.Point(138, 334);
            this.TenantButton.Name = "TenantButton";
            this.TenantButton.Size = new System.Drawing.Size(200, 49);
            this.TenantButton.TabIndex = 2;
            this.TenantButton.Text = "TENANT ";
            this.TenantButton.UseVisualStyleBackColor = false;
            this.TenantButton.Click += new System.EventHandler(this.TenantButton_Click);
            // 
            // OthersButton
            // 
            this.OthersButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OthersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersButton.Location = new System.Drawing.Point(138, 414);
            this.OthersButton.Name = "OthersButton";
            this.OthersButton.Size = new System.Drawing.Size(200, 49);
            this.OthersButton.TabIndex = 3;
            this.OthersButton.Text = "PUBLIC";
            this.OthersButton.UseVisualStyleBackColor = false;
            this.OthersButton.Click += new System.EventHandler(this.OthersButton_Click);
            // 
            // OwnerLoginButton
            // 
            this.OwnerLoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OwnerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerLoginButton.Location = new System.Drawing.Point(138, 253);
            this.OwnerLoginButton.Name = "OwnerLoginButton";
            this.OwnerLoginButton.Size = new System.Drawing.Size(200, 49);
            this.OwnerLoginButton.TabIndex = 4;
            this.OwnerLoginButton.Text = "OWNER LOGIN";
            this.OwnerLoginButton.UseVisualStyleBackColor = false;
            this.OwnerLoginButton.Click += new System.EventHandler(this.OwnerLoginButton_Click);
            // 
            // MainAppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 581);
            this.Controls.Add(this.OwnerLoginButton);
            this.Controls.Add(this.OthersButton);
            this.Controls.Add(this.TenantButton);
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAppBody";
            this.Text = "MainAppBody";
            this.Load += new System.EventHandler(this.MainAppBody_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdminLoginButton;
        private System.Windows.Forms.Button TenantButton;
        private System.Windows.Forms.Button OthersButton;
        private System.Windows.Forms.Button OwnerLoginButton;
    }
}