using System.Threading.Channels;
using ASP.NET_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.Controllers
{
    public class ContactController : Controller
    {

        // AfficherContact
        private readonly HashSet<Contact> contacts = new();
        public IActionResult Index()
        {
          
            var contacts = new List<Contact>()
           {
            new Contact(2,"Granger", "Hermione", "17"),
            new Contact(3,"Weasley", "Ron", "17"),
            new Contact(4,"Malefoy", "Drago", "17"),
            new Contact(1,"Potter", "Harry", "17"),
            new Contact(5,"Dumbledore", "Albus", "115"),
            new Contact(6,"Rogue", "Severus", "38")
           };
            //ViewData["contacts"] = contacts;
            return View(contacts);
        }
        // AfficherContact
        public IActionResult Details(long id)
        {
            var foundcontacts = contacts.FirstOrDefault(c => c.Id == id);

            if (foundcontacts =! null)
            {
                return View(foundcontacts);
                

            }
            else
            {return View ("erreur");
            }
            
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if (ModelState.IsValid)
            {
                var newId = contacts.Max(c => c.Id) + 1;
                //contacts.Id = newId;
                contacts.Add(contact);
                return RedirectToAction("List");
            }else
            {
                return View();
            }
        }

    }
}
