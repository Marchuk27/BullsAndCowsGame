using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCowsGame
{
    public partial class ExitForm : Form {
        public ExitForm() {
            InitializeComponent();
        }

        private void ExitForm_Load(object sender, EventArgs e) {

        }

        private void YesExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void NoExitButton_Click(object sender, EventArgs e) {
            ActiveForm.Close();
        }
    }
}
