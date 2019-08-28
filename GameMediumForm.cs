using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace BullsAndCowsGame
{
    public partial class GameMediumForm : Form {
        public GameMediumForm() {
            InitializeComponent();
        }

        public static string answerNum;
        private void GameActiveForm_Load(object sender, EventArgs e) {
            if (SettingsForm.musicState == true) {
                SoundButton.Image = Image.FromFile(path + "\\sound.png");
                toolTip1.SetToolTip(this.SoundButton, "Отключить музыку");
            }
            else {
                SoundButton.Image = Image.FromFile(path + "\\sound1.png");
                toolTip1.SetToolTip(this.SoundButton, "Включить музыку");
            }
            var rnd = new Random();
            int GenNumber = rnd.Next(100, 999); //генерация случайного числа
            TrueNumLabel.Text = GenNumber.ToString();
            answerNum = TrueNumLabel.Text;
            n = 0;//кол-во попыток
            if (String.IsNullOrEmpty(EnterNumTextBox.Text)) {
                CheckResultButton.Enabled = false;
            }
        }

        private void EnterNumTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            char number = e.KeyChar;//символ введенный в textbox
            if (number != 8 && e.KeyChar <= 47 || e.KeyChar >= 58) {
                errorProvider1.SetError(EnterNumTextBox, "Введите трехзначное число!");
                CheckResultButton.Enabled = false;
            }
            else {
                CheckResultButton.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void EnterNumTextBox_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(EnterNumTextBox.Text)) {
                errorProvider1.SetError(EnterNumTextBox, "Введите число!");
                CheckResultButton.Enabled = false;
            }
            else if (EnterNumTextBox.Text.Length != 3) {
                errorProvider1.SetError(EnterNumTextBox, "Введите трехзначное число!");
                CheckResultButton.Enabled = false;
            }
        }

        string path = MainForm.path_; //путь к рабочей папке
        private void SoundButton_Click(object sender, EventArgs e)
        {
            SettingsForm.musicState = !SettingsForm.musicState;
            if (SettingsForm.musicState == true)
            {
                SettingsForm.PlayingMusic();
                SoundButton.Image = Image.FromFile(path + "\\sound.png");
                toolTip1.SetToolTip(this.SoundButton, "Выключить музыку");
            }
            else
            {
                SoundPlayer sound = new SoundPlayer();
                sound.Stop();
                SoundButton.Image = Image.FromFile(path + "\\sound1.png");
                toolTip1.SetToolTip(this.SoundButton, "Включить музыку");
            }
        }
        //функция подсчета быков
        public string CheckBullFunction(string num, string answerNum)
        {
            int BullCount = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == answerNum[i])
                    BullCount++;
            }
            return BullCount.ToString();
        }
        //функция подсчета коров
        public string CheckCowFunction(string num, string answerNum)
        {
            int cowCounter = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int k = 0; k < answerNum.Length; k++)
                {
                    if (i != k && num[i] == answerNum[k])
                        cowCounter++;
                }
            }
            return cowCounter.ToString();
        }
        public static string textNikVar;//переменная, хранящая Ник user'а 
        private void EnterNikButton_Click(object sender, EventArgs e)
        {
            textNikVar = EnterNicknameTextBox.Text.ToString();
            EnterNicknameLabel.Visible = false;
            EnterNicknameTextBox.Visible = false;
            EnterNicknameButton.Visible = false;
            EnterNumLabel.Visible = true;
            EnterNumTextBox.Visible = true;
            CheckResultButton.Visible = true;
        }

        CongratulationsForm victoryForm = new CongratulationsForm();
        public static int n = 0; //счетчик попыток
        private void CheckResultButton_Click(object sender, EventArgs e) {
            n++;
            if (n == 1 && EnterNumTextBox.Text == TrueNumLabel.Text) {
                this.Close();
                victoryForm.ShowDialog();
            }

            else  if (n == 1) {
                Num1.Text = EnterNumTextBox.Text;
                Num1.Show(); Step1Label.Show();
                BullAmount1.Text = CheckBullFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                BullAmount1.Show();
                CowAmount1.Text = CheckCowFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                CowAmount1.Show();
            }

            if (n == 2 && EnterNumTextBox.Text == TrueNumLabel.Text)
                victoryForm.ShowDialog();

            else if (n == 2) {
                Num2.Text = EnterNumTextBox.Text;
                Num2.Show(); Step2Label.Show();
                BullAmount2.Text = CheckBullFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                BullAmount2.Show();
                CowAmount2.Text = CheckCowFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                CowAmount2.Show();
            }

            if (n == 3 && EnterNumTextBox.Text == TrueNumLabel.Text) {
                this.Close();
                victoryForm.ShowDialog();
            }
            else if (n == 3) {
                Num3.Text = EnterNumTextBox.Text;
                Num3.Show(); Step3Label.Show();
                BullAmount3.Text = CheckBullFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                BullAmount3.Show();
                CowAmount3.Text = CheckCowFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                CowAmount3.Show();
            }

            if (n == 4 && EnterNumTextBox.Text == TrueNumLabel.Text) {
                this.Close();
                victoryForm.ShowDialog();
            }

            else if (n == 4) {
                Num4.Text = EnterNumTextBox.Text;
                Num4.Show(); Step4Label.Show();
                BullAmount4.Text = CheckBullFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                BullAmount4.Show();
                CowAmount4.Text = CheckCowFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                CowAmount4.Show();
            }

            if (n == 5 && EnterNumTextBox.Text == TrueNumLabel.Text) {
                this.Close();
                victoryForm.ShowDialog();
            }

            else if (n == 5) {
                Num5.Text = EnterNumTextBox.Text;
                Num5.Show(); Step5Label.Show();
                BullAmount5.Text = CheckBullFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                BullAmount5.Show();
                CowAmount5.Text = CheckCowFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                CowAmount5.Show();
            }

            if (n == 6 && EnterNumTextBox.Text == TrueNumLabel.Text) {
                this.Close();
                victoryForm.ShowDialog();
            }

            else if (n == 6) {
                Num6.Text = EnterNumTextBox.Text;
                Num6.Show(); Step6Label.Show();
                BullAmount6.Text = CheckBullFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                BullAmount6.Show();
                CowAmount6.Text = CheckCowFunction(EnterNumTextBox.Text, TrueNumLabel.Text);
                CowAmount6.Show();
                this.Close();
                NoMoreAttemptsForm f1 = new NoMoreAttemptsForm();
                f1.ShowDialog();
            } 
        }
    }
}
