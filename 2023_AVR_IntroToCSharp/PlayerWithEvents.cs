namespace AVR
{
    public class PlayerWithEvents
    {
        //delegate
        public delegate void WinHandler();

        //event
        public event WinHandler OnWin;

        public void SetWin()
        {
            OnWin?.Invoke();
        }

        private int health;
        private string name;

        public PlayerWithEvents(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        public int Health { get => health; set => health = value; }
        public string Name { get => name; set => name = value; }
    }
}