// BlackJack Asssignment 1
// Made By:
// Aryan Arora 
// Karan Singh Sandhu


using BlackjackNS;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
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

namespace BlackJackAssignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        string basePath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();

        public MainWindow()
        {
            InitializeComponent();
            string path = "/song/song.wav";
            SoundPlayer player = new SoundPlayer(basePath + path);
            player.Load();
            player.PlayLooping();
        }

        Blackjack game = new Blackjack();

        private void Reset(object sender, RoutedEventArgs e)
        {
            RemoveAll();
            game.End(); 
            TextBox textBox = new TextBox();
            textBox.BorderBrush = null;
            textBox.Background = null;
            textBox.IsReadOnly = true;
            textBox.Foreground = Brushes.Black;
            textBox.Background = Brushes.Green;
            textBox.FontSize = 28;
            textBox.FontFamily = new FontFamily("Cambria");
            textBox.Text = "Welcome back to BlackJack!\nin for another round?";
            textBox.HorizontalAlignment = HorizontalAlignment.Center;
            ScorePanel.Children.Add(textBox);
            StartButton.IsEnabled = true;
            HitButton.IsEnabled = false;
            StandButton.IsEnabled = false;
            ResetButton.IsEnabled = false;
        }
        private void Start(object sender, RoutedEventArgs e)
        {

            game.Start();

            clrscr();
            StartButton.IsEnabled = false;
            HitButton.IsEnabled = true;
            StandButton.IsEnabled = true;
            ResetButton.IsEnabled = true;

        }

        private void Hit(object sender, RoutedEventArgs e)
        {
            int total = game.Hit();
            clrscr();
            if (total == 0)
            {
                clrscr(true);
                MessageBox.Show("You have Busted!");
                HitButton.IsEnabled = false;
                StandButton.IsEnabled = false;
            }
            else if (total == -1)
            {
                clrscr(true);
                string path = "/song/blackjack1.wav";
                SoundPlayer player = new SoundPlayer(basePath + path);
                player.Load();
                player.Play();
                MessageBox.Show("You have Won!");
                HitButton.IsEnabled = false;
                StandButton.IsEnabled = false;
                string path1 = "/song/song.wav";
                SoundPlayer player1 = new SoundPlayer(basePath + path1);
                player1.Load();
                player1.PlayLooping();
            }

        }

        private void Stand(object sender, RoutedEventArgs e)
        {
            int result = game.Stand();
            clrscr(true);
            if (result == 0)
            {
                MessageBox.Show("You Won!");
                HitButton.IsEnabled = false;
            }
            if (result == 1)
            {
                MessageBox.Show("It's Tie!");

            }
            if (result == 2)
            {
                MessageBox.Show("Dealer won!");
            }
            HitButton.IsEnabled = false;
            StandButton.IsEnabled = false;
        }



        public void RemoveAll()
        {
            PlayerPanel.Children.Clear();
            DealerPanel.Children.Clear();
            ScorePanel.Children.Clear();
        }

        public void ShowScore(bool isDealer, Panel panel)
        {
            panel.Children.Clear();
            TextBox textBox1 = new TextBox();
            textBox1.BorderBrush = null;
            textBox1.Background = null;
            textBox1.IsReadOnly = true;
            textBox1.FontSize = 28;
            textBox1.Foreground = Brushes.White;
            textBox1.FontFamily = new FontFamily("Cambria");
            textBox1.Margin = new Thickness(-50, -300, 0, 0);
            if (isDealer)
            {
                textBox1.Text = "Dealer value: " + game.GetDealerSum(true);
            }
            else
            {

                textBox1.Text = "Dealer value: " + game.GetDealerSum();
            }
            TextBox textBox = new TextBox();
            textBox.BorderBrush = null;
            textBox.Background = null;
            textBox.IsReadOnly = true;
            textBox.Foreground = Brushes.White;
            textBox.FontSize = 28;
            textBox.Margin = new Thickness(-190, 40, 0, 0);
            textBox.FontFamily = new FontFamily("Cambria");
            textBox.Text = "Your Value: " + game.GetPlayerSum();
            panel.Children.Add(textBox1);
            panel.Children.Add(textBox);
        }
        public void clrscr(bool isStand)
        {
            RemoveAll();
            //PlayerPanel.Children.Clear();
            //DealerPanel.Children.Clear();
            if (isStand)
            {

                foreach (Card c in game.GetPlayerCards())
                {
                    ShowCard(c, PlayerPanel);
                }
                foreach (Card c in game.GetDealerCards())
                {

                    ShowCard(c, DealerPanel);

                }
            }
            ShowScore(false, ScorePanel);
        }

        public void clrscr()
        {
            RemoveAll();
            //PlayerPanel.Children.Clear();
            //DealerPanel.Children.Clear();
            int count = 0;
            foreach (Card c in game.GetPlayerCards())
            {
                ShowCard(c, PlayerPanel);
            }
            foreach (Card c in game.GetDealerCards())
            {
                if (count == 0)
                {
                    ShowCard(c, DealerPanel);
                }
                else
                {
                    ShowCard(DealerPanel);
                }
                count++;

            }
            ShowScore(true, ScorePanel);
        }

        public void ShowCard(Card c, Panel panel)
        {
            string path = "/images/";
            string filename = c.GetFileName();
            Uri uri = new Uri(basePath + path + filename);
            BitmapImage bitmapImage = new BitmapImage(uri);
            Image image = new Image();
            image.Source = bitmapImage;
            image.Margin = new Thickness(-75, 0, 0, 0);
            panel.Children.Add(image);
        }

        public void ShowCard(Panel panel)
        {
            string path = "/images/back.png";
            Uri uri = new Uri(basePath + path);
            BitmapImage bitmapImage = new BitmapImage(uri);
            Image image = new Image();
            image.Source = bitmapImage;
            image.Margin = new Thickness(-75, 0, 0, 0);
            panel.Children.Add(image);
        }

    }


}
