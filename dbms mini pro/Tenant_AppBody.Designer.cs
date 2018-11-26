namespace dbms_mini_pro
{
    partial class Tenant_AppBody
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PayBillButton = new System.Windows.Forms.Button();
            this.ReportProblemButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 38);
            this.panel1.TabIndex = 0;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::dbms_mini_pro.Properties.Resources.if_792;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(882, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(41, 37);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::dbms_mini_pro.Properties.Resources.if_852;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(929, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 37);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.PayBillButton);
            this.panel2.Controls.Add(this.ReportProblemButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 540);
            this.panel2.TabIndex = 2;
            // 
            // PayBillButton
            // 
            this.PayBillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBillButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PayBillButton.Location = new System.Drawing.Point(0, 239);
            this.PayBillButton.Name = "PayBillButton";
            this.PayBillButton.Size = new System.Drawing.Size(200, 63);
            this.PayBillButton.TabIndex = 3;
            this.PayBillButton.Text = "BILL PAYMENT";
            this.PayBillButton.UseVisualStyleBackColor = true;
            this.PayBillButton.Click += new System.EventHandler(this.PayBillButton_Click);
            // 
            // ReportProblemButton
            // 
            this.ReportProblemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportProblemButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReportProblemButton.Location = new System.Drawing.Point(0, 70);
            this.ReportProblemButton.Name = "ReportProblemButton";
            this.ReportProblemButton.Size = new System.Drawing.Size(200, 63);
            this.ReportProblemButton.TabIndex = 2;
            this.ReportProblemButton.Text = "REPORT PROBLEM";
            this.ReportProblemButton.UseVisualStyleBackColor = true;
            this.ReportProblemButton.Click += new System.EventHandler(this.ReportProblemButton_Click_1);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(200, 38);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(773, 540);
            this.ContentPanel.TabIndex = 3;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::dbms_mini_pro.Properties.Resources.Screenshot_2018_11_20_11_19_07_638_com_android_chrome;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(835, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 37);
            this.BackButton.TabIndex = 1;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Tenant_AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 578);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tenant_AppBody";
            this.Text = "Tenant_AppBody";
            this.Load += new System.EventHandler(this.Tenant_AppBody_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ReportProblemButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button PayBillButton;
    }
}