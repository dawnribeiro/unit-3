using System.Collections.Generic;
using System.Linq;
using dawns_shop.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dawns_shop.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LocationsController : ControllerBase
  {
    private DatabaseContext db;

    public LocationsController()
    {
      this.db = new DatabaseContext();
    }
    [HttpPost]

    public ActionResult<Location> PostLocation([FromBody]Location place)
    {
      db.Locations.Add(place);
      db.SaveChanges();
      return place;
    }

    [HttpGet]
    public ActionResult<List<Location>> AllLocations()
    {
      var rv = db.Locations;
      return rv.ToList();
    }

    // [HttpGet]
    // public ActionResult<List<Location>> GetLocations()

    // {
    //   var allItemsInLocations = db.Locations.Include(i => i.Plants);
    //   return allItemsInLocations.ToList();
    // }

  }

}