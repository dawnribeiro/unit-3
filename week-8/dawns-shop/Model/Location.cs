using System.Collections.Generic;
using dawns_shop.Migrations;

namespace dawns_shop.Model
{
  public class Location
  {
    public int Id { get; set; }
    public string Address { get; set; }
    public string ManagerName { get; set; }
    public string PhoneNumber { get; set; }

    public List<Plant> Plants { get; set; } = new List<Plant>();
  }
}


