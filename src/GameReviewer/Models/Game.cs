using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviewer.Models
{
    public class Game
    {
        //These are our game properties
        public string Name { get; set; }
        public string Description { get; set; }

        //This is our game Create method, 
        //public means it can be called from anywhere in the project
        //static makes it a class method meaning we can just type Game.Create without needing to instantiate the method
        //void allows us to explicitly state that this method is to return nothing, not even null
        public static void Create (Game game)
        {
            GlobalVariables.Games.Add(game);
        }

        //This method returns all our games as a list
        public static List<Game> ReadAll()
        {
            return GlobalVariables.Games;
        }

        //This method returns a specific game
        public static Game Read(string name)
        {
            foreach(var game in GlobalVariables.Games)
            {
                if(game.Name == name)
                {
                    return game;
                }
            }
            return null;
        }
    }
}
