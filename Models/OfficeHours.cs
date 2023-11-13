namespace MyCoreApp.Models
{
    public class OfficeHours
    {
        public int SlotID { get; set; }
        public int ProfessorID { get; set; }
        public string DayOfWeek { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
