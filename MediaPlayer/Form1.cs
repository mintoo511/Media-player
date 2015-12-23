using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpgn|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
          //      openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpgn|all files|*.*";
             //   if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
     
      /*  private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A basic Media Player version 1.0 ");
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("please help yourself\nor use www.google.com");
        } */

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A basic Media Player version 1.0 ");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("please help yourself\nor use www.google.com");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpgn|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //      openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpgn|all files|*.*";
                //   if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(srt)|*.srtn|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //      openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpgn|all files|*.*";
                //   if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
