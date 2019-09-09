using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace MyCoreApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            string directory = Environment.CurrentDirectory;
            Message = String.Format("Twoja katalog to  {0}.", directory);
        }
    }
}
