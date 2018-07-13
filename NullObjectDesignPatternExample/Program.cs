using NullObjectDesignPatternExample.Guns;
using NullObjectDesignPatternExample.Handcuffs;
using NullObjectDesignPatternExample.Weapons;
using System;

namespace NullObjectDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PoliceOfficer constable = new PoliceOfficer(
                PoliceRanksType.Constable, 
                new GSDoubleLockHandcuffs(), 
                new Glock17Weapon());

            PoliceOfficer seniorConstable = new PoliceOfficer(
                PoliceRanksType.SeniorConstable,
                new PerfectaHC200Handcuffs(), 
                new Glock19Weapon());

            PoliceOfficer sergeant = new PoliceOfficer(
                PoliceRanksType.Sergeant, 
                new GSDoubleLockHandcuffs(), 
                new Glock19Weapon());

            PoliceOfficer apprentice = new PoliceOfficer(
                PoliceRanksType.Apprentice, 
                new NullHandcuffs(), 
                new NullWeapon());

            constable.Shoot();
            constable.ToHandcuff();

            apprentice.Shoot();
            apprentice.ToHandcuff();

            Console.ReadKey();
        }
    }
}