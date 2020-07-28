using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index(bool sortByName = true, bool sortByDate = false, bool sortByBreed = false)
    {
      IEnumerable<Animal> model = _db.Animals.ToList();
      if (sortByDate)
      {
        model = model.OrderBy(animal => animal.DateOfAdmittance);
      }
      else if (sortByBreed)
      {
        model = model.OrderBy(animal => animal.Breed);
      }
      else if (sortByName)
      {
        model = model.OrderBy(animal => animal.Name);
      }
      // IEnumerable<Animal> model = _db.Animals.ToList().OrderBy(animal => animal.Name);
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
      return View(thisAnimal);
    }
  }
}