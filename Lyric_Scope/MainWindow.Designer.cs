namespace LyricScope
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LyricsPanel = new System.Windows.Forms.Panel();
            this.CurrentSongDataPanel = new System.Windows.Forms.Panel();
            this.CurrentSongTrackName = new System.Windows.Forms.Label();
            this.CurrentSongAdditonalData = new System.Windows.Forms.Label();
            this.MainTextLabel = new System.Windows.Forms.Label();
            this.RootPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Play_PauseButton = new System.Windows.Forms.Button();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.LyricsPanel.SuspendLayout();
            this.CurrentSongDataPanel.SuspendLayout();
            this.RootPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LyricsPanel
            // 
            this.LyricsPanel.AutoScroll = true;
            this.LyricsPanel.AutoSize = true;
            this.LyricsPanel.BackColor = System.Drawing.Color.DimGray;
            this.LyricsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LyricsPanel.Controls.Add(this.CurrentSongDataPanel);
            this.LyricsPanel.Controls.Add(this.MainTextLabel);
            this.LyricsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LyricsPanel.Location = new System.Drawing.Point(0, 0);
            this.LyricsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LyricsPanel.Name = "LyricsPanel";
            this.LyricsPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.LyricsPanel.Size = new System.Drawing.Size(1358, 1066);
            this.LyricsPanel.TabIndex = 0;
            this.LyricsPanel.SizeChanged += new System.EventHandler(this.LyricsPanel_SizeChanged);
            // 
            // CurrentSongDataPanel
            // 
            this.CurrentSongDataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentSongDataPanel.AutoSize = true;
            this.CurrentSongDataPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentSongDataPanel.Controls.Add(this.CurrentSongTrackName);
            this.CurrentSongDataPanel.Controls.Add(this.CurrentSongAdditonalData);
            this.CurrentSongDataPanel.Location = new System.Drawing.Point(-2, 1012);
            this.CurrentSongDataPanel.Name = "CurrentSongDataPanel";
            this.CurrentSongDataPanel.Size = new System.Drawing.Size(454, 50);
            this.CurrentSongDataPanel.TabIndex = 4;
            // 
            // CurrentSongTrackName
            // 
            this.CurrentSongTrackName.AutoSize = true;
            this.CurrentSongTrackName.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentSongTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSongTrackName.Location = new System.Drawing.Point(0, 0);
            this.CurrentSongTrackName.Name = "CurrentSongTrackName";
            this.CurrentSongTrackName.Size = new System.Drawing.Size(49, 17);
            this.CurrentSongTrackName.TabIndex = 0;
            this.CurrentSongTrackName.Text = "Track";
            // 
            // CurrentSongAdditonalData
            // 
            this.CurrentSongAdditonalData.AutoSize = true;
            this.CurrentSongAdditonalData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CurrentSongAdditonalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSongAdditonalData.Location = new System.Drawing.Point(0, 33);
            this.CurrentSongAdditonalData.Name = "CurrentSongAdditonalData";
            this.CurrentSongAdditonalData.Size = new System.Drawing.Size(63, 17);
            this.CurrentSongAdditonalData.TabIndex = 3;
            this.CurrentSongAdditonalData.Text = "AddData";
            // 
            // MainTextLabel
            // 
            this.MainTextLabel.AutoSize = true;
            this.MainTextLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MainTextLabel.Location = new System.Drawing.Point(0, 25);
            this.MainTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTextLabel.Name = "MainTextLabel";
            this.MainTextLabel.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.MainTextLabel.Size = new System.Drawing.Size(78, 119);
            this.MainTextLabel.TabIndex = 0;
            this.MainTextLabel.Text = "loading...";
            this.MainTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RootPanel
            // 
            this.RootPanel.AutoScroll = true;
            this.RootPanel.AutoScrollMargin = new System.Drawing.Size(0, 5);
            this.RootPanel.Controls.Add(this.SidePanel);
            this.RootPanel.Controls.Add(this.LyricsPanel);
            this.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootPanel.Location = new System.Drawing.Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.Size = new System.Drawing.Size(1358, 1066);
            this.RootPanel.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.Controls.Add(this.groupBox1);
            this.SidePanel.Controls.Add(this.SearchField);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SidePanel.Location = new System.Drawing.Point(1237, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(121, 1066);
            this.SidePanel.TabIndex = 1;
            // 
            // Play_PauseButton
            // 
            this.Play_PauseButton.Location = new System.Drawing.Point(33, 30);
            this.Play_PauseButton.Name = "Play_PauseButton";
            this.Play_PauseButton.Size = new System.Drawing.Size(57, 23);
            this.Play_PauseButton.TabIndex = 3;
            this.Play_PauseButton.Text = "Play";
            this.Play_PauseButton.UseVisualStyleBackColor = true;
            this.Play_PauseButton.Click += new System.EventHandler(this.Play_Pause);
            // 
            // SearchField
            // 
            this.SearchField.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchField.Location = new System.Drawing.Point(0, 0);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(121, 20);
            this.SearchField.TabIndex = 2;
            this.SearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchField_KeyPress);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NextBtn);
            this.groupBox1.Controls.Add(this.PreviousBtn);
            this.groupBox1.Controls.Add(this.Play_PauseButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 1005);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Location = new System.Drawing.Point(6, 30);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(21, 23);
            this.PreviousBtn.TabIndex = 5;
            this.PreviousBtn.Text = "P";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(96, 30);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(19, 23);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "N";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1358, 1066);
            this.Controls.Add(this.RootPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lyric Scope";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.LyricsPanel.ResumeLayout(false);
            this.LyricsPanel.PerformLayout();
            this.CurrentSongDataPanel.ResumeLayout(false);
            this.CurrentSongDataPanel.PerformLayout();
            this.RootPanel.ResumeLayout(false);
            this.RootPanel.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LyricsPanel;
        private System.Windows.Forms.Label MainTextLabel;
        private System.Windows.Forms.Panel RootPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label CurrentSongTrackName;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Label CurrentSongAdditonalData;
        private System.Windows.Forms.Panel CurrentSongDataPanel;
        private System.Windows.Forms.Button Play_PauseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}