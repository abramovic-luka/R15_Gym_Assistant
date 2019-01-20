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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void users_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //set connection
        private void SetConnection()
        {
            con = new SQLiteConnection("Data Source=dbGymAssistant.db; Version=3; New=False; Compress=True;");
        }

        //set executequery code
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //set loadDB
        private void LoadData()
        {
            SetConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "SELECT *FROM Accounts";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            con.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO Accounts(Ime, Prezime, Username, Password, Visina, Tezina, Gradja, Vrsta)VALUES('" + textIme.Text + "','" + textPrezime.Text + "','" + textUsername.Text + "','" + textPassword.Text + "','" + textVisina.Text + "','" + textTezina.Text + "','" + comboGradja.Text + "','" + comboVrsta.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE Accounts SET Password='" + textPassword.Text + "', Visina='" + textVisina.Text + "', Tezina='" + textTezina.Text + "', Gradja='" + comboGradja.Text + "', Vrsta='" + comboVrsta.Text + "'  WHERE Username='" + textPassword.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM Accounts WHERE Username='" + textUsername.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textIme.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textPrezime.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textUsername.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textPassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textVisina.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textTezina.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboGradja.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboVrsta.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
