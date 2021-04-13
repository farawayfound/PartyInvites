using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Collections.Generic;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // F i e l d s


        // C o n s t r u c t o r s


        // M e t h o d s

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            IActionResult answer = View(); // go look for RsvpForm.cshtml
            return answer;
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse gr)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(gr);

                return View("Thanks", gr); // go look for Thanks.cshtml and pass in gr
            }
            else
            {
                return View(gr);
            }
        }

        public IActionResult ListResponses()
        {
            List<GuestResponse> responses = Repository.GetResponse();
            List<GuestResponse> willAttend 
                = responses.Where(r => r.WillAttend == true).OrderBy(r => r.Name).ToList(); // LInQ Language Inegrated Query
            return View(willAttend);
        }
    }
}
