using Microsoft.AspNetCore.Http.Features;

namespace Tracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }
    public string Date { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string vendorName, string RegisterDate)
    {
      _instances.Add(this);
      Name = vendorName;
      Id = _instances.Count;
      Date = RegisterDate;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}