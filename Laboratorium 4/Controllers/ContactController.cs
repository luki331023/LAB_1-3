using Laboratorium_4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Laboratorium_4.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.GetAllContacts());
        }

        // Zwracanie formularza dodawania kontaktu
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                // Zapamiętanie kontaktu - modelu
                _contactService.Add(model);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = _contactService.Find(id);

            if (contact == null)
            {
                return NotFound();
            }

            var details = new Details
            {
                Name = contact.Name,
                Email = contact.Email,
                Phone = contact.Phone,
                Birth = contact.Birth
            };

            return View(details);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var contact = _contactService.Find(id);

            if (contact == null)
            {
                return NotFound();
            }

            var edit = new Edit
            {
                Id = contact.id,
                Name = contact.Name,
                Email = contact.Email,
                Phone = contact.Phone,
                Birth = contact.Birth
            };

            return View(edit);
        }

        [HttpPost]
        public IActionResult Edit(Edit model)
        {
            if (ModelState.IsValid)
            {

                var contact = _contactService.Find(model.Id);

                if (contact == null)
                {
                    return NotFound();
                }

                contact.Name = model.Name;
                contact.Email = model.Email;
                contact.Phone = model.Phone;
                contact.Birth = model.Birth;

                _contactService.Update(contact);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _contactService.Find(id);

            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _contactService.RemoveById(id);
            return RedirectToAction("Index");
        }
    }
}
