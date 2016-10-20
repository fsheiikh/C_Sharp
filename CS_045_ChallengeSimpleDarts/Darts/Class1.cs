using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        private Random randomNumber;
        public int baseScore;
        public bool outerBand = false;
        public bool innerBand = false;

        

        public Dart(Random random)
        {
            randomNumber = random;
        }


        public void Throw()
        {
            baseScore = randomNumber.Next(21);

            checkForBonus(baseScore);
        }


        private void checkForBonus(int baseScore)
        {
            int isBonus = randomNumber.Next(100);

            if (baseScore == 0 && (isBonus > 0 && isBonus < 6)) innerBand = true;
            else if (baseScore != 0 && (isBonus > 0 && isBonus < 6)) innerBand = true;
            else if (baseScore != 0 && (isBonus > 5 && isBonus < 11)) outerBand = true;
        }

    }
}
