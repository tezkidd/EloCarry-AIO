namespace EloCarry_AIO.UI
{
    partial class MessageBox
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
            this.DragControlArea = new Siticone.UI.WinForms.SiticonePanel();
            this.CloseButton = new Siticone.UI.WinForms.SiticoneControlBox();
            this.msgBox_Title = new System.Windows.Forms.Label();
            this.DragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.DragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.Ok_Btn = new Siticone.UI.WinForms.SiticoneButton();
            this.msgBox_Label = new System.Windows.Forms.Label();
            this.ShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.Rounded = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.Ok_CloseBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.DragControlArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControlArea
            // 
            this.DragControlArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.DragControlArea.Controls.Add(this.CloseButton);
            this.DragControlArea.Controls.Add(this.msgBox_Title);
            this.DragControlArea.Location = new System.Drawing.Point(-1, 0);
            this.DragControlArea.Margin = new System.Windows.Forms.Padding(2);
            this.DragControlArea.Name = "DragControlArea";
            this.DragControlArea.ShadowDecoration.Parent = this.DragControlArea;
            this.DragControlArea.Size = new System.Drawing.Size(367, 28);
            this.DragControlArea.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.CloseButton.HoveredState.Parent = this.CloseButton;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(322, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedColor = System.Drawing.Color.White;
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(40, 28);
            this.CloseButton.TabIndex = 2;
            // 
            // msgBox_Title
            // 
            this.msgBox_Title.AutoSize = true;
            this.msgBox_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox_Title.ForeColor = System.Drawing.Color.White;
            this.msgBox_Title.Location = new System.Drawing.Point(4, 4);
            this.msgBox_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgBox_Title.Name = "msgBox_Title";
            this.msgBox_Title.Size = new System.Drawing.Size(36, 17);
            this.msgBox_Title.TabIndex = 4;
            this.msgBox_Title.Text = "Title";
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // DragControl2
            // 
            this.DragControl2.TargetControl = this.msgBox_Title;
            // 
            // Ok_Btn
            // 
            this.Ok_Btn.CheckedState.Parent = this.Ok_Btn;
            this.Ok_Btn.CustomImages.Parent = this.Ok_Btn;
            this.Ok_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.Ok_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ok_Btn.ForeColor = System.Drawing.Color.White;
            this.Ok_Btn.HoveredState.Parent = this.Ok_Btn;
            this.Ok_Btn.Location = new System.Drawing.Point(284, 170);
            this.Ok_Btn.Name = "Ok_Btn";
            this.Ok_Btn.ShadowDecoration.Parent = this.Ok_Btn;
            this.Ok_Btn.Size = new System.Drawing.Size(65, 29);
            this.Ok_Btn.TabIndex = 50;
            this.Ok_Btn.Text = "OK";
            this.Ok_Btn.Click += new System.EventHandler(this.Ok_Btn_Click);
            // 
            // msgBox_Label
            // 
            this.msgBox_Label.AutoSize = true;
            this.msgBox_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.msgBox_Label.ForeColor = System.Drawing.Color.White;
            this.msgBox_Label.Location = new System.Drawing.Point(11, 46);
            this.msgBox_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgBox_Label.Name = "msgBox_Label";
            this.msgBox_Label.Size = new System.Drawing.Size(55, 15);
            this.msgBox_Label.TabIndex = 49;
            this.msgBox_Label.Text = "Message";
            // 
            // Rounded
            // 
            this.Rounded.BorderRadius = 10;
            this.Rounded.TargetControl = this;
            // 
            // Ok_CloseBtn
            // 
            this.Ok_CloseBtn.CheckedState.Parent = this.Ok_CloseBtn;
            this.Ok_CloseBtn.CustomImages.Parent = this.Ok_CloseBtn;
            this.Ok_CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(13)))));
            this.Ok_CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ok_CloseBtn.ForeColor = System.Drawing.Color.White;
            this.Ok_CloseBtn.HoveredState.Parent = this.Ok_CloseBtn;
            this.Ok_CloseBtn.Location = new System.Drawing.Point(284, 170);
            this.Ok_CloseBtn.Name = "Ok_CloseBtn";
            this.Ok_CloseBtn.ShadowDecoration.Parent = this.Ok_CloseBtn;
            this.Ok_CloseBtn.Size = new System.Drawing.Size(65, 29);
            this.Ok_CloseBtn.TabIndex = 51;
            this.Ok_CloseBtn.Text = "OK";
            this.Ok_CloseBtn.Visible = false;
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(361, 211);
            this.Controls.Add(this.Ok_Btn);
            this.Controls.Add(this.msgBox_Label);
            this.Controls.Add(this.DragControlArea);
            this.Controls.Add(this.Ok_CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.DragControlArea.ResumeLayout(false);
            this.DragControlArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticonePanel DragControlArea;
        private Siticone.UI.WinForms.SiticoneControlBox CloseButton;
        private System.Windows.Forms.Label msgBox_Title;
        private Siticone.UI.WinForms.SiticoneDragControl DragControl;
        private Siticone.UI.WinForms.SiticoneDragControl DragControl2;
        private Siticone.UI.WinForms.SiticoneButton Ok_Btn;
        private System.Windows.Forms.Label msgBox_Label;
        private Siticone.UI.WinForms.SiticoneShadowForm ShadowForm;
        private Siticone.UI.WinForms.SiticoneElipse Rounded;
        private Siticone.UI.WinForms.SiticoneButton Ok_CloseBtn;
    }
}