using System;
using System.Diagnostics;
using System.ComponentModel;

namespace Launcher
{
    class MyProcess
    {
        // Uses the ProcessStartInfo class to start new processes, 
        // both in a minimized mode. 
        void OpenWithStartInfo()
        {
            ProcessStartInfo startInfo =
                new ProcessStartInfo(
                    "c:\\Program Files\\Notepad++\\notepad++.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            string[] arguments = Environment.GetCommandLineArgs();
            arguments.SetValue("",0);
            startInfo.Arguments = String.Join(" ", arguments);

            Process.Start(startInfo);
        }

        static void Main()
        {
            // Get the path that stores favorite links.

            MyProcess myProcess = new MyProcess();

            myProcess.OpenWithStartInfo();
        }
    }
}