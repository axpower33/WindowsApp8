using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
	public partial class Form19 : Form
	{
		public Form19()
		{
			InitializeComponent();
		}

		private void Form19_Load(object sender, EventArgs e)
		{
			//WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
			System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(
				@"C:\\Users\\User\\Music\\Playlists");

			System.IO.FileInfo[] files = dir.GetFiles();

			WMPLib.IWMPPlaylist playlist = wplayer.playlistCollection.newPlaylist("C:\\Users\\User\\Music\\Playlists\\Camila Cabello.wpl");

			foreach (System.IO.FileInfo file in files)
			{
				WMPLib.IWMPMedia media;
				media = wplayer.newMedia(file.FullName);
				playlist.appendItem(media);
			}
		
			wplayer.currentPlaylist = playlist;
			wplayer.settings.setMode("shuffle", true);
			wplayer.Ctlcontrols.play();
		}

	}
}
