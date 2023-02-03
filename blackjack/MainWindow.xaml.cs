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
using static System.Net.Mime.MediaTypeNames;

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
            InitalizeCards();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            lb_mainlogo.Visibility = Visibility.Hidden;
            img_dealercard1.Visibility = Visibility.Visible;
            img_dealercard2.Visibility = Visibility.Visible;
            img_playercard1.Visibility = Visibility.Visible;
            img_playercard2.Visibility = Visibility.Visible;
            lb_winner.Visibility = Visibility.Visible;
            InitalizeCards();
        }
        private void InitalizeCards()
        {
            Random random = new Random();
            int playercard1 = random.Next(13)+1;
            string packUri = $"{playercard1+(random.Next(4)*13)}.gif";
            img_playercard1.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
            int playercard2 = random.Next(13) + 1;
            packUri = $"{playercard2 + (random.Next(4) * 13)}.gif";
            img_playercard2.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
            int dealercard1 = random.Next(13) + 1;
            packUri = $"{dealercard1 + (random.Next(4) * 13)}.gif";
            img_dealercard1.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
            int dealercard2 = random.Next(13) + 1;
            packUri = $"{dealercard2 + (random.Next(4) * 13)}.gif";
            img_dealercard2.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
            while(img_playercard1.Source == img_playercard2.Source || img_playercard1.Source == img_dealercard1.Source || img_playercard1.Source == img_dealercard2.Source || img_playercard2.Source == img_dealercard1.Source || img_playercard2.Source == img_dealercard2.Source || img_dealercard1.Source == img_dealercard2.Source)
            {
                InitalizeCards();
            }
            int playerpoints = playercard1 + playercard2;
            int dealerpoints = dealercard1 + dealercard2;
            if(playerpoints > 21)
            {
                lb_winner.Content = "vesztettel";
            }
            else if (playerpoints < dealerpoints)
            {
                lb_winner.Content = "vesztettel";
            }
            else if(playerpoints == dealerpoints)
            {
                lb_winner.Content = "vesztettel";
            }
            else
            {
                lb_winner.Content = "nyertel";
            }
        }
    }
}
