using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore.MVC.Models;
using NetCore.Services;

namespace NetCore.MVC.Controllers
{
    public class PersonViewController : Controller
    {
        private PersonService _service = new PersonService();

        public IActionResult Index()
        {
            var persons = _service.GetAll();
            var personsView = persons.Select(p => new PersonModel
                    {Name = p.Name, Lastname = p.Lastname, EmailAddress = p.EmailAddress, Age = p.Age, Dni = p.Dni})
                .ToArray();

            var personViewModel = new PersonViewModel {Persons = personsView, Person = new PersonModel()};
            return View(personViewModel);
        }

        public IActionResult GetPerson(string dni)
        {
            var persons = _service.GetAll();
            var personsView = persons.Select(p => new PersonModel
                    {Name = p.Name, Lastname = p.Lastname, EmailAddress = p.EmailAddress, Age = p.Age, Dni = p.Dni})
                .ToArray();

            var personEntity = _service.GetById(dni);
            var personModel = new PersonModel
            {
                Name = personEntity.Name, Lastname = personEntity.Lastname, EmailAddress = personEntity.EmailAddress,
                Age = personEntity.Age, Dni = personEntity.Dni
            };
            var personViewModel = new PersonViewModel {Persons = personsView, Person = personModel};

            return View("Index", personViewModel);
        }
    }
}