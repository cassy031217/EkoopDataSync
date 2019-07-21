namespace EkoopDataSync
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
            this.EkoopDataGrid = new System.Windows.Forms.DataGridView();
            this.lblBaseURL = new System.Windows.Forms.Label();
            this.txtBaseURL = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGET = new System.Windows.Forms.Button();
            this.btnPOST = new System.Windows.Forms.Button();
            this.btnPUT = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EkoopDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EkoopDataGrid
            // 
            this.EkoopDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EkoopDataGrid.Location = new System.Drawing.Point(42, 83);
            this.EkoopDataGrid.Name = "EkoopDataGrid";
            this.EkoopDataGrid.ReadOnly = true;
            this.EkoopDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EkoopDataGrid.Size = new System.Drawing.Size(672, 267);
            this.EkoopDataGrid.TabIndex = 0;
            //this.EkoopDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EkoopDataGrid_CellContentClick);
            // 
            // lblBaseURL
            // 
            this.lblBaseURL.AutoSize = true;
            this.lblBaseURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseURL.Location = new System.Drawing.Point(39, 38);
            this.lblBaseURL.Name = "lblBaseURL";
            this.lblBaseURL.Size = new System.Drawing.Size(68, 13);
            this.lblBaseURL.TabIndex = 1;
            this.lblBaseURL.Text = "Base URL:";
            // 
            // txtBaseURL
            // 
            this.txtBaseURL.Location = new System.Drawing.Point(113, 35);
            this.txtBaseURL.Name = "txtBaseURL";
            this.txtBaseURL.Size = new System.Drawing.Size(470, 20);
            this.txtBaseURL.TabIndex = 2;
            this.txtBaseURL.TextChanged += new System.EventHandler(this.txtBaseURL_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(42, 370);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 39);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            //this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGET
            // 
            this.btnGET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGET.Location = new System.Drawing.Point(288, 370);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(102, 39);
            this.btnGET.TabIndex = 3;
            this.btnGET.Text = "GET";
            this.btnGET.UseVisualStyleBackColor = true;
            //this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // btnPOST
            // 
            this.btnPOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOST.Location = new System.Drawing.Point(396, 370);
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(102, 39);
            this.btnPOST.TabIndex = 3;
            this.btnPOST.Text = "POST";
            this.btnPOST.UseVisualStyleBackColor = true;
            //this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // btnPUT
            // 
            this.btnPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUT.Location = new System.Drawing.Point(504, 370);
            this.btnPUT.Name = "btnPUT";
            this.btnPUT.Size = new System.Drawing.Size(102, 39);
            this.btnPUT.TabIndex = 3;
            this.btnPUT.Text = "PUT";
            this.btnPUT.UseVisualStyleBackColor = true;
            // 
            // btnDELETE
            // 
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(612, 370);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(102, 39);
            this.btnDELETE.TabIndex = 3;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(745, 169);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(65, 13);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Lastname:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(819, 166);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(206, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(745, 204);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(65, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(819, 201);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(206, 20);
            this.txtFirstname.TabIndex = 2;
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.Location = new System.Drawing.Point(745, 242);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(78, 13);
            this.lblMiddlename.TabIndex = 1;
            this.lblMiddlename.Text = "Middlename:";
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(819, 239);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(206, 20);
            this.txtMiddlename.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(745, 116);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(819, 113);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(206, 20);
            this.txtID.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 426);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnPUT);
            this.Controls.Add(this.btnPOST);
            this.Controls.Add(this.btnGET);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtBaseURL);
            this.Controls.Add(this.lblBaseURL);
            this.Controls.Add(this.EkoopDataGrid);
            this.Name = "MainForm";
            this.Text = "Ekoop Data Sync";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EkoopDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EkoopDataGrid;
        private System.Windows.Forms.Label lblBaseURL;
        private System.Windows.Forms.TextBox txtBaseURL;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.Button btnPOST;
        private System.Windows.Forms.Button btnPUT;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}

