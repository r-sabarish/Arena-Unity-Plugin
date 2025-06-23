## Arena Unity Plugin

This Unity plugin allows you to send reward data from a Unity WebGL build to the Arena Web platform.

## How to Use

1. Copy the Git repository URL: 
2. Open your Unity project.
3. Go to **Window** → **Package Manager**.
4. Click the **+** button (top left corner) → **Add package from Git URL...**
5. Paste the Git URL and click **Add**.

![image](https://github.com/user-attachments/assets/1776b432-ca74-4de4-906a-7c236e20181a)

6. You can import samples ( if you want )

![image](https://github.com/user-attachments/assets/93891b06-a611-4a56-bcf3-83fffcaada95)

---

## Plugin Setup

After importing the plugin:

- Navigate to **Arena** → **Tools** → **Setup Arena (quick setup)**
- This will automatically add the **Arena Manager Bridge** and other required components to your current scene.

> **This is required for Arena integration to function correctly**

---

## Game Reward Logic

You **must implement your own game reward logic** using the `ArenaManager.Instance.EndGame()` method. Here's a simple example:

```csharp
using Arena;

public class GameManager : MonoBehaviour
{
 public void OnGameFinished()
 {
     Rewards rewards = new Rewards(arenaCoins: 100, trophies: 10);

     // Send the reward to Arena Web
     ArenaManager.Instance.EndGame(rewards);
 }
}
