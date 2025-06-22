using UnityEngine;
using System;
using Arena.Messages;
using UnityEngine.Assertions;

namespace Arena
{
    public class ArenaManager : MonoBehaviour
    {
        public static ArenaManager Instance { get; private set; }

        public static event Action<User> onGameStarted;

        public Bridge bridge;

        void Awake()
        {
            Require();
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                Debug.Log("[ArenaManager] Initialized");
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void StartGame(User user)
        {
            onGameStarted?.Invoke(user);
        }

        public void EndGame(Rewards rewards)
        {
            GameEndMessage gameEndMessage = new GameEndMessage(rewards);
            bridge.SendToArena(gameEndMessage);
        }

        void OnValidate()
        {
            if (bridge == null)
            {
                bridge = FindAnyObjectByType<Bridge>();
            }
        }

        void Require()
        {
            Assert.IsNotNull(bridge, "Arena Bridge Required !");
        }
    }
}
