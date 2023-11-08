using System.Diagnostics.Contracts;

namespace AVR
{
    public class PlayerWithEvents
    {
        //delegate
        public delegate void WinEventHandler();

        //event
        public event WinEventHandler OnWin;

        public delegate void HelpEventHandler(string sender, string msg, int ammo);

        public event HelpEventHandler OnHelp;

        public void CallForHelp()
        {
            if (OnHelp != null)
                OnHelp.Invoke(name, "I need help fast!", 25);
        }

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