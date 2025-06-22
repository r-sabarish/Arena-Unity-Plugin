using System;

namespace Arena.Messages
{
    [Serializable]
    public class GameEndMessage : BaseMessage
    {
        public Rewards rewards;

        public GameEndMessage(Rewards rewards)
        {
            this.eventName = ArenaEvent.Ended;
            this.rewards = rewards;
        }
    }
}
