using System;

namespace gamedev_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            string hero;

            int DamagedHealth(int damage)
            {
                return health - damage;
            }

            int PlayerHp = DamagedHealth(20);
            Console.WriteLine("Damaged Health : {0} ", PlayerHp);

            int boost (int ExtraHp)
            {
                return PlayerHp + ExtraHp;
            }

            int PlayerHp2 = boost(10);
            Console.WriteLine("Boosted Health : {0}", PlayerHp2);

            string[] HealthArray = { "80", "90" };

            int lastindex = HealthArray.Length -1;
            Console.WriteLine(HealthArray[lastindex]);

            void Comparison()
            {
                if (PlayerHp > PlayerHp2)
                {
                    Console.WriteLine(PlayerHp + "is more than" + PlayerHp2);
                }

                else 
                {
                    Console.WriteLine(PlayerHp + " is less than " + PlayerHp2);
                }

            }
             Comparison();
        }
    }
}
