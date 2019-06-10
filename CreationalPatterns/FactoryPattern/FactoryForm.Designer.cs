namespace CreationalPatterns.FactoryPattern
{
    partial class FactoryForm
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
            this.radUseOleDb = new System.Windows.Forms.RadioButton();
            this.radUseSqlServer = new System.Windows.Forms.RadioButton();
            this.btnGetDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radUseOleDb
            // 
            this.radUseOleDb.AutoSize = true;
            this.radUseOleDb.Location = new System.Drawing.Point(24, 45);
            this.radUseOleDb.Name = "radUseOleDb";
            this.radUseOleDb.Size = new System.Drawing.Size(77, 17);
            this.radUseOleDb.TabIndex = 5;
            this.radUseOleDb.Text = "Use OleDb";
            this.radUseOleDb.UseVisualStyleBackColor = true;
            // 
            // radUseSqlServer
            // 
            this.radUseSqlServer.AutoSize = true;
            this.radUseSqlServer.Checked = true;
            this.radUseSqlServer.Location = new System.Drawing.Point(24, 22);
            this.radUseSqlServer.Name = "radUseSqlServer";
            this.radUseSqlServer.Size = new System.Drawing.Size(102, 17);
            this.radUseSqlServer.TabIndex = 4;
            this.radUseSqlServer.TabStop = true;
            this.radUseSqlServer.Text = "Use SQL Server";
            this.radUseSqlServer.UseVisualStyleBackColor = true;
            // 
            // btnGetDatabase
            // 
            this.btnGetDatabase.Location = new System.Drawing.Point(98, 84);
            this.btnGetDatabase.Name = "btnGetDatabase";
            this.btnGetDatabase.Size = new System.Drawing.Size(113, 23);
            this.btnGetDatabase.TabIndex = 3;
            this.btnGetDatabase.Text = "GetDatabase";
            this.btnGetDatabase.UseVisualStyleBackColor = true;
            this.btnGetDatabase.Click += new System.EventHandler(this.btnGetDatabase_Click);
            // 
            // FactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 158);
            this.Controls.Add(this.radUseOleDb);
            this.Controls.Add(this.radUseSqlServer);
            this.Controls.Add(this.btnGetDatabase);
            this.Name = "FactoryForm";
            this.Text = "FactoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radUseOleDb;
        private System.Windows.Forms.RadioButton radUseSqlServer;
        private System.Windows.Forms.Button btnGetDatabase;
    }
}