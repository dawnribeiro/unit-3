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



      Console.WriteLine("Lets go on a Safari");
      Console.WriteLine("What animals did you see, how many times, and where?");
      input = Console.ReadLine();
      if (input == "")
      {
        db.SaveChanges();
        Console.WriteLine("Wow! What was your favorite location?");
        input = Console.ReadLine();
        var location = db.AnimalsSeen.Where(w => w.LocationOfLastSeen == input);
        Console.WriteLine($"You saw {location}");

      }

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
