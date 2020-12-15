using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMicromania.Controllers.Models
{
    public class Game
    {
       public int Id { get; set; }
       public string Name { get; set; }

       public string Genre { get; set; }

       public string Plateform { get; set; }
       public string Prix { get; set; }
    }
}
