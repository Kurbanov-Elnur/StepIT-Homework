using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _12_Login.Models;

namespace _12_Login.Views
{
    public partial class MainView : Window
    {
        public static Frame Frame { get; set; } = new();

        public MainView()
        {
            InitializeComponent();
            Frame.Content = new SignIn();
            Main.Content = Frame;
            DataContext = new SignUp();
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void maximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
