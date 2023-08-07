using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Game
    {
        //Properties of Game
        public string title;
        public string gameType;
        public int rating;

        //Constructor
        public Game(string aTitle, string aType, int aRating)
        {
            title = aTitle;
            gameType = aType;
            rating = aRating;
        }
    }
}
