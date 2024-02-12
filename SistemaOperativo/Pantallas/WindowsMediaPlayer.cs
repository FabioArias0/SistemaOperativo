using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOperativo.Pantallas
{
    public partial class WindowsMediaPlayer : Form
    {
        public WindowsMediaPlayer()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" }) 
            {
                if (ofd.ShowDialog() == DialogResult.OK) 
                {
                    List<mediaFile> files = new List<mediaFile>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new mediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    listFiles.DataSource = files;
                    
                }
            }
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediaFile file = listFiles.SelectedItem as mediaFile;
            if (file !=null)
            {
                axWindowsMediaPlayer.URL = file.Path;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void WindowsMediaPlayer_Load(object sender, EventArgs e)
        {
            listFiles.ValueMember = "Path";
            listFiles.DisplayMember = "FileName";
        }
    }
}
