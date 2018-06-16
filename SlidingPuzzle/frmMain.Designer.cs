namespace SlidingPuzzle
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblMovesTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeTitle = new System.Windows.Forms.Label();
            this.tmrTickExtern = new System.Windows.Forms.Timer(this.components);
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnSolve);
            this.grpControls.Controls.Add(this.btnBegin);
            this.grpControls.Controls.Add(this.lblMoves);
            this.grpControls.Controls.Add(this.lblMovesTitle);
            this.grpControls.Controls.Add(this.lblTime);
            this.grpControls.Controls.Add(this.lblTimeTitle);
            this.grpControls.Location = new System.Drawing.Point(236, 22);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(170, 350);
            this.grpControls.TabIndex = 0;
            this.grpControls.TabStop = false;
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(26, 97);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(119, 44);
            this.btnSolve.TabIndex = 5;
            this.btnSolve.Text = "Resolver";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(26, 30);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(119, 44);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Empezar";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblMoves
            // 
            this.lblMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.Location = new System.Drawing.Point(3, 292);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(164, 31);
            this.lblMoves.TabIndex = 3;
            this.lblMoves.Text = "0";
            this.lblMoves.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMoves.UseCompatibleTextRendering = true;
            // 
            // lblMovesTitle
            // 
            this.lblMovesTitle.AutoSize = true;
            this.lblMovesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesTitle.Location = new System.Drawing.Point(35, 265);
            this.lblMovesTitle.Name = "lblMovesTitle";
            this.lblMovesTitle.Size = new System.Drawing.Size(101, 20);
            this.lblMovesTitle.TabIndex = 2;
            this.lblMovesTitle.Text = "Movimientos:";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(3, 206);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(164, 31);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "0:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTime.UseCompatibleTextRendering = true;
            // 
            // lblTimeTitle
            // 
            this.lblTimeTitle.AutoSize = true;
            this.lblTimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTitle.Location = new System.Drawing.Point(15, 178);
            this.lblTimeTitle.Name = "lblTimeTitle";
            this.lblTimeTitle.Size = new System.Drawing.Size(140, 20);
            this.lblTimeTitle.TabIndex = 0;
            this.lblTimeTitle.Text = "Tiempo en partida:";
            // 
            // tmrTickExtern
            // 
            this.tmrTickExtern.Enabled = true;
            this.tmrTickExtern.Tick += new System.EventHandler(this.tmrTickExtern_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 433);
            this.Controls.Add(this.grpControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Rompecabezas de X";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label lblTimeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblMovesTitle;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Timer tmrTickExtern;
    }
}

