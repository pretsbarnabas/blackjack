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

namespace blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            lb_mainlogo.Visibility = Visibility.Hidden;
            btn_start.Visibility = Visibility.Hidden;
        }
        private void InitalizeCards()
        {
            List<int> cards = new List<int>();
            for (int i = 0; i < 52; i++)
            {
                cards.Add(i);
            }
        }
    }
}
