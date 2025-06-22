using UnityEngine;
using Arena.Messages;

#if UNITY_WEBGL && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

namespace Arena
{
    public class Bridge : MonoBehaviour
    {
        public static Bridge Instance { get; private set; }

#if UNITY_WEBGL && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void OnMessage(string message);
#endif

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                Debug.Log("[Bridge] Initialized and set to DontDestroyOnLoad");
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void SendToArena(BaseMessage message)
        {
            string json = JsonUtility.ToJson(message);
#if UNITY_WEBGL && !UNITY_EDITOR
            OnMessage(json);
#else
            Debug.Log($"[Bridge] Message to JS: {json}");
#endif
        }

        public void SendFromArena(string json)
        {
            Debug.Log($"[Bridge] Received from JS: {json}");

            BaseMessage message = JsonUtility.FromJson<BaseMessage>(json);
            switch (message.eventName)
            {
                case ArenaEvent.Started:
                    var startMsg = JsonUtility.FromJson<GameStartMessage>(json);
                    ArenaManager.Instance.StartGame(startMsg.user);
                    break;
            }
        }
    }
}
