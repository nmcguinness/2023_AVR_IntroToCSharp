using AVR.Entities;

namespace AVR
{
    public interface IUpgradeGameObject
    {
        void Upgrade(Player p);
    }

    public class UpgradePlayerHealth : IUpgradeGameObject
    {
        public void Upgrade(Player p)
        {
            //if low, then upgrade
            if (p.Health < 100)
                p.Health += 100;
        }
    }
}