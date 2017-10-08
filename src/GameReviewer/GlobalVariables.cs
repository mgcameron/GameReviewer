using GameReviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviewer
{
    public static class GlobalVariables
    {
        //Creating a list property to store our games and setting it to an empty list
        public static List<Game> Games { get; set; } = new List<Game>();
    }
}
