using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD_Library
{
    public interface IWeapon
    {
        string weaponName { get; }  //Name of the weapon
        int range { get; }         //Range of weapon
        //Weapon Type
        //Attack ablilty
        int rolls { get; }          //Number of rolls for the weapon
        int diceRange { get; }      //Max range of the dice

        int attackBonus { get; }    //Bonus from attributes
        bool proficient { get; }    //Is character Proficent

        List<int> GetDamage();
        int CalculateAttackBonus();
    }
}
