# Arena Unity Plugin – Changelog

## [v1.0.1] – Arena Unity Plugin

### New Features
- Arena Runtime & Editor Scripts  
  Core scripts for runtime functionality and editor tools.

- Sample Scenes for BiRP & URP  
  Includes sample scenes compatible with both Built-in Render Pipeline (BiRP) and Universal Render Pipeline (URP).

### Enhancements
- One-Click Setup Tool  
  Available at `Menu -> Arena/Tools/Quick Setup` to simplify initial scene configuration.

### Safeguards & Warnings
- Arena Reminder System  
  Prevents player progression unless required arena conditions are met.

- Singleton ArenaManager Check  
  Displays a warning if multiple `ArenaManager` instances are present in the scene.

- End Game Logic Requirement  
  Developers are reminded to implement end game logic explicitly using `ArenaManager.EndGame()`.
