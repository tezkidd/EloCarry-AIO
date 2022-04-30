namespace EloCarry_AIO
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.controlBox = new Siticone.UI.WinForms.SiticoneControlBox();
            this.Rounded = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.directX_CheckBox = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.redistributable_CheckBox = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.DragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.DragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.WindowAnimate = new Siticone.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.defender_CheckBox = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.ShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.ProgressIndicator = new Siticone.UI.WinForms.SiticoneProgressIndicator();
            this.StartBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.RedistributableInstaller = new System.ComponentModel.BackgroundWorker();
            this.DirectXInstaller = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(4, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(667, 295);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.BorderRadius = 4;
            this.controlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.controlBox.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox.HoveredState.IconColor = System.Drawing.Color.White;
            this.controlBox.HoveredState.Parent = this.controlBox;
            this.controlBox.IconColor = System.Drawing.Color.White;
            this.controlBox.Location = new System.Drawing.Point(599, 8);
            this.controlBox.Name = "controlBox";
            this.controlBox.ShadowDecoration.Parent = this.controlBox;
            this.controlBox.Size = new System.Drawing.Size(36, 26);
            this.controlBox.TabIndex = 49;
            this.controlBox.TabStop = false;
            // 
            // Rounded
            // 
            this.Rounded.BorderRadius = 10;
            this.Rounded.TargetControl = this;
            // 
            // directX_CheckBox
            // 
            this.directX_CheckBox.AutoSize = true;
            this.directX_CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.directX_CheckBox.CheckedState.BorderRadius = 2;
            this.directX_CheckBox.CheckedState.BorderThickness = 0;
            this.directX_CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.directX_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.directX_CheckBox.ForeColor = System.Drawing.Color.White;
            this.directX_CheckBox.Location = new System.Drawing.Point(100, 283);
            this.directX_CheckBox.Name = "directX_CheckBox";
            this.directX_CheckBox.Size = new System.Drawing.Size(105, 19);
            this.directX_CheckBox.TabIndex = 52;
            this.directX_CheckBox.Text = "Install DirectX";
            this.directX_CheckBox.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.directX_CheckBox.UncheckedState.BorderRadius = 2;
            this.directX_CheckBox.UncheckedState.BorderThickness = 0;
            this.directX_CheckBox.UncheckedState.FillColor = System.Drawing.Color.White;
            this.directX_CheckBox.UseVisualStyleBackColor = true;
            this.directX_CheckBox.CheckedChanged += new System.EventHandler(this.DirectX_CheckBox_CheckedChanged);
            // 
            // redistributable_CheckBox
            // 
            this.redistributable_CheckBox.AutoSize = true;
            this.redistributable_CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.redistributable_CheckBox.CheckedState.BorderRadius = 2;
            this.redistributable_CheckBox.CheckedState.BorderThickness = 0;
            this.redistributable_CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.redistributable_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.redistributable_CheckBox.ForeColor = System.Drawing.Color.White;
            this.redistributable_CheckBox.Location = new System.Drawing.Point(211, 283);
            this.redistributable_CheckBox.Name = "redistributable_CheckBox";
            this.redistributable_CheckBox.Size = new System.Drawing.Size(152, 19);
            this.redistributable_CheckBox.TabIndex = 53;
            this.redistributable_CheckBox.Text = "Install Redistributables";
            this.redistributable_CheckBox.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.redistributable_CheckBox.UncheckedState.BorderRadius = 2;
            this.redistributable_CheckBox.UncheckedState.BorderThickness = 0;
            this.redistributable_CheckBox.UncheckedState.FillColor = System.Drawing.Color.White;
            this.redistributable_CheckBox.UseVisualStyleBackColor = true;
            this.redistributable_CheckBox.CheckedChanged += new System.EventHandler(this.RedistributableCheckBox_CheckedChanged);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // DragControl2
            // 
            this.DragControl2.TargetControl = this.Logo;
            // 
            // WindowAnimate
            // 
            this.WindowAnimate.AnimationType = Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_ACTIVATE;
            this.WindowAnimate.Interval = 200;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 4;
            this.siticoneControlBox1.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(557, 8);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(36, 26);
            this.siticoneControlBox1.TabIndex = 55;
            this.siticoneControlBox1.TabStop = false;
            // 
            // defender_CheckBox
            // 
            this.defender_CheckBox.AutoSize = true;
            this.defender_CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.defender_CheckBox.CheckedState.BorderRadius = 2;
            this.defender_CheckBox.CheckedState.BorderThickness = 0;
            this.defender_CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.defender_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.defender_CheckBox.ForeColor = System.Drawing.Color.White;
            this.defender_CheckBox.Location = new System.Drawing.Point(369, 283);
            this.defender_CheckBox.Name = "defender_CheckBox";
            this.defender_CheckBox.Size = new System.Drawing.Size(177, 19);
            this.defender_CheckBox.TabIndex = 56;
            this.defender_CheckBox.Text = "Disable Windows Defender";
            this.defender_CheckBox.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.defender_CheckBox.UncheckedState.BorderRadius = 2;
            this.defender_CheckBox.UncheckedState.BorderThickness = 0;
            this.defender_CheckBox.UncheckedState.FillColor = System.Drawing.Color.White;
            this.defender_CheckBox.UseVisualStyleBackColor = true;
            this.defender_CheckBox.CheckedChanged += new System.EventHandler(this.DefenderCheckBox_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(288, 320);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(71, 15);
            this.statusLabel.TabIndex = 57;
            this.statusLabel.Text = "StatusLabel";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Visible = false;
            // 
            // ProgressIndicator
            // 
            this.ProgressIndicator.CircleSize = 1F;
            this.ProgressIndicator.Location = new System.Drawing.Point(600, 305);
            this.ProgressIndicator.Name = "ProgressIndicator";
            this.ProgressIndicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.ProgressIndicator.Size = new System.Drawing.Size(35, 35);
            this.ProgressIndicator.TabIndex = 58;
            this.ProgressIndicator.Visible = false;
            // 
            // StartBtn
            // 
            this.StartBtn.CheckedState.Parent = this.StartBtn;
            this.StartBtn.CustomImages.Parent = this.StartBtn;
            this.StartBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.HoveredState.Parent = this.StartBtn;
            this.StartBtn.Location = new System.Drawing.Point(256, 308);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.ShadowDecoration.Parent = this.StartBtn;
            this.StartBtn.Size = new System.Drawing.Size(134, 33);
            this.StartBtn.TabIndex = 59;
            this.StartBtn.Text = "Start";
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // RedistributableInstaller
            // 
            this.RedistributableInstaller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RedistributableInstallerInstaller_DoWork);
            // 
            // DirectXInstaller
            // 
            this.DirectXInstaller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DirectXInstaller_DoWork);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(646, 351);
            this.Controls.Add(this.ProgressIndicator);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.defender_CheckBox);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.redistributable_CheckBox);
            this.Controls.Add(this.directX_CheckBox);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private Siticone.UI.WinForms.SiticoneControlBox controlBox;
        private Siticone.UI.WinForms.SiticoneElipse Rounded;
        private Siticone.UI.WinForms.SiticoneCheckBox redistributable_CheckBox;
        private Siticone.UI.WinForms.SiticoneCheckBox directX_CheckBox;
        private Siticone.UI.WinForms.SiticoneDragControl DragControl;
        private Siticone.UI.WinForms.SiticoneDragControl DragControl2;
        private Siticone.UI.WinForms.SiticoneAnimateWindow WindowAnimate;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneCheckBox defender_CheckBox;
        private Siticone.UI.WinForms.SiticoneShadowForm ShadowForm;
        private System.Windows.Forms.Label statusLabel;
        private Siticone.UI.WinForms.SiticoneProgressIndicator ProgressIndicator;
        private Siticone.UI.WinForms.SiticoneRoundedButton StartBtn;
        private System.ComponentModel.BackgroundWorker RedistributableInstaller;
        private System.ComponentModel.BackgroundWorker DirectXInstaller;
    }
}

