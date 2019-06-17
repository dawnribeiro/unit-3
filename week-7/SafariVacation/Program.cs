using System;
using System.Linq;

namespace SafariVacation
{
  class Program
  {
    static void Main(string[] args)
    {
      var db = new AnimalsContext();
      var input = "";

      // var tiger = db.AnimalsSeen.FirstOrDefault(f => f.Species == "tiger");
      // tiger.CountOfTimesSeen = tiger.CountOfTimesSeen + 2;
      // tiger.LocationOfLastSeen = tiger.LocationOfLastSeen = "plains";
      // var allLions = db.AnimalsSeen.Where(animal => animal.Species == "lion");
      // db.AnimalsSeen.RemoveRange(allLions);

      // db.AnimalsSeen.Add(new AnimalsSeen
      // {
      //   Species = "lion",
      //   CountOfTimesSeen = 3,
      //   LocationOfLastSeen = "africa"
      // };
      // db.SaveChanges();

      Console.WriteLine("I heard you went on a Safari!");
      Console.WriteLine("What animals did you see, how many times, and where did you see them or would you like to see a list of the animals you saw at a (location)");
      input = Console.ReadLine();
      if (input == "location")
      {
        db.SaveChanges();
        Console.WriteLine("What was your favorite location?");
        input = Console.ReadLine();
        var favePlace = db.AnimalsSeen.Where(seen => seen.LocationOfLastSeen == input).OrderBy(seen => seen.Species);
        foreach (var seen in favePlace)
        {
          Console.WriteLine($"You saw {favePlace} while you were there");
        }
      }
      // var sum = db.AnimalsSeen.Sum(CountOfTimesSeen);
      else
      {
        var data = input.Split(", ");
        var newAnimal = new AnimalsSeen
        {
          Species = data[0],
          CountOfTimesSeen = int.Parse(data[1]),
          LocationOfLastSeen = data[2]
        };
        db.AnimalsSeen.Add(newAnimal);
        db.SaveChanges();
      }
    }
  }
}
