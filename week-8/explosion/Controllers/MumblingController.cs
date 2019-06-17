using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace explosion.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("ping")]
    public ActionResult<string> Ping()
    {
      return "pong";
    }
    [HttpGet("{s}")]
    public ActionResult<string> Result(string s)
    {
      return String.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }

  }
}
