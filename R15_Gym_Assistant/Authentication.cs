using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace R15_Gym_Assistant
{
    public class Authentication
    {
        public string connectionString { get; set; }
        string connection;

        public void getConnection()
        {
            connection = @"Data Source=dbGymAssistant.db; Version=3";
            connectionString = connection;
        }

        public void createDatabase()
        {
            if (!File.Exists("dbGymAssistant.db")){
                try
                {
                    File.Create("dbGymAssistant.db");
                    createTableAccounts();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                createTableAccounts();
            }
        }

        private void createTableAccounts()
        {
            try
            {
                getConnection();
                using (SQLiteConnection con = new SQLiteConnection(connection))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    
                    string query = @"CREATE TABLE IF NOT EXISTS Accounts(
                        Ime Text, 
                        Prezime Text, 
                        Username Text PRIMARY KEY, 
                        Password Text, 
                        Visina Text, 
                        Tezina Text, 
                        Gradja Text, 
                        Vrsta Text)";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
