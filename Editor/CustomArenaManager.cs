using UnityEditor;

namespace Arena.Editor
{
    [CustomEditor(typeof(ArenaManager))]
    public class CustomArenaManager : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.Space();
            EditorGUILayout.HelpBox(
                "\n 1.ArenaManager is a singleton and should only exist once in the scene.\n \n" +
                "2.Make sure Bridge is also present and marked as DontDestroyOnLoad.\n \n" +
                "3.Don't Forgot to Implement the game end / reward logic and call ArenaManager.EndGame() \n",
                MessageType.Warning
            );
        }
    }
}