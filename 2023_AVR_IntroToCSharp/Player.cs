using AVR.Core;

namespace AVR.Entities
{
    //internal means we cannot see/use/access
    //Player in another "assembly"
    public class Player
    {
        #region Member Variables

        private string name;  //timeToLive => TimeToLive
        private int health;
        private AbilityType type; //beginner, intermediate, expert
        private int fuel;

        #endregion Member Variables

        #region Properties

        //if we only have a "setter" then this variable is IMMUTABLE
        public AbilityType Type
        {
            get { return type; }
        }

        public int Health
        {
            get { return health; }

            //ternary => (boolean expression) ? <true> : <false>
            //set { health = (value < 0 || value > 100) ? 100 : value; }
            set { health = (value >= 0 && value <= 100) ? value : 100; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value.Length == 0)
                    name = "beginner";
                else
                    name = value;
            }
        }

        #endregion Properties

        #region Constructors

        //constructor chaining
        public Player() : this("", 0, AbilityType.Beginner, 100)
        {
            //this.name = "";
            //this.health = 0;
            //this.type = "beginner";
            //this.fuel = 100;
        }

        public Player(string name, int health, AbilityType type, int fuel)
        {
            this.name = name;
            this.health = health;
            this.type = type;
            this.fuel = fuel;
        }

        #endregion Constructors

        #region Other Methods

        public override string ToString()
        {
            //return "Name: " + this.name + ",Health: " + this.health;

            //string interpolation
            return $"Name: {name}, Health: {health}, Type: {type}";
        }

        public void UpgradeHealth()
        {
            //if low, then upgrade
            if (health < 100)
                health += 100;
        }

        public void UpgradeType()
        {
            int typeAsInt = (int)type;

            if (typeAsInt >= 1 && typeAsInt <= 3) //beginner -> expert
            {
                typeAsInt++; //promotion
                type = (AbilityType)typeAsInt; //converting a number back into an enum
            }
        }

        #endregion Other Methods
    }
}