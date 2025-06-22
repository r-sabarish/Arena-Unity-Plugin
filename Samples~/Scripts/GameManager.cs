using UnityEngine;

namespace Arena.Samples
{
    public class GameManager : MonoBehaviour
    {
        private float timeAlive = 0f;
        private bool isGameRunning = false;

        void Start()
        {
            isGameRunning = true;
            timeAlive = 0f;
        }

        void Update()
        {
            if (isGameRunning)
            {
                timeAlive += Time.deltaTime;
            }
        }

        public void GameOver()
        {
            isGameRunning = false;

            int survivedSeconds = Mathf.FloorToInt(timeAlive);

            int arenaCoins = survivedSeconds * 2;
            int trophies = survivedSeconds / 10;

            Rewards rewards = new Rewards(arenaCoins, trophies);
            ArenaManager.Instance.EndGame(rewards);

            Debug.Log($"Game Over! Time survived: {survivedSeconds}s | Coins: {arenaCoins} | Trophies: {trophies}");
        }
    }
}
