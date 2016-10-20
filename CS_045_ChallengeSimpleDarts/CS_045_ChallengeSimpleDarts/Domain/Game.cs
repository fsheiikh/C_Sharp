using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_045_ChallengeSimpleDarts.Domain
{
    public class Game
    {
        public int playerOneScore;
        public int playerTwoScore;


        Random random = new Random();

        public void Play()
        {
            while (playerOneScore < 300 && playerTwoScore < 300)
            {
                for (int i = 0; i < 6; i++)
                {
                    Dart dart = new Dart(random);
                    dart.Throw();

                    if (i % 2 == 0) playerOneScore += Score.CalculateDartThrow(dart.baseScore, dart.innerBand, dart.outerBand);
                   
                    else playerTwoScore += Score.CalculateDartThrow(dart.baseScore, dart.innerBand, dart.outerBand);
                }

            }


        }

        public int Play(int number)
        {
            //while (playerOneScore < 300 || playerTwoScore < 300)
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
                    Dart dart = new Dart(random);
                    dart.Throw();
                    if (number == 1) return playerOneScore += Score.CalculateDartThrow(dart.baseScore, dart.innerBand, dart.outerBand);
                    return  playerTwoScore += Score.CalculateDartThrow(dart.baseScore, dart.innerBand, dart.outerBand);
            //    }

            //}


        }

        public string labelUpdate(int newNumber)
        {
            return newNumber.ToString();
        }
    }
}