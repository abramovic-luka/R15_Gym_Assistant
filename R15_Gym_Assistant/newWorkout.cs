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
    public partial class newWorkout : Form
    {
        public long id_programa;
        
        public newWorkout()
        {
            InitializeComponent();
        }

        private void newWorkout_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.id_programa.ToString());
            LoadData();
        }

        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

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

        //load DB
        private void LoadData()
        {
            SetConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "SELECT *FROM Workouts";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            con.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO Workouts(ID, Naziv, DioTijela, BrojSerija, BrojPonavljanja, Naputak)" +
                "VALUES('" + textID.Text + "','" + textNaziv.Text + "','" + textDioTijela.Text + "','" + textBrojSerija.Text + "','" + textBrojPonavljanja.Text + "','" + textNaputak.Text + "')";
            
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textNaziv.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textDioTijela.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBrojSerija.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBrojPonavljanja.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textNaputak.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
