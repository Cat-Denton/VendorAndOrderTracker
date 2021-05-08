using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public bool IsClosed { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public int Id { get; }
  }
}