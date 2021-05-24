using System.Collections.Generic;
using csgregslist.Models;

namespace csgregslist.DB
{
  public class FakeDB
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
      new Car( "Ford", "F150", 1985, 5075,"/placeHold.it","built tough" )
    };


  }
}

