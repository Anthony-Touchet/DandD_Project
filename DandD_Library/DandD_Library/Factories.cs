using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DandD_Library;

namespace Factories
{
    public class WeaponFac 
    {
        public IWeapon MakeSword(string na, int ra, int ro, int dr)
        {
            return new Sword(na, ra, ro, dr);
        }
    }

    public class CharacterFac
    {

    }
}
