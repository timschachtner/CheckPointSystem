# CheckPointSystem

## in kleines Checkpoint System mit PlayerPrefs.

# Set up (DE)
## 1 - Checkpoints erstellen
Du kannst Checkpoints erstellen, indem du irgentein GameObject mit einem bestimmten Tag z.B. "Checkpoint" beschreibst. Diese Ceckpoints musst du dan in das Feld "Checkpoint" in dem Script "Checkpoints" ziehen. Schreibe in das Feld "Checkpoint Tag" das Tag hinein, das du gerade festgelegt hast.

## 2 - Zu Checkpoints zurückkehren
Du kannst zu deinem letzten Checkpoint zurückkehren, indem du ein GameObject mit dem Tag, das du bei "Tag To Die" festlegen kannst, berührst oder in einem anderen Script folgenden Befehl ausfürst:

### Checkpoints CP = GetComponent<Checkpoints<Checkpoints>>(); CP.Die();
  
oder, wenn sich das Checkpoints - Script nicht auf dem selben GameObject befindet:

### Checkpoints CP = GameObject.Find("Name des Spieler - GameObjects").GetComponent<Checkpoints<Checkpoints>>(); CP.die();
  
wenn du direkt am Start zu deinem letzten Checkpoint willst, kannst du die Funktion "Goto Latest Chackpoint On Start" wählen.

falls kein Checkpoint gefunden wurde, wird die Scene neu geladen.
  
## 3 - Nachricht und Sound
Um eine Nachricht zu zeigen oder ein Sound zu spielen, musst du ein Haken bei dem jeweiligen Kästchen machen und das Panel mit dem Text bzw. den Sound in das jeweilige Feld ziehen.

## 4 - Fertig!
Viel Spaß mit den Checkpoints!
