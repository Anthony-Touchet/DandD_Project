using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD_Library
{   
    public class Character
    {
        public string name;
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;

        public int proficiencyB;
        public List<Weapon> weapons;

        public Character(string na, int st, int dex, int con, int intel, int wis, int cha, int prob)
        {
            name = na;
            strength = st;
            dexterity = dex;
            constitution = con;
            intelligence = intel;
            wisdom = wis;
            charisma = cha;
            proficiencyB = prob;

<<<<<<< HEAD
            weapons = new List<Weapon>();
=======
        public Sword(string na, int ra, int ro, int dr)
        {
            //weaponName = na;
            //range = ra;
            //rolls = ro;
            //diceRange = dr;
>>>>>>> d05aeb05723346f212c600d915fbf3bb447085c5
        }

        void AttributeBonus(int at)
        {
            float extra = at - 10;

            

        }
    }

    public class Weapon
    {
        public string name;
        public int attackbounus;
    }

}