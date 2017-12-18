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
            this.MainTextLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RootPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Config = new System.Windows.Forms.Button();
            this.SpotifyData = new System.Windows.Forms.Label();
            this.LyricsPanel.SuspendLayout();
            this.RootPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LyricsPanel
            // 
            this.LyricsPanel.AutoScroll = true;
            this.LyricsPanel.AutoSize = true;
            this.LyricsPanel.BackColor = System.Drawing.Color.DimGray;
            this.LyricsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LyricsPanel.Controls.Add(this.MainTextLabel);
            this.LyricsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LyricsPanel.Location = new System.Drawing.Point(0, 0);
            this.LyricsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LyricsPanel.Name = "LyricsPanel";
            this.LyricsPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.LyricsPanel.Size = new System.Drawing.Size(488, 348);
            this.LyricsPanel.TabIndex = 0;
            this.LyricsPanel.SizeChanged += new System.EventHandler(this.LyricsPanel_SizeChanged);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RootPanel
            // 
            this.RootPanel.AutoScroll = true;
            this.RootPanel.AutoScrollMargin = new System.Drawing.Size(0, 5);
            this.RootPanel.Controls.Add(this.panel1);
            this.RootPanel.Controls.Add(this.LyricsPanel);
            this.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootPanel.Location = new System.Drawing.Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.Size = new System.Drawing.Size(488, 348);
            this.RootPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_Config);
            this.panel1.Controls.Add(this.SpotifyData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 27);
            this.panel1.TabIndex = 1;
            // 
            // Button_Config
            // 
            this.Button_Config.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Config.Location = new System.Drawing.Point(413, 0);
            this.Button_Config.Name = "Button_Config";
            this.Button_Config.Size = new System.Drawing.Size(75, 27);
            this.Button_Config.TabIndex = 1;
            this.Button_Config.Text = "Conf";
            this.Button_Config.UseVisualStyleBackColor = true;
            this.Button_Config.Click += new System.EventHandler(this.Button_Config_Click);
            // 
            // SpotifyData
            // 
            this.SpotifyData.AutoSize = true;
            this.SpotifyData.Location = new System.Drawing.Point(13, 4);
            this.SpotifyData.Name = "SpotifyData";
            this.SpotifyData.Size = new System.Drawing.Size(0, 13);
            this.SpotifyData.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(488, 348);
            this.Controls.Add(this.RootPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lyric Scope";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.LyricsPanel.ResumeLayout(false);
            this.LyricsPanel.PerformLayout();
            this.RootPanel.ResumeLayout(false);
            this.RootPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LyricsPanel;
        private System.Windows.Forms.Label MainTextLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel RootPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SpotifyData;
        private System.Windows.Forms.Button Button_Config;
    }
}