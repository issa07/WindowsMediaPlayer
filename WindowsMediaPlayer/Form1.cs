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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Pour ouvrir le fichier 
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = opf.FileName;
            }
        }

        // Pour lancer la musique ou la vidéo
        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            Button btnSender = (Button)sender;
        }

        // Pour arrêter
        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        // Pour mettre pause 
        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        // Reprendre
        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        // Reverse
        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        // Forward
        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        String[] paths, files;

        // Pour créer une playlist (btn_track_list)
        private void btn_track_list_open(object sender, EventArgs e)
        {
            // Create ListBox.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                    
                }
            }

        }

        // Pour selection une musique parmi la liste (Playlist)
        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[track_list.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();          
        }

        // Bouton pour à la musique précendente
        private void btn_previous_list(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        // Bouton pour passer à la musique suivante
        private void btn_next_list(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        // Bouton radion "Par artistes"
        private void radioBtn_par_nom(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        // Récupérer la valeur saisi de textBox2 puis filtrer
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // BindingSource ofd = new BindingSource();
            // bindingSource1.Filter = "'%" + textBox2.Text + "%'";

            for (int i = track_list.Items.Count - 1; i >= 0; i--)
            {
                if (track_list.Items[i].ToString().ToLower().Contains(textBox2.Text.ToLower()))
                {
                    track_list.SetSelected(i, true);
                }
            }

        }

        // Filrer par l'ordre alphabétique
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // 
            // Codes...
            //
        }

        // Navigation vers une nouvelle page (avec les panels) pour consulter les playlist
        private void btn_create_playlist_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

    }

}

