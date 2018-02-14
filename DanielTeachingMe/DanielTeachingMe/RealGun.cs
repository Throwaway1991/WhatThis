using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielTeachingMe
{
    public class RealGun
    {
        int _totalBullets;
        int _magSize = 10;
        int _curMag;
        int _totalMagazines = 5;
        int _magAmmoCount;

        public int TotalBullets 
        {
            get { return _totalBullets; }
        }

        public int BulletsInMagazine
        {
            get { return _curMag; }
        }

        public void ShowAmmoCount()
        {
            Console.WriteLine("TotalBullets: {0} \r\nBulletsInMagazine: {1}", this.TotalBullets, this.BulletsInMagazine);
        }

        //Default constructor
        public RealGun()
        {
            _curMag = _magSize;
            _totalBullets = _totalMagazines * _magSize;
        }

        //Overloaded constructor
        public RealGun(int totalBullets, int magSize)
        {
            _magSize = magSize;
            _totalMagazines = (int)Math.Ceiling((double)totalBullets / (double)magSize);
            _curMag = _magSize;
            _totalBullets = totalBullets;
        }

        /// <summary>
        /// Returns the number of bullets show or -1 if there was an error
        /// </summary>
        /// <param name="amountToShoot"></param>
        /// <returns></returns>
        public int Pew(int amountToShoot)
        {
            if (amountToShoot <= 0)
            {
                return -1;
            }

            if (amountToShoot > _curMag)
            {
                int shotBullets = _curMag;
                _curMag -= shotBullets;

                return shotBullets;
            }
            else
            {
                _curMag -= amountToShoot;
                return amountToShoot;
            }
        }

        //TODO: Figure out how to top the clip off instead of just tossing that shit into oblivion
        // Bullets be expensive yo.
        public bool Reload()
        {

            if (_totalMagazines <= 0)
            {
                return false;
            }
            
            if (_totalBullets /_magSize > 0)
            {
                _magAmmoCount = 10 - _curMag;
                //_curMag = _magSize;
                _totalBullets -= _magAmmoCount;
                _curMag += _magAmmoCount;
                _totalMagazines--; // Look up increment/decrement in c#. Same as _totalMagazines = _totalMagazines -1

                return true;
            }
            else if (_totalBullets % _magSize > 0)
            {
                int remainingBullets = _totalBullets % _magSize;
                _totalBullets -= remainingBullets;
                _curMag = remainingBullets;
                _totalMagazines--;


                return true;
            }
            else
            {
                //No bullets left
                return false;
            }
        }
    }
}
