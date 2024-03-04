namespace Tracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public Vendor(string vendorName)
    {
      _instances.Add(this);
      Name = vendorName;
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}