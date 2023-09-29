using AVR.Core;
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

    public class UpgradePlayerType : IUpgradeGameObject
    {
        public void Upgrade(Player p)
        {
            int typeAsInt = (int)p.Type;
            if (typeAsInt >= 1 && typeAsInt <= 3) //beginner -> expert
            {
                typeAsInt++; //promotion
                p.Type = (AbilityType)typeAsInt; //converting a number back into an enum
            }
        }
    }
}