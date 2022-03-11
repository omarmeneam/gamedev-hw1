using System;

namespace gamedev_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 1 : variables
            int health = 100;
            string hero;

            // step 2 : Damaged function
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

            // Step 3 : Boost function
            int PlayerHp2 = boost(10);
            Console.WriteLine("Boosted Health : {0}", PlayerHp2);


            // Step 4 : Health Array and Print the second digit of the array
            string[] HealthArray = { "80", "90" };

            int lastindex = HealthArray.Length -1;
            Console.WriteLine(HealthArray[lastindex]);

            // Step 5 : Compare and print the result
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
