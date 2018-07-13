namespace NullObjectDesignPatternExample.Guns
{
    public class Glock17Weapon : IWeapon
    {
        private int BulletNumber { get; set; }

        public void Reload()
        {
            BulletNumber = 17;
        }

        public void Shoot()
        {
            BulletNumber--;
        }
    }
}