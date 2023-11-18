using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyCoreApp.Pages
{
    public class Search_PageModel : PageModel
    {
        [BindProperty]
        public string UserInput { get; set; }
        public bool ShowMessage { get; private set; }

        public void OnGet()
        {
            // This method is executed when the page is initially loaded.
            ShowMessage = false;
        }

        public void OnPost()
        {
            // This method is executed when the form is submitted.

            // Now, you can use the UserName property to access the user's input.
            // For this example, we'll store it in a C# variable named 'userInput'.
            string userInput = UserInput;

            // You can add your logic here, for example, storing it in a variable.

            // Returning a simple message for demonstration purposes.
            ShowMessage = true;
        }
    }
}
