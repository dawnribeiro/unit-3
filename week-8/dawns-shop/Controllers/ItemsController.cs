using System;
using dawns_shop.Model;
using Microsoft.AspNetCore.Mvc;

namespace dawns_shop.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ItemsController : ControllerBase
  {
    [HttpPost]
    public ActionResult<Plant> Post([FromBody]Plant item)
    {
      var db = new DatabaseContext();
      db.Plants.Add(item);
      db.SaveChanges();
      return item;



    }


  }
}