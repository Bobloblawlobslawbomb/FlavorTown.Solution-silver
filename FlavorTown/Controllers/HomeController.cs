using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FlavorTown.Models;
using System.Collections.Generic;
using System.Linq;

namespace FlavorTown.Controllers
{
  public class HomeController : Controller
  {
    private readonly FlavorTownContext _db;
    public HomeController(FlavorTownContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Flavor> flavors = _db.Flavors.ToList();
      List<Treat> treats = _db.Treats.ToList();
      model.Add("flavors", flavors);
      model.Add("treats", treats);
      return View(model);
    }
  }
}