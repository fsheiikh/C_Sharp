using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CS_045_ChallengeSimpleDarts.Domain
{
    public class Score
    {

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
    }
}