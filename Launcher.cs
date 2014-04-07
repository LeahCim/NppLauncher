using System;
using System.Diagnostics;
using System.ComponentModel;

namespace Launcher
{
    class MyProcess
    {
        // Uses the ProcessStartInfo class to start a new process, 
        // in hidden mode. 
        void OpenWithStartInfo()
        {
            ProcessStartInfo startInfo =
                new ProcessStartInfo(
                    "c:\\Program Files\\Notepad++\\notepad++.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Get command line arguments and pass them on.
            string[] arguments = Environment.GetCommandLineArgs();
            arguments.SetValue("",0);
            startInfo.Arguments = String.Join(" ", arguments);

            Process.Start(startInfo);
        }

        static void Main()
        {
            MyProcess myProcess = new MyProcess();
            myProcess.OpenWithStartInfo();
        }
    }
}