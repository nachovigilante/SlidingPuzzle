﻿namespace SlidingPuzzle
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(94, 238);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(171, 60);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnScore
            // 
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Image = ((System.Drawing.Image)(resources.GetObject("btnScore.Image")));
            this.btnScore.Location = new System.Drawing.Point(94, 359);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(171, 60);
            this.btnScore.TabIndex = 2;
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.Location = new System.Drawing.Point(94, 300);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(171, 57);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 172);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}