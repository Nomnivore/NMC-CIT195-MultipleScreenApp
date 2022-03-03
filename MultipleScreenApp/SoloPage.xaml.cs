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

namespace MultipleScreenApp
{
    /// <summary>
    /// Interaction logic for SoloPage.xaml
    /// </summary>
    public partial class SoloPage : Page
    {
        public SoloPage()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TeamPage());
        }

        private void PrevBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new IntroPage());
        }
    }
}
