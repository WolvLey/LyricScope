namespace LyricScope
{
    partial class ConfigurationWindow
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
            this.Button_Accept = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Left = new System.Windows.Forms.RadioButton();
            this.Button_Right = new System.Windows.Forms.RadioButton();
            this.Button_Center = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_Alignment = new System.Windows.Forms.Label();
            this.Label_Background = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Accept
            // 
            this.Button_Accept.Location = new System.Drawing.Point(12, 226);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(75, 23);
            this.Button_Accept.TabIndex = 0;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(197, 226);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 1;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_Left
            // 
            this.Button_Left.AutoSize = true;
            this.Button_Left.Location = new System.Drawing.Point(3, 3);
            this.Button_Left.Name = "Button_Left";
            this.Button_Left.Size = new System.Drawing.Size(43, 17);
            this.Button_Left.TabIndex = 2;
            this.Button_Left.TabStop = true;
            this.Button_Left.Text = "Left";
            this.Button_Left.UseVisualStyleBackColor = true;
            // 
            // Button_Right
            // 
            this.Button_Right.AutoSize = true;
            this.Button_Right.Location = new System.Drawing.Point(114, 3);
            this.Button_Right.Name = "Button_Right";
            this.Button_Right.Size = new System.Drawing.Size(50, 17);
            this.Button_Right.TabIndex = 3;
            this.Button_Right.TabStop = true;
            this.Button_Right.Text = "Right";
            this.Button_Right.UseVisualStyleBackColor = true;
            // 
            // Button_Center
            // 
            this.Button_Center.AutoSize = true;
            this.Button_Center.Location = new System.Drawing.Point(52, 3);
            this.Button_Center.Name = "Button_Center";
            this.Button_Center.Size = new System.Drawing.Size(56, 17);
            this.Button_Center.TabIndex = 4;
            this.Button_Center.TabStop = true;
            this.Button_Center.Text = "Center";
            this.Button_Center.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.Button_Left);
            this.flowLayoutPanel1.Controls.Add(this.Button_Center);
            this.flowLayoutPanel1.Controls.Add(this.Button_Right);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 30);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Label_Alignment
            // 
            this.Label_Alignment.AutoSize = true;
            this.Label_Alignment.Location = new System.Drawing.Point(9, 113);
            this.Label_Alignment.Name = "Label_Alignment";
            this.Label_Alignment.Size = new System.Drawing.Size(77, 13);
            this.Label_Alignment.TabIndex = 6;
            this.Label_Alignment.Text = "Text Alignment";
            // 
            // Label_Background
            // 
            this.Label_Background.AutoSize = true;
            this.Label_Background.Location = new System.Drawing.Point(9, 30);
            this.Label_Background.Name = "Label_Background";
            this.Label_Background.Size = new System.Drawing.Size(88, 13);
            this.Label_Background.TabIndex = 7;
            this.Label_Background.Text = "Backgroundcolor";
            // 
            // ConfigurationWindow
            // 
            this.AcceptButton = this.Button_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Label_Background);
            this.Controls.Add(this.Label_Alignment);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigurationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration Window";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.RadioButton Button_Left;
        private System.Windows.Forms.RadioButton Button_Right;
        private System.Windows.Forms.RadioButton Button_Center;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Label_Alignment;
        private System.Windows.Forms.Label Label_Background;
    }
}