using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;


namespace MyCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        // Stores form data
        public bool FormSubmitted { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Professor { get; private set; }
        public string CourseNumber { get; private set; }
        public string SectionNumber { get; private set; }
        public DateTime StartDate { get; private set; }
        public bool InPerson { get; private set; }
        public bool VirtualMeeting { get; private set; }
        public string Message { get; private set; }

        // Handle form submission
        public void OnPostSubmitForm()
        {
            FormSubmitted = true;

            // Retrieve form data from Request.Form
            Name = Request.Form["name"];
            Email = Request.Form["email"];
            Professor = Request.Form["professor"];
            CourseNumber = Request.Form["coursenumber"];
            SectionNumber = Request.Form["sectionnumber"];
            StartDate = DateTime.Parse(Request.Form["start-date"]);
            InPerson = Request.Form["inperson"].Count > 0;
            VirtualMeeting = Request.Form["virtual"].Count > 0;
            Message = Request.Form["message"];
        }

        /* RIP the hopes and dreams of this method
           public void SendEmail()
           {
               MailMessage message = new MailMessage();

               message.From = new MailAddress("atuofficehourscheduler@gmail.com");

               message.To.Add("tylerpeaster@gmail.com");

               message.Subject = "Subject of the email";

               message.Body = "Body of the email";

               SmtpClient client = new SmtpClient();

               client.Host = "smtp.gmail.com";
               client.Port = 465;

               client.EnableSsl = true;

               client.Credentials = new NetworkCredential("atuofficehourscheduler@gmail.com", "hyuuqnvsecptjhvd");

               try
               {
                   client.Send(message);
                   Console.WriteLine("Email sent successfully.");
               }
               catch (Exception ex)
               {
                   Console.WriteLine($"Error: {ex.Message}");
               }
           }
           */
    }
}
