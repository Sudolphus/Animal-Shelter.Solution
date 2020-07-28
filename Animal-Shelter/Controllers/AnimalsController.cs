using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(ProjectNameContext db)
    {
      _db = db;
    }
  }
}