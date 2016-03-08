using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LearningLine.Practice
{
    class FolderWatcher
    {
        public string LogFilePath { get; private set; }
        FileSystemWatcher FileWatcher { get; set; }
        ObservableCollection<string> MessageLog { get; set; }

        public FolderWatcher(string path)
        {
            LogFilePath = path + @"\FolderWatchLog.txt";
            File.WriteAllText(LogFilePath, "FolderWatcher started.\n");
            FileWatcher = new FileSystemWatcher(path) { EnableRaisingEvents = true };
            MessageLog = new ObservableCollection<string>();
                       

            // TODO: whenever a file is created, renamed or deleted,
            FileWatcher.Created += onFileWatcher_Changed_LogToMessageLog;
            FileWatcher.Renamed += onFileWatcher_Changed_LogToMessageLog;
            FileWatcher.Deleted += onFileWatcher_Changed_LogToMessageLog;

            // TODO: whenever a message is added to messageLog
            // write that message to the console
            MessageLog.CollectionChanged += new NotifyCollectionChangedEventHandler(onMessageLog_Collection_Added_PrintToConsole);

            // TODO: whenever a message is added to messageLog
            // write that message to a log file
            MessageLog.CollectionChanged += new NotifyCollectionChangedEventHandler(onMessageLog_Collection_Added_PrintToFile);

        }

        void onMessageLog_Collection_Added_PrintToConsole(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine(item);
                }
            }
            
        }

        void onFileWatcher_Changed_LogToMessageLog(object sender, FileSystemEventArgs e)
        {
            var msg = String.Format("{0}: {1}", e.ChangeType, e.FullPath);

            MessageLog.Add(msg);

        }

        void onMessageLog_Collection_Added_PrintToFile(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    File.AppendAllText(LogFilePath, item.ToString() + "\n");
                    
                }
            }

        }
    }
}
