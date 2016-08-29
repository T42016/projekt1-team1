using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_some_sound
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[8, 8];

        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\usr\Downloads\GameIntro.wav");
            player.Play();
        }


        private void btnSound_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\usr\Downloads\GameRight.wav");
            player.Play();
            ((Control)sender).BackColor = Color.LightGreen;
            
        }

        private void btnPlaySound2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\usr\Downloads\GameFailure.wav");
            player.Play();
            ((Control)sender).BackColor = Color.LightCoral;
        }

        private void btnPlaySound3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\usr\Downloads\GameFailure.wav");
            player.Play();
            ((Control)sender).BackColor = Color.LightCoral;
        }

        private void btnPlaySound4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\usr\Downloads\GameFailure.wav");
            player.Play();
            ((Control)sender).BackColor = Color.LightCoral;
        }

        
    }
}
