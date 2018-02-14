using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielTeachingMe
{
    public class MattsFakeGun
    {
        private int _totalAmmo;
        private int _magCount;
        private int _freshMag;

        public MattsFakeGun()
        {
            _freshMag = 10;

        }

        public int MagSize
        {
            get { return _magCount; }
        }

        public int TotalAmmo
        {
            get { return _totalAmmo; }
        }

        public void SetAmmoCount(int AmmoCount)
        {
            _totalAmmo = AmmoCount;
        }

        public void Shooting(int amount)
        {
            _magCount -= amount;
        }

        public void Reloading(int AmmoCount)
        {
            _totalAmmo -= _freshMag;

        }

        public int Pew(int amountToShoot)
        {
            if (0 == MagSize || _totalAmmo < amountToShoot)
                return -1;

                _totalAmmo -= amountToShoot;
                _magCount -= amountToShoot;

                return 0;
        }

        private void ShowAmmoCount(MattsFakeGun TotalAmmo, MattsFakeGun MagSize)
        {
            Console.WriteLine("Total Ammo: {0}", TotalAmmo);
            Console.WriteLine("Mag Size: {0}", MagSize);
        }
    }
}
