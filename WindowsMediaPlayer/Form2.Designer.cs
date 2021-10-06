
namespace WindowsMediaPlayer
{
    partial class Form2
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
            this.quitter = new System.Windows.Forms.Button();
            this.add_playlist = new System.Windows.Forms.Button();
            this.playlistName = new System.Windows.Forms.TextBox();
            this.list_playlist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // quitter
            // 
            this.quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter.Location = new System.Drawing.Point(12, 12);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(82, 41);
            this.quitter.TabIndex = 0;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // add_playlist
            // 
            this.add_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_playlist.Location = new System.Drawing.Point(123, 12);
            this.add_playlist.Name = "add_playlist";
            this.add_playlist.Size = new System.Drawing.Size(48, 41);
            this.add_playlist.TabIndex = 1;
            this.add_playlist.Text = "+";
            this.add_playlist.UseVisualStyleBackColor = true;
            this.add_playlist.Click += new System.EventHandler(this.add_playlist_Click);
            // 
            // playlistName
            // 
            this.playlistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistName.Location = new System.Drawing.Point(177, 12);
            this.playlistName.Name = "playlistName";
            this.playlistName.Size = new System.Drawing.Size(246, 36);
            this.playlistName.TabIndex = 2;
            this.playlistName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // list_playlist
            // 
            this.list_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_playlist.FormattingEnabled = true;
            this.list_playlist.ItemHeight = 24;
            this.list_playlist.Location = new System.Drawing.Point(12, 88);
            this.list_playlist.Name = "list_playlist";
            this.list_playlist.Size = new System.Drawing.Size(505, 76);
            this.list_playlist.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 166);
            this.Controls.Add(this.list_playlist);
            this.Controls.Add(this.playlistName);
            this.Controls.Add(this.add_playlist);
            this.Controls.Add(this.quitter);
            this.Name = "Form2";
            this.Text = "Form 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button add_playlist;
        private System.Windows.Forms.TextBox playlistName;
        private System.Windows.Forms.ListBox list_playlist;
    }
}