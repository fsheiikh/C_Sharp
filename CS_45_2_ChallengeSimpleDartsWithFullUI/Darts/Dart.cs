using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    [Serializable]

    public class Dart
    {
        private Random randomNumber;
        public int baseScore;
        public bool outerBand = false;
        public bool innerBand = false;


        //constructor take in instance of Random
        public Dart(Random random)
        {
            randomNumber = random;
        }

        //gets random from 0 t 21 and runs checkBonus 
        public void Throw()
        {
            baseScore = randomNumber.Next(21);

            checkForBonus(baseScore);
        }

        //runs another random to see if inner or outer bands were hit and resets those booleans
        private void checkForBonus(int baseScore)
        {
            int isBonus = randomNumber.Next(100);

            if (baseScore == 0 && (isBonus > 0 && isBonus < 6)) innerBand = true;
            else if (baseScore != 0 && (isBonus > 0 && isBonus < 6)) innerBand = true;
            else if (baseScore != 0 && (isBonus > 5 && isBonus < 11)) outerBand = true;
        }

    }
}
