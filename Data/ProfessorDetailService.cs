using MyCoreApp.Models;
using MyCoreApp.Data;

namespace MyCoreApp.Data
{
    public class ProfessorDetailService
    {
        GetDBInfo objUsers = new GetDBInfo();
        public async Task<Professor[]> GetProfessorInfo(String Conn)
        {
            Professor[] profObj;
            profObj = objUsers.GetProfessorInfo(Conn).Result.ToArray();
            return profObj;
        }
    }
}
