using MyCoreApp.Models;
using MyCoreApp.Data;

namespace MyCoreApp.Data
{
    public class OfficeHoursDetailService
    {
        GetOfficeHours objUsers = new GetOfficeHours();
        public async Task<OfficeHours[]> GetOfficeHoursInfo()
        {
            OfficeHours[] ohObj;
            ohObj = objUsers.GetOfficeHoursInfo().Result.ToArray();
            return ohObj;
        }
    }
}
