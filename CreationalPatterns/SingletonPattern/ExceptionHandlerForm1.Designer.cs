namespace CreationalPatterns.SingletonPattern
{
    partial class ExceptionHandlerForm1
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
            this.btnGoToForm2 = new System.Windows.Forms.Button();
            this.btnDoSomethingBad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToForm2
            // 
            this.btnGoToForm2.Location = new System.Drawing.Point(65, 135);
            this.btnGoToForm2.Name = "btnGoToForm2";
            this.btnGoToForm2.Size = new System.Drawing.Size(260, 23);
            this.btnGoToForm2.TabIndex = 3;
            this.btnGoToForm2.Text = "Go to Form 2";
            this.btnGoToForm2.UseVisualStyleBackColor = true;
            this.btnGoToForm2.Click += new System.EventHandler(this.btnGoToForm2_Click);
            // 
            // btnDoSomethingBad
            // 
            this.btnDoSomethingBad.Location = new System.Drawing.Point(65, 41);
            this.btnDoSomethingBad.Name = "btnDoSomethingBad";
            this.btnDoSomethingBad.Size = new System.Drawing.Size(260, 23);
            this.btnDoSomethingBad.TabIndex = 2;
            this.btnDoSomethingBad.Text = "Do Something Bad";
            this.btnDoSomethingBad.UseVisualStyleBackColor = true;
            this.btnDoSomethingBad.Click += new System.EventHandler(this.btnDoSomethingBad_Click);
            // 
            // ExceptionHandlerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 208);
            this.Controls.Add(this.btnGoToForm2);
            this.Controls.Add(this.btnDoSomethingBad);
            this.Name = "ExceptionHandlerForm1";
            this.Text = "ExceptionHandlerForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToForm2;
        private System.Windows.Forms.Button btnDoSomethingBad;
    }
}