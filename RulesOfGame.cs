using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BullsAndCowsGame
{
    public partial class RulesOfGame : Form {
        public RulesOfGame() {
            InitializeComponent();
        }
        string path = MainForm.path_;
        private void RulesOfGame_Load(object sender, EventArgs e) {
            InfoButton.Text = File.ReadAllText(path + "/rules.txt", Encoding.UTF8);   
        }        
    }
}
