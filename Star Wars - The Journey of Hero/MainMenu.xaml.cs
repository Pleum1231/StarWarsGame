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
using System.Media;

namespace Star_Wars___The_Journey_of_Hero
{

    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        
        public MainMenu()
        {
            
            InitializeComponent();
         
        }



        private void ReplayMain (object sender, RoutedEventArgs e)
        {
            Main.Position = TimeSpan.FromSeconds(0);
            Main.Play();
        }



        private void Play_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SelectMode.xaml", UriKind.RelativeOrAbsolute));
        }



        private void HowtoPlay_Click(object sender, RoutedEventArgs e)
        {
            Rule.Visibility = Visibility.Visible;
            OK.Visibility = Visibility.Visible;
        }



        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Main.Play();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Rule.Visibility = Visibility.Hidden;
            OK.Visibility = Visibility.Hidden;
        }
    }
}
