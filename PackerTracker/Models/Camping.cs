// In this class file, make sure the namespace matches the name of your project (the equivalent of ProjectName). For instance:
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Camping
  {
    public string Name { get; private set; }
    public bool Packed { get; private set; }
    public int Id { get; private set; }
    private static List<Camping> _instances = new List<Camping> {}; 

    public Camping(string name, bool packed) 
    {
      Name = name;
      Packed = packed;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Camping> GetAll()
    {
      return _instances;
    }
  }
}