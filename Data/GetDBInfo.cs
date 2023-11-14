using MyCoreApp.Models;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace MyCoreApp.Data
{
    public class GetDBInfo
    {
        public async Task<Professor[]> GetProfessorInfo(String Conn)
        {
            List<Professor> list = new List<Professor>();
            using (MySqlConnection conn = OfficeDatabaseContext.GetConnection())
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(Conn, conn))
                {
                    using (MySqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            list.Add(new Professor()
                            {
                                ProfessorID = reader.GetInt32("ProfessorID"),
                                FName = GetStringOrNull(reader, "FName"),
                                LName = GetStringOrNull(reader, "LName"),
                                FullName = GetStringOrNull(reader, "FullName"),
                                Email = GetStringOrNull(reader, "Email"),
                                Phone = GetStringOrNull(reader, "Phone"),
                                OfficeNum = GetStringOrNull(reader, "OfficeNum"),
                                Department = GetStringOrNull(reader, "Department"),
                            });
                        }
                    }
                }
            }
            return list.ToArray();
        }

        private string GetStringOrNull(MySqlDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? null : reader.GetString(ordinal);
        }

    }
}
