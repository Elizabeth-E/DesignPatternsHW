using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class Character
    {
        public IWeaponBehaviour Weapon { set; get; }
        public Character()
        {
            Weapon = new KnifeBehaviour();
        }

        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
