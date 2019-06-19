using System;
using System.Collections.Generic;
using System.Linq;
using dawns_shop.Model;
using Microsoft.AspNetCore.Mvc;

namespace dawns_shop.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ItemsController : ControllerBase
  {
    private DatabaseContext db;

    public ItemsController()
    {
      this.db = new DatabaseContext();
    }


    [HttpPost]
    public ActionResult<Plant> Post([FromBody]Plant item)
    {
      db.Plants.Add(item);
      db.SaveChanges();
      return item;
    }
    [HttpGet]
    public ActionResult<List<Plant>> GetAll()
    {
      var rv = db.Plants;
      return rv.ToList();
    }

    [HttpGet("{Id}")]
    public ActionResult<Plant> GetOnePlant(int Id)
    {
      var onePlant = db.Plants.FirstOrDefault(f => f.Id == Id);
      return onePlant;
    }

    [HttpPut("{Id}")]
    public ActionResult<Plant> UpdateItem([FromRoute]int Id, [FromBody]Plant item)
    {
      var updatedPlant = db.Plants.FirstOrDefault(f => f.Id == Id);
      updatedPlant.NumberInStock = item.NumberInStock;
      updatedPlant.SKU = item.SKU;
      updatedPlant.Price = item.Price;
      db.SaveChanges();
      return updatedPlant;

    }
    [HttpDelete("{Id}")]
    public ActionResult DeleteItem(int Id)
    {
      var byeItem = db.Plants.FirstOrDefault(f => f.Id == Id);
      if (byeItem == null)
      {
        return NotFound();
      }
      else
      {
        db.Plants.Remove(byeItem);
        db.SaveChanges();
        return Ok();
      }
    }
    [HttpGet("OutOfStock")]
    public ActionResult<List<Plant>> OutOfStock()
    {
      var zeroLeft = db.Plants.Where(w => w.NumberInStock == 0);
      return zeroLeft.ToList();
    }

    [HttpGet("SKU{SKU}")]
    public ActionResult<Plant> BySKU(int SKU)
    {
      var searchBySKU = db.Plants.FirstOrDefault(f => f.SKU == SKU);
      return searchBySKU;
    }
  }
}