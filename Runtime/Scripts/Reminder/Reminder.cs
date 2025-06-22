using UnityEngine;

namespace Arena
{
    public class Reminder : MonoBehaviour
    {
        private float timer = 0f;
        private bool showMessage = true;

        void Update()
        {
            if (showMessage)
            {
                timer += Time.deltaTime;
                if (timer >= 10f)
                {
                    showMessage = false;
                }
            }
        }

        void OnGUI()
        {
            if (!showMessage) return;

            GUIStyle style = new GUIStyle(GUI.skin.box);
            style.fontSize = 18;
            style.alignment = TextAnchor.MiddleCenter;
            style.normal.textColor = Color.white;

            float width = 500;
            float height = 80;
            float x = (Screen.width - width) / 2;
            float y = 20;

            GUI.Box(new Rect(x, y, width, height), "Note: Rewards are only given if the game is completed.\nClosing early will lost progress.", style);
        }
    }
}
