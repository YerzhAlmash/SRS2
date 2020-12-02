using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace Shop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Name = "Almash";
        public string City = "Oral";
        public string NameState = "";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost(string n, string c)
        {

            if (n.Equals(Name) && c.Equals(City))
            {
                NameState = "OK";
                HttpContext.Session.SetString("Name", "Almash");
                HttpContext.Session.SetString("City", "Oral");

            }
            else
            {
                NameState = "ERROR";
            }
        }
        public IActionResult OnPostLogout()
        {
            HttpContext.Session.Clear();
            return RedirectToPage("Index");
        }
    }
}