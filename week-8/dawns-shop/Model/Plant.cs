using System;

namespace dawns_shop.Model
{
  public class Plant
  {
    public int Id { get; set; }
    public int SKU { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public int NumberInStock { get; set; }
    public float Price { get; set; }
    public DateTime DateOfOrder { get; set; } = DateTime.Now;
  }
}