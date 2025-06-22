using System;

namespace Arena.Messages
{
    [Serializable]
    public class GameStartMessage : BaseMessage
    {
        public User user;

        public GameStartMessage(User user)
        {
            this.eventName = ArenaEvent.Started;
            this.user = user;
        }
    }
}
