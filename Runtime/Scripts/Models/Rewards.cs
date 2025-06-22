using System;

namespace Arena
{
    [Serializable]
    public class Rewards
    {
        public int arenaCoins;
        public int trophies;

        public Rewards(int arenaCoins, int trophies)
        {
            this.arenaCoins = arenaCoins;
            this.trophies = trophies;
        }
    }
}
