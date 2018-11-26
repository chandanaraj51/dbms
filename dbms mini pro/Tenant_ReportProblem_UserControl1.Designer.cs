namespace dbms_mini_pro
{
    partial class Tenant_ReportProblem_UserControl1
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
            this.T_idtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Complaint_textBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // T_idtextBox
            // 
            this.T_idtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.T_idtextBox.Location = new System.Drawing.Point(295, 132);
            this.T_idtextBox.Multiline = true;
            this.T_idtextBox.Name = "T_idtextBox";
            this.T_idtextBox.Size = new System.Drawing.Size(78, 17);
            this.T_idtextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "T_id:";
            // 
            // Complaint_textBox
            // 
            this.Complaint_textBox.AutoSize = true;
            this.Complaint_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complaint_textBox.Location = new System.Drawing.Point(205, 230);
            this.Complaint_textBox.Name = "Complaint_textBox";
            this.Complaint_textBox.Size = new System.Drawing.Size(84, 17);
            this.Complaint_textBox.TabIndex = 2;
            this.Complaint_textBox.Text = "Complaint:";
            this.Complaint_textBox.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(295, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 165);
            this.textBox1.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(295, 395);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(142, 51);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Tenant_ReportProblem_UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Complaint_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_idtextBox);
            this.Name = "Tenant_ReportProblem_UserControl1";
            this.Size = new System.Drawing.Size(773, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_idtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Complaint_textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SubmitButton;
    }
}
