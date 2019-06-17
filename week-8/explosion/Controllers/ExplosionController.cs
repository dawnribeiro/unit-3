using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace explosion.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> Result(string s)
    {
      var newString = "";
      foreach (var c in s)
      {
        newString += new String(c, int.Parse(c.ToString()));
      }

      return newString;
    }

  }
}