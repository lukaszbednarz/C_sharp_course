using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LearningLine.Practice
{
    class MainWindow : Window
    {
        public event EventHandler Start;
        public event EventHandler Pause;
        public event EventHandler Stop;

        public MainWindow()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Title = "Background Music Player";
            this.SizeToContent = SizeToContent.WidthAndHeight;
            this.Background = new SolidColorBrush(Colors.BlanchedAlmond);
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStyle = WindowStyle.ToolWindow;
            this.FontSize = 16.0;

            var buttonStart = new Button() { Content = "Start", Width = 100, Height = 50 };
            var buttonPause = new Button() { Content = "Pause", Width = 100, Height = 50 };
            var buttonStop = new Button() { Content = "Stop", Width = 100, Height = 50 };
            var stackPanel = new StackPanel() { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };
            stackPanel.Children.Add(buttonStart);
            stackPanel.Children.Add(buttonPause);
            stackPanel.Children.Add(buttonStop);
            this.Content = stackPanel;

            buttonStart.Click += (o, e) => { if (Start != null) Start(this, EventArgs.Empty); };
            buttonPause.Click += (o, e) => { if (Pause != null) Pause(this, EventArgs.Empty); };
            buttonStop.Click += (o, e) => { if (Stop != null) Stop(this, EventArgs.Empty); };
        }
    }
}
