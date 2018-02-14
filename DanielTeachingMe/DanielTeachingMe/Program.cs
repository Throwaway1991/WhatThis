using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DanielTeachingMe
{
    public class HomeworkDay2
    {
        public static void Main(string[] args)
        {
            //TODO: Declare and instantiate your gun object here
            MattsFakeGun newGun = new MattsFakeGun();
            RealGun ak47 = new RealGun(45, 10);
            string input = string.Empty;
            Random r = new Random();
            ak47.ShowAmmoCount();
            //Loop until the user enters quit
            while (input != "quit")
            {
                input = Console.ReadLine();
                Console.Clear();

                switch(input)
                {
                    case "shoot":
                        {
                            //TODO: Shoot your gun
                            //int result = newGun.Pew(1);
                            //if (result == -1)
                            //{
                            //    Console.WriteLine("No more ammo");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Bang!");
                            //}
                            int numToShoot = r.Next(1, 10);
                            int actualShot = ak47.Pew(numToShoot);

                            if (actualShot == 0)
                            {
                                Console.Write("No bullets left in clip! Reload bitch!");
                            }
                            else
                            {
                                for (int i = 0; i < actualShot; i++)
                                {
                                    Console.WriteLine("BANG!");
                                }
                            }
                            Console.WriteLine("WantedToShoot: {0}  ActualShot: {1}", numToShoot, actualShot);
                            ak47.ShowAmmoCount();

                            break;
                        }
                    case "reload":
                        {
                            //TODO: Reload your gun
                            //newGun.Reloading()
                            bool status = ak47.Reload();

                            if (status == true)
                            {
                                Console.WriteLine("Reloading...");
                            }
                            else
                            {
                                Console.WriteLine("No Ammo left!");
                            }
                            ak47.ShowAmmoCount();
                            break;
                        }
                    case "quit":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input.");
                            break;
                        }
                }

                //TODO: Display remaining gun ammo in clip and remaining total ammo to console screen
            }
        }

        private static void ShowAmmoCount(RealGun realgun)
        {
            if (null == realgun)
                return;

            Console.WriteLine("TotalBullets: {0} \r\nBulletsInMagazine: {1}", realgun.TotalBullets, realgun.BulletsInMagazine);
        }

        private void ShowAmmoCount(MattsFakeGun TotalAmmo, MattsFakeGun MagSize)
        {
            Console.WriteLine("Total Ammo: {0}", TotalAmmo);
            Console.WriteLine("Mag Size: {0}", MagSize);
        }
    }

}
