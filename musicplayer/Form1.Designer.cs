namespace musicplayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.previous = new System.Windows.Forms.Button();
            this.musicList = new System.Windows.Forms.ListBox();
            this.play = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.volumeLevel = new System.Windows.Forms.TrackBar();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.volumeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // previous
            // 
            this.previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.previous.Location = new System.Drawing.Point(7, 419);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(110, 35);
            this.previous.TabIndex = 0;
            this.previous.Text = "◀◀";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // musicList
            // 
            this.musicList.FormattingEnabled = true;
            this.musicList.ItemHeight = 16;
            this.musicList.Location = new System.Drawing.Point(12, 114);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(311, 260);
            this.musicList.TabIndex = 1;
            this.musicList.SelectedIndexChanged += new System.EventHandler(this.musicList_SelectedIndexChanged);
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.play.Location = new System.Drawing.Point(123, 419);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(120, 35);
            this.play.TabIndex = 2;
            this.play.Text = "▶";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.next.Location = new System.Drawing.Point(249, 419);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(110, 35);
            this.next.TabIndex = 3;
            this.next.Text = "▶▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.open.Location = new System.Drawing.Point(7, 460);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(110, 35);
            this.open.TabIndex = 4;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pause.Location = new System.Drawing.Point(123, 460);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(120, 35);
            this.pause.TabIndex = 5;
            this.pause.Text = "▌ ▌";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop.Location = new System.Drawing.Point(249, 460);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(110, 35);
            this.stop.TabIndex = 6;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // volumeLevel
            // 
            this.volumeLevel.Location = new System.Drawing.Point(329, 114);
            this.volumeLevel.Maximum = 100;
            this.volumeLevel.Name = "volumeLevel";
            this.volumeLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeLevel.Size = new System.Drawing.Size(56, 260);
            this.volumeLevel.TabIndex = 7;
            this.volumeLevel.Value = 50;
            this.volumeLevel.Scroll += new System.EventHandler(this.volumeLevel_Scroll);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(10, 12);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(259, 120);
            this.player.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(10, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 136);
            this.textBox1.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 385);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 23);
            this.progressBar.TabIndex = 10;
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 504);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.volumeLevel);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.open);
            this.Controls.Add(this.next);
            this.Controls.Add(this.play);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "music player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.ListBox musicList;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TrackBar volumeLevel;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

