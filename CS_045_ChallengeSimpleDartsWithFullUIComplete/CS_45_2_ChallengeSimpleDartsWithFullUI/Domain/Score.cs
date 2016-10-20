using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CS_045_ChallengeSimpleDartsWithFullUI.Domain
{
    [Serializable]
    public class Score
    {
        //this method determines total points for a throw, checking for bonuses and returning the total to the Game Class
        public static int CalculateDartThrow(int baseScore, bool innerBand, bool outerBand)
        {
            int totalScore = 0;

            if (baseScore == 0)
            {
                totalScore = 25;
                //if outer bullseye, score is 50
                totalScore *= (innerBand) ? 2 : 1;
            }
            else
            {
                totalScore = baseScore;
                if (innerBand) totalScore *= 3;
                else if (outerBand) totalScore *= 2;
            }

            return totalScore;
        }

        //this method packages the dart throw info and returns an array to the Game Class
        public static int[] DisplayDartThrow(int baseScore, bool innerBand, bool outerBand)
        {
            int[] results = new int[3];

            // 1= true, 0 = false
            results[2] = (innerBand) ? 1 : 0;
            results[1] = (outerBand) ? 1 : 0;
            results[0] = baseScore;

            return results;
        }
    }
}