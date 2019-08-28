using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace BullsAndCowsGame
{
    public partial class CongratulationsForm : Form
    {
        public CongratulationsForm() {
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

        Dictionary<string, int> recordTable = new Dictionary<string, int>();

        private void CongratulationsForm_Load(object sender, EventArgs e)
        {
            AnswerNumLabel.Text = GameMediumForm.answerNum;
            SoundPlayer sound = new SoundPlayer(Properties.Resources.Congratulations);
            sound.Play();
            int rankingProcess = RankCalculating(GameMediumForm.n);
            if (rankingProcess != -2) {                
                File.AppendAllText("recordtable.txt", GameMediumForm.textNikVar + "    " + GameMediumForm.n + Environment.NewLine);
                string[] arr = File.ReadAllLines("recordtable.txt");
                for (int i = 0; i < arr.Length; i++) {
                    int index = arr[i].LastIndexOf(' ');
                    recordTable.Add(arr[i].Substring(0, index - 3), Convert.ToInt32(arr[i].Substring(index)));
                }
                //запись словаря в список и сортировка
                var myList = recordTable.ToList();
                myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
                File.WriteAllText("recordtable.txt", null);
                //добавление отсортированного списка в .txt-документ
                foreach (KeyValuePair<string, int> kvp in myList)
                {
                    File.AppendAllText("recordtable.txt", kvp.Key + "    " + kvp.Value + Environment.NewLine);
                }
            }
            //отображение таблицы в графич.интерфейсе формы
            string[] a = File.ReadAllLines("recordtable.txt");
            int stringCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                stringCounter++;
                int index = a[i].LastIndexOf(' ');
                //присвоение текстовым значениям лэйбла текста из таблицы рекордов
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

        private int RankCalculating(int n) {//функция добавления в таблицу рекордов
            if (File.Exists("recordtable.txt") == false) {
                File.AppendAllText("recordtable.txt", null);
            }
            string[] a = File.ReadAllLines("recordtable.txt");
            int stringIndex = -2;
            if (a.Length == 0)
                return -1;
            else
                for (int i = 0; i < a.Length; i++) {
                    int index = a[i].LastIndexOf(' ');
                    //конвертация строкового значения кол-ва попыток в целочисл.
                    int result = Convert.ToInt32(a[i].Substring(index)); 
                    if (n <= result){
                        stringIndex = i;
                        break;
                    }
                }
            return stringIndex;
        }
    }
}
