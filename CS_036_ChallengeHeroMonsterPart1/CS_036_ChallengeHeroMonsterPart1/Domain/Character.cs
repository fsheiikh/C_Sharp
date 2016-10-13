using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_036_ChallengeHeroMonsterPart1
{
    //public class Character
    //{
    //    public string Name { get; set; }
    //    public int Health { get; set; }
    //    public int DamageMaximum { get; set; }
    //    public bool AttackBonus { get; set; }


    //    public int Attack(Dice dice)
    //    {
    //        if (AttackBonus) {
    //            return dice.Roll() + 1;
    //        }

    //        return dice.Roll();
    //    }

    //    public void Defend(int damage)
    //    {
    //        Health -= damage;
    //    }
    //}






    //creates contract for anything that uses it
    interface IHuman
    {
        string Name { get; set; }
        int Health { get; set; }

    }

    //cannot be instatiated but provides common definiton of base class to be used for other classes
    public abstract class Character : IHuman
    {
        public int Health { get; set; }
        public string Name { get; set; }
        
        //abstract must be overridden 
        public abstract int Attack(Dice dice);

        //virtual can be overriden but is not required
        public virtual void Defend(int damage)
        {
            Health -= damage;
        }

    }

    [Serializable]
    public class Hero : Character
    {
        bool AttackBonus = true;

        public override int Attack(Dice dice)
        {
            if (AttackBonus)
            {
                return dice.Roll() + 2;
            }

            return dice.Roll();


        }
    }

    [Serializable]
    public class Monster : Character
    {
        
        public override int Attack(Dice dice)
        {
            return dice.Roll();
        }
    }
}