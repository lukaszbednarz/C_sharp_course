using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;

namespace DisposableFolderWatcher
{
    class FolderWatcher : IDisposable
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

            FileWatcher.Created += OnWatcherChanged;
            FileWatcher.Renamed += OnWatcherChanged;
            FileWatcher.Deleted += OnWatcherChanged;

            MessageLog.CollectionChanged += LogToConsole;
            MessageLog.CollectionChanged += LogToFile;
        }

        void OnWatcherChanged(object sender, FileSystemEventArgs e)
        {
            var msg = String.Format("{0}: {1}", e.ChangeType, e.FullPath);
            MessageLog.Add(msg);
        }

        void LogToConsole(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in e.NewItems)
            {
                Console.WriteLine(item);
            }
        }

        void LogToFile(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in e.NewItems)
	        {
                File.AppendAllText(LogFilePath, item.ToString() + "\n");
	        }
        }

        public void Dispose()
        {
            FileWatcher.Dispose();
        }
    }
}
