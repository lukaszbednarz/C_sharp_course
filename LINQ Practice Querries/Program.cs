using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LINQ_Practice_Querries
{
    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {
            //ShowData(UnitedStatesDb.States);

            var q = from state in UnitedStatesDb.States
                    where state.Population > 10000000
                    orderby state.Population descending
                    select new { State = state.Name, People = state.Population };

            ShowData(q);

            Console.ReadLine();

        }



        // Requires references to the following WPF assemblies:

        // - PresentationCore

        // - PresentationFramework

        // - WindowsBase

        // - System.Xaml

        // requires that static void main be STA

        static void ShowData<T>(IEnumerable<T> data)
        {

            var win = new Window();

            var grid = new DataGrid();

            grid.ItemsSource = data.ToList();

            win.Content = grid;

            win.ShowDialog();

        }

    }
}
