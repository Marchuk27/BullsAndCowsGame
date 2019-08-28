using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using Un4seen.Bass;


namespace BullsAndCowsGame
{
    public partial class SettingsForm : Form
    {
        public SettingsForm() {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            if (musicState == true)
                MusicOnButton.Text = "Отключить музыку";
            else
                MusicOnButton.Text = "Включить музыку";
        }
        public static bool musicState = false;//состояние музыки вкл/выкл
        private void MusicButton_Click(object sender, EventArgs e) {
            musicState = !musicState;
            if (musicState == true) {
                MusicOnButton.Text = "Отключить музыку";
                PlayingMusic();
            }
            else {
                MusicOnButton.Text = "Включить музыку";
                SoundPlayer sound = new SoundPlayer();
                sound.Stop();
            }
        }
        public PictureBox pic1;//ссылка на pictureBox для смены фона
        public static void PlayingMusic() {
            var randomNum = new Random();   
            switch (randomNum.Next(1, 15))
              {
                  case 1:
                    var stream = Properties.Resources._01;
                    SoundPlayer sound = new SoundPlayer(stream);
                    sound.Play();
                    break;
                  case 2:
                    stream = Properties.Resources._02;
                    SoundPlayer sound1 = new SoundPlayer(stream);
                    sound1.Play();
                    break;
                  case 3:
                    stream = Properties.Resources._03;
                    SoundPlayer sound2 = new SoundPlayer(stream);
                    sound2.Play();
                    break;
                  case 4:
                    stream = Properties.Resources._04;
                    SoundPlayer sound3 = new SoundPlayer(stream);
                    sound3.Play();
                    break;
                  case 5:
                    stream = Properties.Resources._05;
                    SoundPlayer sound4 = new SoundPlayer(stream);
                    sound4.Play();
                    break;
                case 6:
                    stream = Properties.Resources._06;
                    SoundPlayer sound5 = new SoundPlayer(stream);
                    sound5.Play();
                    break;
                case 7:
                    stream = Properties.Resources._07;
                    SoundPlayer sound6 = new SoundPlayer(stream);
                    sound6.Play();
                    break;
                case 8:
                    stream = Properties.Resources._08;
                    SoundPlayer sound7 = new SoundPlayer(stream);
                    sound7.Play();
                    break;
                case 9:
                    stream = Properties.Resources._09;
                    SoundPlayer sound8 = new SoundPlayer(stream);
                    sound8.Play();
                    break;
                case 10:
                    stream = Properties.Resources._10;
                    SoundPlayer sound9 = new SoundPlayer(stream);
                    sound9.Play();
                    break;
                case 11:
                    stream = Properties.Resources._11;
                    SoundPlayer sound10 = new SoundPlayer(stream);
                    sound10.Play();
                    break;
                case 12:
                    stream = Properties.Resources._12;
                    SoundPlayer sound11 = new SoundPlayer(stream);
                    sound11.Play();
                    break;
                case 13:
                    stream = Properties.Resources._13;
                    SoundPlayer sound12 = new SoundPlayer(stream);
                    sound12.Play();
                    break;
                case 14:
                    stream = Properties.Resources._14;
                    SoundPlayer sound13 = new SoundPlayer(stream);
                    sound13.Play();
                    break;
                case 15:
                    stream = Properties.Resources._15;
                    SoundPlayer sound14 = new SoundPlayer(stream);
                    sound14.Play();
                    break;
              } 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            pic1.BackgroundImage = Properties.Resources.theme1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            pic1.BackgroundImage = Properties.Resources.theme2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            pic1.BackgroundImage = Properties.Resources.theme3;
        }
    }
}
