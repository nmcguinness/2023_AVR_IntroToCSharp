namespace AVR.Entities
{
    //internal means we cannot see/use/access
    //Player in another "assembly"
    public class Player
    {
        #region Member Variables

        private string name;
        private int health;
        private string type;
        private int fuel;

        #endregion Member Variables

        #region Constructors

        //constructor chaining
        public Player() : this("", 0, "beginner", 100)
        {
            //this.name = "";
            //this.health = 0;
            //this.type = "beginner";
            //this.fuel = 100;
        }

        public Player(string name, int health, string type, int fuel)
        {
            this.name = name;
            this.health = health;
            this.type = type;
            this.fuel = fuel;
        }

        #endregion Constructors
    }
}