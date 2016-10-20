using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_045_ChallengeSimpleDartsWithFullUI.Domain
{
    

    [Serializable]
    public class Game
    {
        public int playerOneScore;
        public int playerTwoScore;




        Random random = new Random();
        
        //Creates new Dart instance and checks to see if it was for palyer 1 or two depending on which button was clicked
        public int[] Play(int playerNumber)
        {
           
            Dart dart = new Dart(random);
            dart.Throw();

            if (playerNumber == 1)
            {   
                playerOneScore += Score.CalculateDartThrow(dart.baseScore, dart.innerBand, dart.outerBand);
                return Score.DisplayDartThrow(dart.baseScore, dart.innerBand, dart.outerBand);

            }
            else 
            {
                playerTwoScore += Score.CalculateDartThrow(dart.baseScore, dart.innerBand, dart.outerBand);
                return Score.DisplayDartThrow(dart.baseScore, dart.innerBand, dart.outerBand);
            }

            
      
        }

    
    }
}