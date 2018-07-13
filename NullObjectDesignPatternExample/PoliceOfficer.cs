using NullObjectDesignPatternExample.Guns;
using NullObjectDesignPatternExample.Handcuffs;

namespace NullObjectDesignPatternExample
{
    public class PoliceOfficer
    {
        private PoliceRanksType PoliceRank { get; set; }
        private IHandcuffs Handcuffs { get; set; }
        private IWeapon Weapon { get; set; }

        public PoliceOfficer(
            PoliceRanksType policeRankType,
            IHandcuffs handcufs,
            IWeapon weapon)
        {
            PoliceRank = policeRankType;
            Handcuffs = handcufs;
            Weapon = weapon;
        }

        public void Shoot()
        {
            Weapon.Shoot();
        }

        public void ToHandcuff()
        {
            Handcuffs.Lock();
        }
    }
}