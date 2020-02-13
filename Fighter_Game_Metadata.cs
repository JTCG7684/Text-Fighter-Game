using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighter_Game_Metadata;

namespace Fighter_Game_Metadata
{
    class GlobalVariables
    {
        public bool PlayerOneTurn;
        public bool PlayerTwoTurn;
        public string StartDecision;
        public string Tutorial;
        public int GameRound;

    }

    class FighterClass
    {
        public string name;
        public int health;
        public int armor;
        public double speed;
        public int power;
        public int stamina;
    }

    class Knight : FighterClass
    {
        public Knight()
        {
            name = "Knight";
            health = 250;
            armor = 25;
            speed = .75;
            power = 25;
            stamina = 100;
        }

        public string KnightDescription()
        {
            return "A well rounded fighter. baseline stats across the board, and 250 health.";
        }

        public string KnightAbilities()
        {
            return "Placeholder";
        }
    }

    class Tank : FighterClass
    {
        public Tank()
        {
            name = "Knight";
            health = 250;
            armor = 25;
            speed = .75;
            power = 25;
            stamina = 100;
        }
        public string TankDescription()
        {
            return "A bulky fighter. Has additional health and armor, and a little more power. Has decreased speed however.";
        }

        public string TankAbilities()
        {
            return "Placeholder";
        }
    }

    class Startup
    {
        void DetermineFighterPlayerOne() {
            int g = 1;
        }
    }
}
