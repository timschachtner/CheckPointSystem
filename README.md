# CheckPointSystem
## A small checkpoint system with PlayerPrefs.
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
viel Spaß mit den Checkpoints!



# Set up (EN)
## 1 - Create checkpoints
You can create checkpoints by using any GameObject with a specific tag e.g. "Checkpoint". You then have to drag these checkpoints into the "Checkpoint" field in the "Checkpoints" script. In the "Checkpoint Tag" field, write the tag that you have just defined.

## 2 - Return to checkpoints
You can return to your last checkpoint by touching a GameObject with the tag that you can set in "Tag To Die" or by executing the following command in another script:

## Checkpoints CP = GetComponent<Checkpoints <Checkpoints>> (); CP.Die ();
  
or if the checkpoints script is not on the same GameObject:

## Checkpoints CP = GameObject.Find ("Name of the player GameObject"). GetComponent <Checkpoints <Checkpoints>> (); CP. Die ();
  
if you want to go to your last checkpoint right at the start, you can choose the "Goto Latest Chackpoint On Start" function.

if no checkpoint was found, the scene is reloaded.
  
## 3 - Message and Sound
To show a message or play a sound, you have to pick the checkbox and drag the panel with the text or the sound into the field.

## 4 - Done!
have fun with the checkpoints!
