using MyCoreApp.Models;
using MyCoreApp.Data;

namespace MyCoreApp.Data
{
    public class ProfessorDetailService
    {
        GetDBInfo objUsers = new GetDBInfo();
        public async Task<Professor[]> GetProfessorInfo()
        {
            Professor[] custsObjs;
            custsObjs = objUsers.GetProfessorInfo().Result.ToArray();
            return custsObjs;
        }
    }
}
