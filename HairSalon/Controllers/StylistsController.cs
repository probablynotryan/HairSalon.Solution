using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace HairSalon.Controllers
{
  public class StylistsController: Controller
  {
    private readonly SalonContext _db;

    public StylistsController(SalonContext db)
    {
      _db = db;
    }
  }
}
