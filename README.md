# RetroManager
A tool made for Windows machines to help manage roms, specifically made for RetroPie.

## Execution
Take the EXE and drop it anywhere on your computer, as long as it can reach the directory of your roms, then you're good to go.

## Starting the Program 
### Main Menu
Upon launching the EXE, you'll be brought to a screen that has four different buttons, this is the Main Menu. The Main Menu plus any other form that is open must be closed to exit out of the program. Each of the buttons all share a directory on their forms, this is where you put in the directory of where the roms are located. There will be tooltips in case you need a refresher.

### Region Duplicate Remover
This is the first button on the Main Menu. This is to remove any duplicated roms you have that are for different regions that you do not want. To use this, in the first textbox list the order of regions starting with the highest priority, example: "(USA), (Europe), (Japan)." Three things to note, the parathesis are required because there are times where it could be "[U], [E], [J]" instead so you have to be specific. The other thing is anything that isn't in the priority list will be randomly taken, it'll just make sure it only leaves one of the game. Lastly, if a game is spelled differently, the program will not be able to detect they are the same game, example: Legend of Zelda: Ocarina of Time, Legend of Zelda: OoT, Zeruda no Densetsu: Toki no Okarina." Upon clicking Analyze, a txt file will open up showing you what games will be deleted if you click delete. I recommend looking over the list and just double checking if it's correct. It is possible for games under different emulators to share the same name, so depending on the root folder, even though they are on different emulators, they may be seen as being the same game.

### Revision Duplicate Remover
This is the second button on the Main Menu. It'll find the newest revision of a game, and remove everything else. If there are no revisions made to a game, nothing will happen to those files. Upon clicking Analyze, a txt file will open up showing you what games will be removed when the delete button is clicked.

### Compress Roms
This is the third button on the Main Menu. The program will check your Program Files and Program Files(x86) to see if 7-Zip is installed since it uses that program to zip up all the files. There will be a bunch of checkboxes for different types of Systems, all of the ones listed have at least one emulator that uses the zip format. As of right now, on the RetroPie github for N64, it lists none of the emulators use the zip format, but mugen does, all you have to do is edit the xml yourself to allow it.

### Move Roms to Root Folder
This is the fourth button on the Main Menu. All this will do is move roms into the directory that is specified. There is also a checkbox that will rename the roms to the folder they originally started it before moving to the directory; this is specifically useful after using PBP's batch converter since all the pbp's get named to EBoot.
