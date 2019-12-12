# CAD Timeline

This program is designed to make it easy to track events regardless of the type of event.

Very easy to use, lightweight, and portable with a size of 1MB and no installer!

On launch, it will ask you for an incident name, it then creates a text file in the directory you run the .exe from; anything you enter into the entry box will be converted to capital letters and then saved to that text file.

![Incident Name Form](https://i.imgur.com/FPdNzFp.png)
![Main Entry Form](https://i.imgur.com/H2JkHFW.png)

Planned features:
* A "New Incident" button that opens another window to make it easier to create a new incident
* A button to bring you to the folder of the `.txt` file containing your entries so you can find it easier
* A button to open the entries using Notepad.exe so the user can edit it
* Have the main event display box just show the contents of the event file, and read from the file every time an entry is made so if a change is made externally it reflects inside the GUI
* See if I can make the event file editable from within the GUI. Possibly taking the contents of the main event display box and overwriting it into the event file

Issues:
* You cannot edit the files from within the GUI, you must edit them outside of the GUI within notepad or another word editing program
* Any changes made to the file externally will not show from within the GUI currently
