using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMediaPlayer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Champ pour attribuer un nom à la playlist
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Bouton add
        private void add_playlist_Click(object sender, EventArgs e)
        {
            list_playlist.Items.Add(playlistName.Text);
            // list_playlist.Text = playlistName.Text;
        }
    }
}
