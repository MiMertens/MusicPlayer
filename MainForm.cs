using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlayer
{
    public partial class MainForm : Form
    {
        private MusicPlayer player;

        public MainForm()
        {
            InitializeComponent();
            player = new MusicPlayer();
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            if (rb_Song.Checked)
            {
                Artist artist = cb_Artist.SelectedItem as Artist;
                if (artist != null)
                {
                    Song song = new Song(tb_Naam.Text, Convert.ToInt32(num_Year.Value), artist);

                    player.Add(song);
                    lb_Song.Items.Add(song);
                    artist.Add(song);
                }
            }
            else if (rb_Artist.Checked)
            {
                Artist artistt = new Artist(tb_Naam.Text);

                player.Add(artistt);
                lb_Artist.Items.Add(artistt);
                cb_Artist.Items.Add(artistt);
            }
            else if (rb_Playlist.Checked)
            {
                Playlist playlist = new Playlist(tb_Naam.Text);

                player.Add(playlist);
                lb_Playlist.Items.Add(playlist);
            }
        }
    

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Song song = lb_Song.SelectedItem as Song;
            if (song != null)
            {
                player.Add(song);
                MessageBox.Show(song.ToString() + "  wordt nu afgespeeld");
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            player.StopPlaying();
        }
    }
}
