namespace MyCoreApp.Models
{
    public class Professor
    {
        private Professor context;

        //Can't be NULL
        public int ProfessorID { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string FullName {  get; set; }

        //Can be NULL
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? OfficeNum { get; set; }
        public string? Department { get; set; }

    }
}
