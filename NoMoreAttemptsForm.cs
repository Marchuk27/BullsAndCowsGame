using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;



namespace BullsAndCowsGame
{
    public partial class NoMoreAttemptsForm : Form
    {
        public NoMoreAttemptsForm() {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            ExitForm ef = new ExitForm();
            ef.ShowDialog();
        }

        private void PlayOneMoreTimeButton_Click(object sender, EventArgs e) {
            GameMediumForm gmf = new GameMediumForm(); 
            gmf.Dispose();
            this.Close();
        }

        private void NoMoreAttemptsForm_Load(object sender, EventArgs e) {
            AnswerNumLabel.Text = "Загаданное число: " + GameMediumForm.answerNum;
            var stream = Properties.Resources.cowsound;
            SoundPlayer sound = new SoundPlayer(stream);
            sound.Play();
            //отображение таблицы в графич.интерфейсе формы
            if (File.Exists("recordtable.txt"))
            {
                string[] a = File.ReadAllLines("recordtable.txt");
                int stringCounter = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    stringCounter++;
                    int index = a[i].LastIndexOf(' ');
                    //присвоение текстовым значениям лэйбла текста из док-та
                    switch (stringCounter)
                    {
                        case 1:
                            fstPlayerNameLabel.Text = a[0].Substring(0, index - 3);
                            fstPlayerResultLabel.Text = a[0].Substring(index);
                            fstPlayerNameLabel.Visible = true;
                            fstPlayerResultLabel.Visible = true;
                            fstRank.Visible = true;
                            break;
                        case 2:
                            scndPlayerNameLabel.Text = a[1].Substring(0, index - 3);
                            scndPlayerResultLabel.Text = a[1].Substring(index);
                            scndPlayerNameLabel.Visible = true;
                            scndPlayerResultLabel.Visible = true;
                            scndRank.Visible = true;
                            break;
                        case 3:
                            thrdPlayerNameLabel.Text = a[2].Substring(0, index - 3);
                            thrdPlayerResultLabel.Text = a[2].Substring(index);
                            thrdPlayerNameLabel.Visible = true;
                            thrdPlayerResultLabel.Visible = true;
                            thrdRank.Visible = true;
                            break;
                        case 4:
                            frthPlayerNameLabel.Text = a[3].Substring(0, index - 3);
                            frthPlayerResultLabel.Text = a[3].Substring(index);
                            frthPlayerNameLabel.Visible = true;
                            frthPlayerResultLabel.Visible = true;
                            frthRank.Visible = true;
                            break;
                        case 5:
                            fvthPlayerNameLabel.Text = a[4].Substring(0, index - 3);
                            fvthPlayerResultLabel.Text = a[4].Substring(index);
                            fvthPlayerNameLabel.Visible = true;
                            fvthPlayerResultLabel.Visible = true;
                            fvthRank.Visible = true;
                            break;
                    }
                }

            }
        }
    }
}
