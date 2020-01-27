namespace Fighter_Game_Metadata
{

    class GlobalVariables
    {
        bool PlayerOneTurn;
        bool PlayerTwoTurn;
        string StartDecision;
        string Tutorial;
        int GameRound;

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
}