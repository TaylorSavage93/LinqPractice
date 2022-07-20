using System.Linq;

var videogames = new List<string>() { "minecraft", "farcry", "sims", "worldofwarcraft" };




IOrderedEnumerable<string> List
    = videogames.OrderBy(x => x.Length);


videogames.OrderBy(x => x.Length).ToList().ForEach(videogames => Console.WriteLine(videogames));  