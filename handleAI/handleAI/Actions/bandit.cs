using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handleAI.Actions
{
    class bandit
    {
        // logic removed or unfinished
        public static bool cover;
        public static bool ordergivenbycommander;

        public static object EnnemySpeak { get; private set; }
        public static object EnnemyData { get; private set; }

        public static void flank()      
        {
        // flank logic
        }

        public static void push()
        {
            if (bandit.cover == false || ordergivenbycommander == true) 
            {
                // SpecialActions.noexecute();
               //  bandit.EnnemySpeak();  - refuse order
            } else
            {
                // flank logic
            }


        }



        public static void retreat()
        {
            if (EnemyData.bandit.health <= 20)
            {
                var rndd = new Random();
                int pqn = 10;
                for (int i = 0; i < 100; i++)
                {
                    int rndv = rndd.Next(100);
                    if (rndv < pqn)
                    {
                        //  bandit.EnnemySpeak();  - refuse order
                    }
                }               
            }
            else if (ordergivenbycommander == true)
            {
                // retreat logic
            } else
            {
                // retreat logic
            }


        }

        public static void supress()
        {
            // supress logic
        }

        public static void beshy()
        {
          // logicc 
        }

        public static void panic()
        {
            if (EnemyData.bandit.fear >= 8)
            {
                // panic(); - rmvd
            }
        }






    }
}
