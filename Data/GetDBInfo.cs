using MyCoreApp.Models;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace MyCoreApp.Data
{
    public class GetDBInfo
    {
        public async Task<Professor[]> GetProfessorInfo()
        {
            List<Professor> list = new List<Professor>();
            using (MySqlConnection conn = OfficeDatabaseContext.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Professor", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Professor()
                            {
                                ProfessorID = reader.GetInt32("ProfessorID"),
                                FName = reader.GetString("FName"),
                                LName = reader.GetString("LName"),
                                FullName = reader.GetString("FullName"),
                                Email = reader.GetString("Email"),
                                Phone = reader.GetString("Phone"),
                                OfficeNum = reader.GetString("OfficeNum"),
                                Department = reader.GetString("Department"),
                            });
                        }
                    }
                }
            }
            return list.ToArray();
        }
    }
}
