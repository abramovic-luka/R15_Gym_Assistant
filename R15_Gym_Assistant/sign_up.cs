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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        Authentication auth;
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textIme.Text != string.Empty
                && textPrezime.Text != string.Empty
                && textUsername.Text != string.Empty
                && textPassword.Text != string.Empty
                && textVisina.Text != string.Empty
                && textTezina.Text != string.Empty
                && comboGradja.Text != string.Empty
                && comboVrsta.Text != string.Empty)
            {
                checkDatabase(textUsername.Text);
            }
        }

        private void checkDatabase(string username)
        {
            auth = new Authentication();

            auth.createDatabase();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    con.Open();

                    int count = 0;
                    string query = @"SELECT * FROM Accounts WHERE Username='" + username + "'";
                    cmd.CommandText = query;
                    cmd.Connection = con;

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Korisnički račun NIJE stvoren!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (count == 0)
                    {
                        insertData(textIme.Text, textPrezime.Text, textUsername.Text, textPassword.Text, textVisina.Text, textTezina.Text, comboGradja.Text, comboVrsta.Text);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void insertData(string ime, string prezime, string username, string password, string visina, string tezina, string gradja, string vrsta)
        {
            auth = new Authentication();
            auth.getConnection();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = "INSERT INTO Accounts(Ime, Prezime, Username, Password, Visina, Tezina, Gradja, Vrsta)" +
                                             "VALUES(@ime, @prezime, @username, @password, @visina, @tezina, @gradja, @vrsta)";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@ime", ime));
                    cmd.Parameters.Add(new SQLiteParameter("@prezime", prezime));
                    cmd.Parameters.Add(new SQLiteParameter("@username", username));
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));
                    cmd.Parameters.Add(new SQLiteParameter("@visina", visina));
                    cmd.Parameters.Add(new SQLiteParameter("@tezina", tezina));
                    cmd.Parameters.Add(new SQLiteParameter("@gradja", gradja));
                    cmd.Parameters.Add(new SQLiteParameter("@vrsta", vrsta));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Korisnički račun je uspješno stvoren!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
