using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class CampingController : Controller
  {

    [HttpGet("/camping")]
    public ActionResult Index()
    {
      List<Camping> allCamping = Camping.GetAll();
      return View(allCamping);
    }

    [HttpGet("/camping/new")]
    public ActionResult NewCampingForm()
    {
      return View();
    }

    [HttpPost("/camping")]
    public ActionResult NewCampingForm(string name, string packed)
    {
      Camping newCampingItem = new Camping(name, packed);
      return RedirectToAction("Index");
    }

    [HttpGet("/camping/delete")]
    public ActionResult DeleteAll()
    {
    Camping.ClearAll();
    return View();
    }

    [HttpGet("/camping/show")]
    public ActionResult Recommended()
    {
      return View();
    }
  }
}
    // [HttpGet("/cars")]
    // public ActionResult Index()
    // {
    //   List<Car> allCars = Car.GetAll();
    //   return View(allCars);
    // }