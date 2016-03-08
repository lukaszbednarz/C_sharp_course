using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace LearningLine.Practice
{
    class Program
    {
        static BackgroundMusicWrapper BackgroundMusic { get; set; }
        
        [STAThread]
        static void Main(string[] args)
        {
            
            BackgroundMusic = new BackgroundMusicWrapper();
            
            var win = new MainWindow();
            win.Start += OnStart;
            win.Stop += OnStop;
            win.Pause += OnPause;

            win.ShowDialog();
        }

        static void OnStart(object sender, EventArgs e)
        {
            BackgroundMusic.Play();
            LogMessage("Start pressed");
        }

        static void OnPause(object sender, EventArgs e)
        {
            BackgroundMusic.Pause();
            LogMessage("Pause pressed");
        }

        static void OnStop(object sender, EventArgs e)
        {
            BackgroundMusic.Stop();
            LogMessage("Stop pressed");
        }

        static void LogMessage(string msg)
        {
            using (var writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine("{0,-15}{1}", DateTime.Now.ToLongTimeString(), msg);
            }
         }
    }
}
