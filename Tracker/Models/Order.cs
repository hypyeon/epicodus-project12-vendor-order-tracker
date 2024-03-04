namespace Tracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public int Id { get; }
    public string Date { get; set; }
    public string Price { get; set; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string productName, string orderDate, string price)
    {
      _instances.Add(this);
      Name = productName;
      Id = _instances.Count;
      Date = orderDate;
      Price = price;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}