using _12_Login.Models;
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

namespace _12_Login.Views
{ 
    public partial class SignUp : Page
    {
        public User UserToAdd { get; set; } = new User();
        

        public SignUp()
        {
            InitializeComponent();
            DataContext = new User();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name.Text = UserToAdd.Name;
        }
    }
}
