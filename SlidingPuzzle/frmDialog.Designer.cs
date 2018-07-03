namespace SlidingPuzzle
{
    partial class frmDialog
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
            this.lblWin = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWin
            // 
            this.lblWin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(13, 20);
            this.lblWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(510, 59);
            this.lblWin.TabIndex = 0;
            this.lblWin.Text = "lblWin";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(216, 82);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Continuar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(456, 82);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(67, 28);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Volver";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 88);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 3;
            // 
            // frmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 131);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblWin);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Felicidades!";
            this.Load += new System.EventHandler(this.frmDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.TextBox txtName;
    }
}