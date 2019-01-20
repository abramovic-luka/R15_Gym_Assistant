using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace R15_Gym_Assistant
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        string username;

        private void menu_Load(object sender, EventArgs e)
        {
            login log = new login();
            log.ShowDialog();

            username = log.usernames;
            labelWelcome.Text = "Welcome, " + username + "!";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            newProgram program = new newProgram();
            program.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            edit izmjeni = new edit();
            izmjeni.ShowDialog();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            users korisnici = new users();
            korisnici.ShowDialog();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            startTraining go = new startTraining();
            go.ShowDialog();
        }
    }
}
