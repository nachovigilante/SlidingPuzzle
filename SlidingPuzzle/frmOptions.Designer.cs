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
            this.chkAnimations = new System.Windows.Forms.CheckBox();
            this.lblAnimations = new System.Windows.Forms.Label();
            this.grpAnimations = new System.Windows.Forms.GroupBox();
            this.trkAnimations = new System.Windows.Forms.TrackBar();
            this.lblVel = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.toolTipAnimations = new System.Windows.Forms.ToolTip(this.components);
            this.chkKeys = new System.Windows.Forms.CheckBox();
            this.lblKeys = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblDefault = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnLoadDefault = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.lblMulti = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpTab = new System.Windows.Forms.GroupBox();
            this.grpAnimations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkAnimations)).BeginInit();
            this.grpControls.SuspendLayout();
            this.grpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAnimations
            // 
            this.chkAnimations.AutoSize = true;
            this.chkAnimations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkAnimations.Checked = true;
            this.chkAnimations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnimations.Location = new System.Drawing.Point(135, 42);
            this.chkAnimations.Name = "chkAnimations";
            this.chkAnimations.Size = new System.Drawing.Size(15, 14);
            this.chkAnimations.TabIndex = 0;
            this.toolTipAnimations.SetToolTip(this.chkAnimations, "las animaciones pueden aumentar el tiempo y pueden ser molestas, no se recomienda" +
        "n si quiere resolverlo con un mejor tiempo");
            this.chkAnimations.UseVisualStyleBackColor = true;
            this.chkAnimations.CheckedChanged += new System.EventHandler(this.chkAnimations_CheckedChanged);
            // 
            // lblAnimations
            // 
            this.lblAnimations.AutoSize = true;
            this.lblAnimations.Location = new System.Drawing.Point(22, 42);
            this.lblAnimations.Name = "lblAnimations";
            this.lblAnimations.Size = new System.Drawing.Size(107, 13);
            this.lblAnimations.TabIndex = 1;
            this.lblAnimations.Text = "Animaciones activas:";
            // 
            // grpAnimations
            // 
            this.grpAnimations.Controls.Add(this.trkAnimations);
            this.grpAnimations.Controls.Add(this.lblVel);
            this.grpAnimations.Controls.Add(this.lblAnimations);
            this.grpAnimations.Controls.Add(this.chkAnimations);
            this.grpAnimations.Location = new System.Drawing.Point(46, 112);
            this.grpAnimations.Name = "grpAnimations";
            this.grpAnimations.Size = new System.Drawing.Size(316, 157);
            this.grpAnimations.TabIndex = 3;
            this.grpAnimations.TabStop = false;
            this.grpAnimations.Text = "Configuración de las animaciones";
            // 
            // trkAnimations
            // 
            this.trkAnimations.AutoSize = false;
            this.trkAnimations.Location = new System.Drawing.Point(30, 101);
            this.trkAnimations.Minimum = 1;
            this.trkAnimations.Name = "trkAnimations";
            this.trkAnimations.Size = new System.Drawing.Size(257, 35);
            this.trkAnimations.TabIndex = 1;
            this.trkAnimations.Value = 5;
            this.trkAnimations.Scroll += new System.EventHandler(this.trkAnimations_Scroll);
            // 
            // lblVel
            // 
            this.lblVel.AutoSize = true;
            this.lblVel.Location = new System.Drawing.Point(22, 75);
            this.lblVel.Name = "lblVel";
            this.lblVel.Size = new System.Drawing.Size(57, 13);
            this.lblVel.TabIndex = 0;
            this.lblVel.Text = "Velocidad:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(22, 47);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(101, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Tamaño del tablero:";
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "3x3",
            "4x4",
            "5x5"});
            this.cboSize.Location = new System.Drawing.Point(126, 44);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(53, 21);
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
            this.chkKeys.Location = new System.Drawing.Point(125, 31);
            this.chkKeys.Name = "chkKeys";
            this.chkKeys.Size = new System.Drawing.Size(15, 14);
            this.chkKeys.TabIndex = 7;
            this.toolTipAnimations.SetToolTip(this.chkKeys, "las animaciones pueden aumentar el tiempo y pueden ser molestas, no se recomienda" +
        "n si quiere resolverlo con un mejor tiempo");
            this.chkKeys.UseVisualStyleBackColor = true;
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(22, 31);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(97, 13);
            this.lblKeys.TabIndex = 6;
            this.lblKeys.Text = "Uso con las teclas:";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(22, 93);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(173, 13);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "Agregar una imágen personalizada:";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(28, 122);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(126, 27);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Seleccionar imagen";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblDefault
            // 
            this.lblDefault.AutoSize = true;
            this.lblDefault.Location = new System.Drawing.Point(189, 47);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Size = new System.Drawing.Size(83, 13);
            this.lblDefault.TabIndex = 10;
            this.lblDefault.Text = "(3x3 por default)";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(22, 175);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(65, 13);
            this.lblPreview.TabIndex = 11;
            this.lblPreview.Text = "Vista previa:";
            // 
            // btnLoadDefault
            // 
            this.btnLoadDefault.Location = new System.Drawing.Point(163, 122);
            this.btnLoadDefault.Name = "btnLoadDefault";
            this.btnLoadDefault.Size = new System.Drawing.Size(126, 27);
            this.btnLoadDefault.TabIndex = 9;
            this.btnLoadDefault.Text = "Cargar imagen default";
            this.btnLoadDefault.UseVisualStyleBackColor = true;
            this.btnLoadDefault.Click += new System.EventHandler(this.btnLoadDefault_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 752);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Volver al menú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.lblMulti);
            this.grpControls.Controls.Add(this.checkBox1);
            this.grpControls.Controls.Add(this.lblKeys);
            this.grpControls.Controls.Add(this.chkKeys);
            this.grpControls.Location = new System.Drawing.Point(46, 37);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(316, 64);
            this.grpControls.TabIndex = 13;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controles";
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(166, 31);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(102, 13);
            this.lblMulti.TabIndex = 8;
            this.lblMulti.Text = "Movimiento múltiple:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(269, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.toolTipAnimations.SetToolTip(this.checkBox1, "las animaciones pueden aumentar el tiempo y pueden ser molestas, no se recomienda" +
        "n si quiere resolverlo con un mejor tiempo");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // grpTab
            // 
            this.grpTab.Controls.Add(this.lblFile);
            this.grpTab.Controls.Add(this.btnFile);
            this.grpTab.Controls.Add(this.btnLoadDefault);
            this.grpTab.Controls.Add(this.lblDefault);
            this.grpTab.Controls.Add(this.lblPreview);
            this.grpTab.Controls.Add(this.cboSize);
            this.grpTab.Controls.Add(this.lblSize);
            this.grpTab.Location = new System.Drawing.Point(46, 280);
            this.grpTab.Name = "grpTab";
            this.grpTab.Size = new System.Drawing.Size(316, 453);
            this.grpTab.TabIndex = 14;
            this.grpTab.TabStop = false;
            this.grpTab.Text = "Imagen:";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 796);
            this.ControlBox = false;
            this.Controls.Add(this.grpTab);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpAnimations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.grpAnimations.ResumeLayout(false);
            this.grpAnimations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkAnimations)).EndInit();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.grpTab.ResumeLayout(false);
            this.grpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAnimations;
        private System.Windows.Forms.Label lblAnimations;
        private System.Windows.Forms.GroupBox grpAnimations;
        private System.Windows.Forms.TrackBar trkAnimations;
        private System.Windows.Forms.Label lblVel;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ToolTip toolTipAnimations;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblDefault;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnLoadDefault;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpTab;
    }
}