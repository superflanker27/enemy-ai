using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handleAI.EnemyData
{
    class military
    {
        public static int health;
        public static int aim;
        public static int speed;
        public static int anger;
        public static int fear;
        public static int confidence;
        public static bool special;



        public static void commander()
        {

            military.health = 150;
            military.aim = 20;
            military.speed = 90;
            military.anger = 0;
            military.fear = 0;
            military.confidence = 8;
            military.special = true;
        
        }


        public static void soldier()
        {

            military.health = 90;
            military.aim = 10;
            military.speed = 50;
            military.anger = 0;
            military.fear = 0;
            military.confidence = 3;
            military.special = false;


        }

        public static void subsoldier()
        {

            military.health = 80;
            military.aim = 7;
            military.speed = 40;
            military.anger = 0;
            military.fear = 1;
            military.confidence = 1;
            military.special = false;


        }

        public static void shotgunsoldier()
        {

            military.health = 40;
            military.aim = 6;
            military.speed = 80;
            military.anger = 0;
            military.fear = 0;
            military.confidence = 8;
            military.special = false;


        }

        public static void marksman()
        {

            military.health = 50;
            military.aim = 17;
            military.speed = 25;
            military.anger = 0;
            military.fear = 0;
            military.confidence = 5;
            military.special = false;

        }

        public static void medic()
        {

            military.health = 25;
            military.aim = 5;
            military.speed = 60;
            military.anger = 0;
            military.fear = 3;
            military.confidence = 2;
            military.special = true;

        }



        public static void vdrone()
        {

            military.health = 20;
            military.speed = 230;
            military.anger = 0;
            military.fear = 0;
            military.confidence = 10;
            military.special = true;

        }



    }
}
