using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Discord_Rpc.App
{
    public class AppManager
    {
        public static Dictionary<string, string[]> apps = new Dictionary<string, string[]>()
        {
            { "Code", new string[] { "Code", "visual-studio-code", "Writing Code", "Visual Studio Code" }},
            { "Discord", new string[] { "Discord", "discord", "Just chatting", "Discord" }},
            { "WindowsTerminal", new string[] { "WindowsTerminal", "terminal", "Just Typing away", "Windows Terminal" }},
            { "Steam", new string[] { "Steam", "steam", "Playing Games", "Steam" }},
            { "Spotify", new string[] { "Spotify", "spotify", "Listening to Music", "Spotify" }},
            { "ShareX", new string[] { "ShareX", "sharex", "Taking Screenshots", "ShareX" }},
            { "None", new string[] { "None", "trans", "At Her Desktop", "None" }}

        };

        public static string getActiveApp()
        {
            var foregroundWindow = GetForegroundWindow();
            uint processId;
            GetWindowThreadProcessId(foregroundWindow, out processId);
            var process = Process.GetProcessById((int)processId);


            foreach (var app in apps)
            {
                if (process.ProcessName == app.Value[0])
                {
                    return app.Key;
                }
            }

            return "None";
        }


        public static string getActiveAppImage(string activeApp)
        {
            return apps[activeApp][1];
        }

        public static string GetActiveAppWindowName(string activeApp)
        {
            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName == apps[activeApp][1])
                {
                    return process.MainWindowTitle;
                }
            }

            return "None";
        }
        // I wanna die. This is so bad.
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);


        public static string getAppDetails(string appname)
        {
            foreach (var app in apps)
            {
                if (app.Key == appname)
                {
                    return app.Value[2];
                }
            }

            return "None";
        }

        public static string[] getAppDetailsArray(string appname)
        {
            foreach (var app in apps)
            {
                if (app.Key == appname)
                {
                    return app.Value;
                }
            }

            return new string[] { "None", "None", "None" };
        }
    }
}