﻿namespace SlidingPuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblMovesTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeTitle = new System.Windows.Forms.Label();
            this.tmrTickExtern = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnVolver);
            this.grpControls.Controls.Add(this.btnBegin);
            this.grpControls.Controls.Add(this.lblMoves);
            this.grpControls.Controls.Add(this.lblMovesTitle);
            this.grpControls.Controls.Add(this.lblTime);
            this.grpControls.Controls.Add(this.lblTimeTitle);
            this.grpControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpControls.Location = new System.Drawing.Point(236, 33);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(170, 366);
            this.grpControls.TabIndex = 0;
            this.grpControls.TabStop = false;
            this.grpControls.Paint += new System.Windows.Forms.PaintEventHandler(this.grpControls_Paint);
            this.grpControls.Enter += new System.EventHandler(this.grpControls_Enter);
            this.grpControls.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grpControls_PreviewKeyDown);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(19, 280);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(132, 54);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.btnVolver.MouseEnter += new System.EventHandler(this.btnVolver_MouseEnter);
            this.btnVolver.MouseLeave += new System.EventHandler(this.btnVolver_MouseLeave);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.Transparent;
            this.btnBegin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBegin.FlatAppearance.BorderSize = 0;
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Image = ((System.Drawing.Image)(resources.GetObject("btnBegin.Image")));
            this.btnBegin.Location = new System.Drawing.Point(21, 33);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(129, 52);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            this.btnBegin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBegin_KeyDown);
            this.btnBegin.MouseEnter += new System.EventHandler(this.btnBegin_MouseEnter);
            this.btnBegin.MouseLeave += new System.EventHandler(this.btnBegin_MouseLeave);
            this.btnBegin.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnBegin_PreviewKeyDown);
            // 
            // lblMoves
            // 
            this.lblMoves.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.ForeColor = System.Drawing.Color.White;
            this.lblMoves.Location = new System.Drawing.Point(3, 222);
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
            this.lblMovesTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesTitle.ForeColor = System.Drawing.Color.White;
            this.lblMovesTitle.Location = new System.Drawing.Point(35, 195);
            this.lblMovesTitle.Name = "lblMovesTitle";
            this.lblMovesTitle.Size = new System.Drawing.Size(105, 19);
            this.lblMovesTitle.TabIndex = 2;
            this.lblMovesTitle.Text = "Movimientos:";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(3, 148);
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
            this.lblTimeTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTitle.ForeColor = System.Drawing.Color.White;
            this.lblTimeTitle.Location = new System.Drawing.Point(15, 120);
            this.lblTimeTitle.Name = "lblTimeTitle";
            this.lblTimeTitle.Size = new System.Drawing.Size(142, 19);
            this.lblTimeTitle.TabIndex = 0;
            this.lblTimeTitle.Text = "Tiempo en partida:";
            // 
            // tmrTickExtern
            // 
            this.tmrTickExtern.Enabled = true;
            this.tmrTickExtern.Tick += new System.EventHandler(this.tmrTickExtern_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 433);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpControls);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rompecabezas de X";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmMain_PreviewKeyDown);
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label lblTimeTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblMovesTitle;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Timer tmrTickExtern;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

