using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController: Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Create(int stylistId)
    {
      ViewBag.StylistId = stylistId;
      return View();
    }

    [HttpGet("/Clients")]
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }

    [HttpPost]
    public ActionResult Create(Client client, string StylistId)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Details", "Stylists", new {id = StylistId});
    }
  }
}
