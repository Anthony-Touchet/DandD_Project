using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD_Library
{
    public class Sword : IWeapon
    {
        public string weaponName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int range
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int rolls
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int diceRange
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int attackBonus
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool proficient
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Sword(string na, int ra, int ro, int dr)
        {
            //weaponName = na;
            //range = ra;
            //rolls = ro;
            //diceRange = dr;
        }

        public int CalculateAttackBonus()
        {
            int result = 0;
            //Get Player's attribue the weapon uses. Calculate
            if (proficient == true)
            {
                result += 2;
            }

            return result;
        }

        public List<int> GetDamage()
        {
            List<int> attacks = new List<int>();
            Random ran = new Random();

            for (int i = 0; i < this.rolls; i++)
            {
                attacks.Add(ran.Next(0, this.diceRange));
            }

            return attacks;
        }
    }

    public class Character
    {
    }
}