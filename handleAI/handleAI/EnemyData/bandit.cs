using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handleAI.EnemyData
{
    class bandit
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
            bandit.health = 70;
            bandit.aim = 10;
            bandit.speed = 100;
            bandit.anger = 2;
            bandit.fear = 0;
            bandit.confidence = 9;
            bandit.special = true;

        }


        public static void assault()
        {
            bandit.health = 40;
            bandit.aim = 5;
            bandit.speed = 90;
            bandit.anger = 3;
            bandit.fear = 1;
            bandit.confidence = 7;
            bandit.special = false;

        }


        public static void assist()
        {
            bandit.health = 30;
            bandit.aim = 7;
            bandit.speed = 90;
            bandit.anger = 1;
            bandit.fear = 1;
            bandit.confidence = 5;
            bandit.special = false;

        }

        public static void marksman()
        {
            bandit.health = 70;
            bandit.aim = 8;
            bandit.speed = 80;
            bandit.anger = 1;
            bandit.fear = 1;
            bandit.confidence = 6;
            bandit.special = false;

        }

        public static void kdrone()
        {
            bandit.health = 10;
            bandit.speed = 280;
            bandit.anger = 0;
            bandit.fear = 0;
            bandit.confidence = 10;
            bandit.special = true;

        }


    }
}
