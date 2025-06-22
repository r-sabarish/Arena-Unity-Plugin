using UnityEngine;
using Arena;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ArenaMenu : MonoBehaviour
{
#if UNITY_EDITOR
    [MenuItem("Arena/Tools/Setup Arena (quick setup)", false, 10)]
    private static void SetupArena(MenuCommand menuCommand)
    {
        GameObject arenaManager = new GameObject("Arena Manager");
        arenaManager.AddComponent<ArenaManager>();
        GameObjectUtility.SetParentAndAlign(arenaManager, menuCommand.context as GameObject);

        GameObject bridge = new GameObject("Bridge");
        bridge.AddComponent<Bridge>();
        GameObjectUtility.SetParentAndAlign(bridge, menuCommand.context as GameObject);

        arenaManager.GetComponent<ArenaManager>().bridge = bridge.GetComponent<Bridge>();

        GameObject reminder = new GameObject("Arena Reminder");
        reminder.AddComponent<Reminder>();
        GameObjectUtility.SetParentAndAlign(reminder, menuCommand.context as GameObject);

        Undo.RegisterCreatedObjectUndo(arenaManager, "Create Arena Manager");
        Undo.RegisterCreatedObjectUndo(bridge, "Create Bridge");
        Undo.RegisterCreatedObjectUndo(reminder, "Create Reminder");

        Selection.activeObject = arenaManager;
    }
#endif
}
