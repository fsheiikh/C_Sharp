using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_051_MegaChallengeWar.Domain
{   
    [Serializable]
    public class War
    {   
        public Game game { get; set; }
        public List<Card> bucket { get; set; }
        public Card testCard1 { get; set; }
        public Card testCard2 { get; set; }

        public War(Game gameInstance)
        {
            game = gameInstance;
            bucket = new List<Card>();
        }


        //sets two test cards(1 from eAch player), adds them both to the stake bucket, and removes them from players deck
        public void setBounty()
        {
            testCard1 = game.player1.deck.cards.FirstOrDefault();
            testCard2 = game.player2.deck.cards.FirstOrDefault();

            bucket.Add(testCard1);
            bucket.Add(testCard2);

            game.player1.deck.cards.RemoveAt(0);
            game.player2.deck.cards.RemoveAt(0);
        }


        //test both test cards and calls playerWins method depending on who wins
        public string startWar()
        {

            if ((int)testCard1.value > (int)testCard2.value)
            {
                playerWins(game.player1);
                return "Player 1 wins";
            }
            else if ((int)testCard1.value < (int)testCard2.value)
            {
                playerWins(game.player2);
                return "Player 2 wins";
            }
            else {
                 return tiedGame();
                
            }
        }


        //adds cards in stake bucket to winner and empties bucket afterwards
        public void playerWins(Player player)
        {
            foreach (Card card in bucket)
            {
                player.deck.cards.Add(card);
            }
            emptyBucket();
        }


        //empties bucket, NEED TO BE REWRITTEN
        public void emptyBucket()
        {
            bucket.RemoveAll(b => (int)b.value > 0);
        }


        //If game ties, this method is called and adds three cards from each players deck to stake bucket
        //and removes them from the players deck
        public string tiedGame()
        {
            for (int i = 0; i <= 2; i++)
            {
                bucket.Add(game.player1.deck.cards.ElementAt(i));
                bucket.Add(game.player2.deck.cards.ElementAt(i));
            }

            game.player1.deck.cards.RemoveRange(0, 2);
            game.player2.deck.cards.RemoveRange(0, 2);

            //The two method calls below are only activated if the game is run in a loop, 
            //for our case we have buttons that call the methods so they do not need to be called 
            //setBounty()
            //startWar()

            return "tied";
        }



        //both methods below print string of cards for test and stake
        public string getTestCards()
        {
            return testCard1.name + " Vs " + testCard2.name;
        }


        public string getBucket()
        {
            string result = "";

            foreach (Card card in bucket)
            {
                result += card.name + "<br>";

            }
            return result;
        }

    }
}