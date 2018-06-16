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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblFlu = new System.Windows.Forms.Label();
            this.trkAnimations = new System.Windows.Forms.TrackBar();
            this.lblVel = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.toolTipAnimations = new System.Windows.Forms.ToolTip(this.components);
            this.chkKeys = new System.Windows.Forms.CheckBox();
            this.lblKeys = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAnimations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAnimations)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAnimations
            // 
            this.chkAnimations.AutoSize = true;
            this.chkAnimations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkAnimations.Checked = true;
            this.chkAnimations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnimations.Location = new System.Drawing.Point(170, 86);
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
            this.lblAnimations.Location = new System.Drawing.Point(59, 86);
            this.lblAnimations.Name = "lblAnimations";
            this.lblAnimations.Size = new System.Drawing.Size(107, 13);
            this.lblAnimations.TabIndex = 1;
            this.lblAnimations.Text = "Animaciones activas:";
            // 
            // grpAnimations
            // 
            this.grpAnimations.Controls.Add(this.trackBar1);
            this.grpAnimations.Controls.Add(this.lblFlu);
            this.grpAnimations.Controls.Add(this.trkAnimations);
            this.grpAnimations.Controls.Add(this.lblVel);
            this.grpAnimations.Location = new System.Drawing.Point(52, 122);
            this.grpAnimations.Name = "grpAnimations";
            this.grpAnimations.Size = new System.Drawing.Size(200, 182);
            this.grpAnimations.TabIndex = 3;
            this.grpAnimations.TabStop = false;
            this.grpAnimations.Text = "Configuración de las animaciones";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(13, 127);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 35);
            this.trackBar1.TabIndex = 3;
            // 
            // lblFlu
            // 
            this.lblFlu.AutoSize = true;
            this.lblFlu.Location = new System.Drawing.Point(10, 105);
            this.lblFlu.Name = "lblFlu";
            this.lblFlu.Size = new System.Drawing.Size(43, 13);
            this.lblFlu.TabIndex = 2;
            this.lblFlu.Text = "Fluidez:";
            // 
            // trkAnimations
            // 
            this.trkAnimations.AutoSize = false;
            this.trkAnimations.Location = new System.Drawing.Point(13, 59);
            this.trkAnimations.Name = "trkAnimations";
            this.trkAnimations.Size = new System.Drawing.Size(174, 35);
            this.trkAnimations.TabIndex = 1;
            // 
            // lblVel
            // 
            this.lblVel.AutoSize = true;
            this.lblVel.Location = new System.Drawing.Point(10, 37);
            this.lblVel.Name = "lblVel";
            this.lblVel.Size = new System.Drawing.Size(57, 13);
            this.lblVel.TabIndex = 0;
            this.lblVel.Text = "Velocidad:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(59, 50);
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
            this.cboSize.Location = new System.Drawing.Point(166, 46);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(66, 21);
            this.cboSize.TabIndex = 5;
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
            this.chkKeys.Location = new System.Drawing.Point(170, 323);
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
            this.lblKeys.Location = new System.Drawing.Point(59, 323);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(97, 13);
            this.lblKeys.TabIndex = 6;
            this.lblKeys.Text = "Uso con las teclas:";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(59, 360);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(173, 13);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "Agregar una imágen personalizada:";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(238, 353);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(134, 27);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Seleccionar imagen";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 738);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.chkKeys);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.grpAnimations);
            this.Controls.Add(this.lblAnimations);
            this.Controls.Add(this.chkAnimations);
            this.Name = "frmOptions";
            this.Text = "Opciones";
            this.grpAnimations.ResumeLayout(false);
            this.grpAnimations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAnimations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAnimations;
        private System.Windows.Forms.Label lblAnimations;
        private System.Windows.Forms.GroupBox grpAnimations;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblFlu;
        private System.Windows.Forms.TrackBar trkAnimations;
        private System.Windows.Forms.Label lblVel;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ToolTip toolTipAnimations;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button button1;
    }
}