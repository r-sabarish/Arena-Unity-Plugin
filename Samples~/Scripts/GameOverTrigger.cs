using UnityEngine;

namespace Arena.Samples
{
    public class GameOverTrigger : MonoBehaviour
    {
        public GameManager gameManager;

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                gameManager.GameOver();
            }
        }
    }
}
