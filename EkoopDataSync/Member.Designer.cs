namespace EkoopDataSync
{
    partial class Member
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
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(106, 101);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(206, 20);
            this.txtMiddlename.TabIndex = 6;
            this.txtMiddlename.Text = "Halog";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.Location = new System.Drawing.Point(32, 104);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(78, 13);
            this.lblMiddlename.TabIndex = 3;
            this.lblMiddlename.Text = "Middlename:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(106, 63);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(206, 20);
            this.txtFirstname.TabIndex = 7;
            this.txtFirstname.Text = "Benido";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(32, 66);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(65, 13);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "Firstname:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(106, 28);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(206, 20);
            this.txtLastname.TabIndex = 8;
            this.txtLastname.Text = "Lapitan";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(32, 31);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(65, 13);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "Lastname:";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(106, 141);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(206, 23);
            this.btnValidate.TabIndex = 9;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 228);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblLastname);
            this.Name = "Member";
            this.Text = "Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Button btnValidate;
    }
}