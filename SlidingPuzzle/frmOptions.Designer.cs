namespace SlidingPuzzle
{
    partial class frmOptions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.chkAnimations = new System.Windows.Forms.CheckBox();
            this.lblAnimations = new System.Windows.Forms.Label();
            this.grpAnimations = new System.Windows.Forms.GroupBox();
            this.pbChkAnimations = new System.Windows.Forms.PictureBox();
            this.lblVel = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.toolTipAnimations = new System.Windows.Forms.ToolTip(this.components);
            this.chkKeys = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblKeys = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnLoadDefault = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.pbChkMulti = new System.Windows.Forms.PictureBox();
            this.pbChkKeys = new System.Windows.Forms.PictureBox();
            this.lblMulti = new System.Windows.Forms.Label();
            this.grpTab = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorSlider2 = new ColorSlider.ColorSlider();
            this.grpAnimations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChkAnimations)).BeginInit();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChkMulti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChkKeys)).BeginInit();
            this.grpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAnimations
            // 
            this.chkAnimations.AutoSize = true;
            this.chkAnimations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkAnimations.Checked = true;
            this.chkAnimations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnimations.Location = new System.Drawing.Point(188, 35);
            this.chkAnimations.Name = "chkAnimations";
            this.chkAnimations.Size = new System.Drawing.Size(15, 14);
            this.chkAnimations.TabIndex = 0;
            this.toolTipAnimations.SetToolTip(this.chkAnimations, "las animaciones pueden aumentar el tiempo y pueden ser molestas, no se recomienda" +
        "n si quiere resolverlo con un mejor tiempo");
            this.chkAnimations.UseVisualStyleBackColor = true;
            this.chkAnimations.Visible = false;
            this.chkAnimations.CheckedChanged += new System.EventHandler(this.chkAnimations_CheckedChanged);
            // 
            // lblAnimations
            // 
            this.lblAnimations.AutoSize = true;
            this.lblAnimations.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimations.Location = new System.Drawing.Point(22, 57);
            this.lblAnimations.Name = "lblAnimations";
            this.lblAnimations.Size = new System.Drawing.Size(160, 19);
            this.lblAnimations.TabIndex = 1;
            this.lblAnimations.Text = "Animaciones activas:";
            this.lblAnimations.Click += new System.EventHandler(this.lblAnimations_Click);
            // 
            // grpAnimations
            // 
            this.grpAnimations.Controls.Add(this.pbChkAnimations);
            this.grpAnimations.Controls.Add(this.colorSlider2);
            this.grpAnimations.Controls.Add(this.lblVel);
            this.grpAnimations.Controls.Add(this.lblAnimations);
            this.grpAnimations.Controls.Add(this.chkAnimations);
            this.grpAnimations.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnimations.Location = new System.Drawing.Point(73, 164);
            this.grpAnimations.Name = "grpAnimations";
            this.grpAnimations.Size = new System.Drawing.Size(430, 171);
            this.grpAnimations.TabIndex = 3;
            this.grpAnimations.TabStop = false;
            this.grpAnimations.Text = "Animaciones";
            this.grpAnimations.Paint += new System.Windows.Forms.PaintEventHandler(this.grpAnimations_Paint);
            this.grpAnimations.Enter += new System.EventHandler(this.grpAnimations_Enter);
            // 
            // pbChkAnimations
            // 
            this.pbChkAnimations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbChkAnimations.BackgroundImage")));
            this.pbChkAnimations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbChkAnimations.Location = new System.Drawing.Point(188, 50);
            this.pbChkAnimations.Name = "pbChkAnimations";
            this.pbChkAnimations.Size = new System.Drawing.Size(31, 33);
            this.pbChkAnimations.TabIndex = 17;
            this.pbChkAnimations.TabStop = false;
            this.pbChkAnimations.Click += new System.EventHandler(this.pbChkAnimations_Click);
            // 
            // lblVel
            // 
            this.lblVel.AutoSize = true;
            this.lblVel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVel.Location = new System.Drawing.Point(23, 97);
            this.lblVel.Name = "lblVel";
            this.lblVel.Size = new System.Drawing.Size(83, 19);
            this.lblVel.TabIndex = 0;
            this.lblVel.Text = "Velocidad:";
            this.lblVel.Click += new System.EventHandler(this.lblVel_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(22, 57);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(150, 19);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Tamaño del tablero:";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // cboSize
            // 
            this.cboSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "3x3",
            "4x4",
            "5x5"});
            this.cboSize.Location = new System.Drawing.Point(178, 54);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(72, 27);
            this.cboSize.TabIndex = 5;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // toolTipAnimations
            // 
            this.toolTipAnimations.AutomaticDelay = 200;
            this.toolTipAnimations.AutoPopDelay = 5000;
            this.toolTipAnimations.InitialDelay = 200;
            this.toolTipAnimations.ReshowDelay = 40;
            this.toolTipAnimations.ToolTipTitle = "Animaciones";
            // 
            // chkKeys
            // 
            this.chkKeys.AutoSize = true;
            this.chkKeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkKeys.Checked = true;
            this.chkKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeys.Location = new System.Drawing.Point(172, 26);
            this.chkKeys.Name = "chkKeys";
            this.chkKeys.Size = new System.Drawing.Size(15, 14);
            this.chkKeys.TabIndex = 7;
            this.toolTipAnimations.SetToolTip(this.chkKeys, "las animaciones pueden aumentar el tiempo y pueden ser molestas, no se recomienda" +
        "n si quiere resolverlo con un mejor tiempo");
            this.chkKeys.UseVisualStyleBackColor = true;
            this.chkKeys.Visible = false;
            this.chkKeys.CheckedChanged += new System.EventHandler(this.chkKeys_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(379, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.toolTipAnimations.SetToolTip(this.checkBox1, "las animaciones pueden aumentar el tiempo y pueden ser molestas, no se recomienda" +
        "n si quiere resolverlo con un mejor tiempo");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeys.Location = new System.Drawing.Point(25, 45);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(141, 19);
            this.lblKeys.TabIndex = 6;
            this.lblKeys.Text = "Uso con las teclas:";
            this.lblKeys.Click += new System.EventHandler(this.lblKeys_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(22, 103);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(260, 19);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "Agregar una imágen personalizada:";
            this.lblFile.Click += new System.EventHandler(this.lblFile_Click);
            // 
            // btnFile
            // 
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.Location = new System.Drawing.Point(41, 138);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(172, 60);
            this.btnFile.TabIndex = 0;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            this.btnFile.MouseEnter += new System.EventHandler(this.btnFile_MouseEnter);
            this.btnFile.MouseLeave += new System.EventHandler(this.btnFile_MouseLeave);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.Location = new System.Drawing.Point(22, 215);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(96, 19);
            this.lblPreview.TabIndex = 11;
            this.lblPreview.Text = "Vista previa:";
            this.lblPreview.Click += new System.EventHandler(this.lblPreview_Click);
            // 
            // btnLoadDefault
            // 
            this.btnLoadDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadDefault.FlatAppearance.BorderSize = 0;
            this.btnLoadDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadDefault.Image")));
            this.btnLoadDefault.Location = new System.Drawing.Point(209, 138);
            this.btnLoadDefault.Name = "btnLoadDefault";
            this.btnLoadDefault.Size = new System.Drawing.Size(182, 60);
            this.btnLoadDefault.TabIndex = 9;
            this.btnLoadDefault.UseVisualStyleBackColor = true;
            this.btnLoadDefault.Click += new System.EventHandler(this.btnLoadDefault_Click);
            this.btnLoadDefault.MouseEnter += new System.EventHandler(this.btnLoadDefault_MouseEnter);
            this.btnLoadDefault.MouseLeave += new System.EventHandler(this.btnLoadDefault_MouseLeave);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.Location = new System.Drawing.Point(14, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(43, 47);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            this.btnVolver.MouseEnter += new System.EventHandler(this.btnVolver_MouseEnter);
            this.btnVolver.MouseLeave += new System.EventHandler(this.btnVolver_MouseLeave);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.pbChkMulti);
            this.grpControls.Controls.Add(this.pbChkKeys);
            this.grpControls.Controls.Add(this.lblMulti);
            this.grpControls.Controls.Add(this.checkBox1);
            this.grpControls.Controls.Add(this.lblKeys);
            this.grpControls.Controls.Add(this.chkKeys);
            this.grpControls.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpControls.Location = new System.Drawing.Point(73, 62);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(430, 73);
            this.grpControls.TabIndex = 13;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controles";
            this.grpControls.Paint += new System.Windows.Forms.PaintEventHandler(this.grpControls_Paint);
            this.grpControls.Enter += new System.EventHandler(this.grpControls_Enter);
            // 
            // pbChkMulti
            // 
            this.pbChkMulti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbChkMulti.BackgroundImage")));
            this.pbChkMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbChkMulti.Location = new System.Drawing.Point(379, 39);
            this.pbChkMulti.Name = "pbChkMulti";
            this.pbChkMulti.Size = new System.Drawing.Size(31, 33);
            this.pbChkMulti.TabIndex = 16;
            this.pbChkMulti.TabStop = false;
            this.pbChkMulti.Click += new System.EventHandler(this.pbChkMulti_Click);
            // 
            // pbChkKeys
            // 
            this.pbChkKeys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbChkKeys.BackgroundImage")));
            this.pbChkKeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbChkKeys.Location = new System.Drawing.Point(172, 39);
            this.pbChkKeys.Name = "pbChkKeys";
            this.pbChkKeys.Size = new System.Drawing.Size(31, 33);
            this.pbChkKeys.TabIndex = 15;
            this.pbChkKeys.TabStop = false;
            this.pbChkKeys.Click += new System.EventHandler(this.pbChkKeys_Click);
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulti.Location = new System.Drawing.Point(215, 45);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(158, 19);
            this.lblMulti.TabIndex = 8;
            this.lblMulti.Text = "Movimiento múltiple:";
            this.lblMulti.Click += new System.EventHandler(this.lblMulti_Click);
            // 
            // grpTab
            // 
            this.grpTab.Controls.Add(this.lblFile);
            this.grpTab.Controls.Add(this.btnFile);
            this.grpTab.Controls.Add(this.btnLoadDefault);
            this.grpTab.Controls.Add(this.lblPreview);
            this.grpTab.Controls.Add(this.cboSize);
            this.grpTab.Controls.Add(this.lblSize);
            this.grpTab.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTab.Location = new System.Drawing.Point(73, 364);
            this.grpTab.Name = "grpTab";
            this.grpTab.Size = new System.Drawing.Size(430, 524);
            this.grpTab.TabIndex = 14;
            this.grpTab.TabStop = false;
            this.grpTab.Text = "Imagen";
            this.grpTab.Paint += new System.Windows.Forms.PaintEventHandler(this.grpTab_Paint);
            this.grpTab.Enter += new System.EventHandler(this.grpTab_Enter);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // colorSlider2
            // 
            this.colorSlider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorSlider2.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(38)))));
            this.colorSlider2.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(38)))));
            this.colorSlider2.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(38)))));
            this.colorSlider2.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider2.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(8)))));
            this.colorSlider2.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(8)))));
            this.colorSlider2.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(8)))));
            this.colorSlider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.colorSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(8)))));
            this.colorSlider2.LargeChange = ((uint)(5u));
            this.colorSlider2.Location = new System.Drawing.Point(34, 115);
            this.colorSlider2.Maximum = 10;
            this.colorSlider2.Minimum = 1;
            this.colorSlider2.Name = "colorSlider2";
            this.colorSlider2.ScaleDivisions = 10;
            this.colorSlider2.ScaleSubDivisions = 5;
            this.colorSlider2.ShowDivisionsText = true;
            this.colorSlider2.ShowSmallScale = false;
            this.colorSlider2.Size = new System.Drawing.Size(347, 48);
            this.colorSlider2.SmallChange = ((uint)(1u));
            this.colorSlider2.TabIndex = 2;
            this.colorSlider2.Text = "colorSlider";
            this.colorSlider2.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(8)))));
            this.colorSlider2.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(8)))));
            this.colorSlider2.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(8)))));
            this.colorSlider2.ThumbRoundRectSize = new System.Drawing.Size(12, 12);
            this.colorSlider2.ThumbSize = new System.Drawing.Size(20, 24);
            this.colorSlider2.TickAdd = 0F;
            this.colorSlider2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(8)))));
            this.colorSlider2.TickDivide = 0F;
            this.colorSlider2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.colorSlider2.Value = 5;
            this.colorSlider2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider2_Scroll);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 537);
            this.ControlBox = false;
            this.Controls.Add(this.grpTab);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpAnimations);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.frmOptions_Scroll);
            this.grpAnimations.ResumeLayout(false);
            this.grpAnimations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChkAnimations)).EndInit();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChkMulti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChkKeys)).EndInit();
            this.grpTab.ResumeLayout(false);
            this.grpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAnimations;
        private System.Windows.Forms.Label lblAnimations;
        private System.Windows.Forms.GroupBox grpAnimations;
        private System.Windows.Forms.Label lblVel;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ToolTip toolTipAnimations;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnLoadDefault;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpTab;
        private ColorSlider.ColorSlider colorSlider2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pbChkKeys;
        private System.Windows.Forms.PictureBox pbChkAnimations;
        private System.Windows.Forms.PictureBox pbChkMulti;
    }
}