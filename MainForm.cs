using System;
using System.Windows.Forms;

namespace BullsAndCowsGame
{
    public partial class MainForm : Form
    {
        public static string path_ = Environment.CurrentDirectory;

        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            toolTip1.SetToolTip(this.InfoButton, "Правила игры");
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            ExitForm ef = new ExitForm();
            ef.ShowDialog();
        }

        private void SettingsButton_Click(object sender, EventArgs e) {
            SettingsForm b = new SettingsForm();
            b.Owner = this;
            b.pic1 = this.pictureBox1;
            b.Show();
        }

        private void StartGameButton_Click(object sender, EventArgs e) {
            GameMediumForm frm = new GameMediumForm();
            frm.ShowDialog();
        }

        private void InfoButton_Click(object sender, EventArgs e) {
            RulesOfGame f = new RulesOfGame();
            f.ShowDialog();
        }
        public void changePictureBox() {
            this.BackgroundImage = Properties.Resources.theme2;
        }

    }
}
