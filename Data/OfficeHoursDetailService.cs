using MyCoreApp.Models;
using MyCoreApp.Data;

namespace MyCoreApp.Data
{
    public class OfficeHoursDetailService
    {
        GetOfficeHours objUsers = new GetOfficeHours();
        public async Task<OfficeHours[]> GetOfficeHoursInfo(String Conn)
        {
            OfficeHours[] ohObj;
            ohObj = objUsers.GetOfficeHoursInfo(Conn).Result.ToArray();
            return ohObj;
        }
    }
}
