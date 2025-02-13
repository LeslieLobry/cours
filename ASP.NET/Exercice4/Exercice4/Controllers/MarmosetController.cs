using Exercice4.Data;
using Microsoft.AspNetCore.Mvc;
using Exercice4.Models;



namespace Exercice4.Controllers
{
    public class MarmosetController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MarmosetController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult List()
        {
            var marmosets = _db.Marmosets.ToList();
            return View(marmosets);
        }

        public IActionResult Details(long id)
        {
            var marmosetFound = _db.Marmosets.FirstOrDefault(c => c.Id == id);

            if (marmosetFound != null)
            {
                return View(marmosetFound);
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Marmoset marmoset)
        {
            if (ModelState.IsValid)
            {

                _db.Marmosets.Add(marmoset);
                _db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                return View(marmoset);
            }
        }

        public IActionResult CreateRandom()
        {


            var randomMarmoset = new Marmoset()
            {

                Nom = GenerateRandomString("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 8)
            };

            _db.Marmosets.Add(randomMarmoset);
            _db.SaveChanges();


            return RedirectToAction("List"); //pour retourner sur la list
        }

        private static string GenerateRandomString(string chars, int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public IActionResult Delete(int id)
        {
            var marmoset = _db.Marmosets.Find(id);
            if (marmoset != null)
            {
                _db.Marmosets.Remove(marmoset);
                _db.SaveChanges();
                return RedirectToAction("List");
            }

            return RedirectToAction("Index");
        }

    }
}
