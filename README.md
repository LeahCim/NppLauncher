Notepad++ Launcher for Markdown files
=====================================

Finally a way to use a custom icon for Markdown files, while opening them with Notepad++!

Why?
----

I simply couldn't figure out how to change my registry settings to open Markdown files with Notepad++ while giving them (and only them) a nicer icon.


Installation
------------

1. Open project with MonoDevelop or (possibly) with VisualStudio
2. Build the NppLauncher.exe file
3. Put the NppLauncher.exe file in a suitable location, e.g. %ProgramFiles%\Notepad++\
4. Right-click an *.md or *.markdown file, choose Open With and find NppLauncher.exe
5. Enjoy the custom icon, w00t!


Advanced
--------

You can put an icon of your choosing in the icons folder and change the project settings to use it instead. If you rename your icon to Markdown-white.ico you won't even need to change the project settings!

Another idea is to create separate Lauchers for different file-types you plan to open with Notepad++. Each one, of course, would have its own icon.

You can also edit the code to launch a different app altogether. Be brave!