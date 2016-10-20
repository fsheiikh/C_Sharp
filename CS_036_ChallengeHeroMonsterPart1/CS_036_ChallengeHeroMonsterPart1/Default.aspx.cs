using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_036_ChallengeHeroMonsterPart1
{
    public partial class Default : System.Web.UI.Page
    {   
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //regular implementation:
            //Character hero = new Character { Name = "Spongebob", Health = 50, DamageMaximum = 10, AttackBonus = true };
            //Character monster = new Character { Name = "Charizard", Health = 100, DamageMaximum = 10, AttackBonus = false};

            //with interface and base class
            Hero hero = new Hero { Name = "Spongebob", Health = 50 };
            Monster monster = new Monster { Name = "Charizard", Health = 100};

            //Everything else is the same for both interface/regualr implementation

            Dice dice = new Dice { Sides = 6 };

            int Round = 1;
            Label1.Text = "<h3>" + hero.Name + " vs. " + monster.Name + "</h3>";

            while (monster.Health > 0 && hero.Health > 0)
            {  
                //hero attacks monster
                monster.Defend(hero.Attack(dice));

                //monster atacks hero
                hero.Defend(monster.Attack(dice));

                Label1.Text += "<hr>" + "Round: " + Round.ToString() + "<hr></br>" + 
                                hero.Name + " has " + hero.Health + " Health" + "</br>" +
                                monster.Name + " has " + monster.Health + " Health";

                Round++;
            }

            Label2.Text = hero.Health > monster.Health ?
                hero.Name + " defeated " + monster.Name :
                monster.Name + " defeated " + hero.Name;
        }

     
       
    }
}