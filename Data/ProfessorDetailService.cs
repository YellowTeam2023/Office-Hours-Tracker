using MyCoreApp.Models;
using MyCoreApp.Data;

namespace MyCoreApp.Data
{
    public class ProfessorDetailService
    {
        GetDBInfo objUsers = new GetDBInfo();
        public async Task<Professor[]> GetProfessorInfo()
        {
            Professor[] profObj;
            profObj = objUsers.GetProfessorInfo().Result.ToArray();
            return profObj;
        }
    }
}
