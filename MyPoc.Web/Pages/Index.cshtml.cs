using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPoc.Web.HttpClients;

namespace MyPoc.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IWebApi1Client webApi1;

        [BindProperty]
        public string webapi1value { get; set; }

        public IndexModel(IWebApi1Client webApi1)
        { 
            this.webApi1 = webApi1;
        }
        public async void OnGet()
        {
            string r = await webApi1.Get();
            webapi1value = r;
        }
    }
}
