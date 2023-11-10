using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MyCoreApp.Models
{
    public class OfficeDatabaseContext
    {
        public string ConnectionString { get; set; }

        public OfficeDatabaseContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Professor> GetAllProfessor()
        {
            List<Professor> list = new List<Professor>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Album where id < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Professor()
                        {
                            ProfessorID = Convert.ToInt32(reader["ProfessorID"]),
                            FName = reader["FName"].ToString(),
                            LName = reader["LName"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            OfficeNum = reader["OfficeNum"].ToString(),
                            Department = reader["Department"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
