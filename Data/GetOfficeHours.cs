using MyCoreApp.Models;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace MyCoreApp.Data
{
    public class GetOfficeHours
    {
        public async Task<OfficeHours[]> GetOfficeHoursInfo(String Conn)
        {
            List<OfficeHours> list = new List<OfficeHours>();
            using (MySqlConnection conn = OfficeDatabaseContext.GetConnection())
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(Conn, conn))
                {
                    using (MySqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            list.Add(new OfficeHours()
                            {
                                SlotID = reader.GetInt32("SlotID"),
                                ProfessorID = reader.GetInt32("ProfessorID"),
                                DayOfWeek = GetStringOrNull(reader, "DayOfWeek"),
                                StartTime = GetStringOrNull(reader, "StartTime"),
                                EndTime = GetStringOrNull(reader, "EndTime")
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
