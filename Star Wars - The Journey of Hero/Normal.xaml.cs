using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Star_Wars___The_Journey_of_Hero
{
    /// <summary>
    /// Interaction logic for Normal.xaml
    /// </summary>
    public partial class Normal : Page
    {
        public Normal()
        {
            InitializeComponent();
        }



        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer Etimer = new DispatcherTimer();
        Random random = new Random();
        int status = 0;
        int Estatus = 0;
        int check = 0;
        int PlayerHP = 2;
        int EnemyHP = 2;
        int rocknum;
        int scissorsnum;
        int papernum;
        int PlayerSelect;



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NormalTheme.Play();
            timer.Tick += new EventHandler(dispatTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 375);
            timer.Start();
            Etimer.Tick += new EventHandler(EdispatTick);
            Etimer.Interval = new TimeSpan(0, 0, 0, 0, 50);
        }



        private void dispatTick(object sender, EventArgs e)
        {
            if (status == 0)
            {
                Luke.Source = new BitmapImage(new Uri("Resource/Luke/LukeStand2.png", UriKind.Relative));
                Stromtrooper.Source = new BitmapImage(new Uri("Resource/Stromtrooper/StromtrooperStand.png", UriKind.Relative));
                status = 1;
            }
            else if (status == 1)
            {
                Luke.Source = new BitmapImage(new Uri("Resource/Luke/LukeStand1.png", UriKind.Relative));
                Stromtrooper.Source = new BitmapImage(new Uri("Resource/Stromtrooper/StromtrooperStand.png", UriKind.Relative));
                status = 0;
            }
            else if (status == 2)
            {
                Luke.Source = new BitmapImage(new Uri("Resource/Luke/LukeAttack.png", UriKind.Relative));

            }
            else if (status == 3)
            {
                Stromtrooper.Source = new BitmapImage(new Uri("Resource/Stromtrooper/StromtrooperAttack2.png", UriKind.Relative));

            }
        }



        private void EdispatTick(object sender, EventArgs e)
        {
            if (status == 3)
            {
                if (Estatus == 1)
                {
                    PHit.Source = new BitmapImage(new Uri("Resource/Effect/hit1.png", UriKind.Relative));
                    Estatus = 2;
                }
                else if (Estatus == 2)
                {
                    PHit.Source = new BitmapImage(new Uri("Resource/Effect/hit2.png", UriKind.Relative));
                    Estatus = 3;
                }
                else if (Estatus == 3)
                {
                    PHit.Source = new BitmapImage(new Uri("Resource/Effect/hit3.png", UriKind.Relative));
                    Estatus = 4;
                }
                else if (Estatus == 4)
                {
                    PHit.Source = new BitmapImage(new Uri("Resource/Effect/hit4.png", UriKind.Relative));
                    Estatus = 5;
                    PlayerHP--;
                    PHpNum.Text = PlayerHP.ToString();
                    if (PlayerHP == 0)
                    {
                        LukeLose.Play();
                        Luke.Visibility = Visibility.Hidden;
                    }
                }
                else if (Estatus == 5)
                {
                    PHit.Source = new BitmapImage(new Uri("Resource/Effect/hit5.png", UriKind.Relative));
                    Estatus = 6;
                }
                else if (Estatus == 6)
                {
                    PHit.Source = new BitmapImage(new Uri("Resource/Effect/hit6.png", UriKind.Relative));
                    Estatus = 7;
                }
                else if (Estatus == 7)
                {
                    PHit.Source = new BitmapImage(new Uri("Resource/Effect/hit7.png", UriKind.Relative));
                    Estatus = 8;
                }
                else if (Estatus == 8)
                {
                    PHit.Source = new BitmapImage(new Uri("Resource/Effect/hit8.png", UriKind.Relative));
                    Estatus = 0;
                    Etimer.Stop();
                    ShowIcon();
                    status = 1;
                }
            }

            else if (status == 2)
            {
                if (Estatus == 1)
                {
                    EHit.Source = new BitmapImage(new Uri("Resource/Effect/hit1.png", UriKind.Relative));
                    Estatus = 2;
                }
                else if (Estatus == 2)
                {
                    EHit.Source = new BitmapImage(new Uri("Resource/Effect/hit2.png", UriKind.Relative));
                    Estatus = 3;
                }
                else if (Estatus == 3)
                {
                    EHit.Source = new BitmapImage(new Uri("Resource/Effect/hit3.png", UriKind.Relative));
                    Estatus = 4;
                }
                else if (Estatus == 4)
                {
                    EHit.Source = new BitmapImage(new Uri("Resource/Effect/hit4.png", UriKind.Relative));
                    Estatus = 5;
                    EnemyHP--;
                    EHpNum.Text = EnemyHP.ToString();
                    if (EnemyHP == 0)
                    {
                        StromtrooperLose.Play();
                        Stromtrooper.Visibility = Visibility.Hidden;
                    }

                }
                else if (Estatus == 5)
                {
                    EHit.Source = new BitmapImage(new Uri("Resource/Effect/hit5.png", UriKind.Relative));
                    Estatus = 6;
                }
                else if (Estatus == 6)
                {
                    EHit.Source = new BitmapImage(new Uri("Resource/Effect/hit6.png", UriKind.Relative));
                    Estatus = 7;
                }
                else if (Estatus == 7)
                {
                    EHit.Source = new BitmapImage(new Uri("Resource/Effect/hit7.png", UriKind.Relative));
                    Estatus = 8;
                }
                else if (Estatus == 8)
                {
                    EHit.Source = new BitmapImage(new Uri("Resource/Effect/hit8.png", UriKind.Relative));
                    Estatus = 0;
                    Etimer.Stop();
                    ShowIcon();
                    status = 1;
                }
            }
        }


        
        private void ReplayNormal(object sender, RoutedEventArgs e)
        {
            NormalTheme.Position = TimeSpan.FromSeconds(0);
            NormalTheme.Play();
        }



        private void Rock_Click(object sender, RoutedEventArgs e)
        {
            RockText.Text = " ";
            PlayerSelect = 1;
            Calculate();
        }



        private void Rock_MouseEnter(object sender, MouseEventArgs e)
        {
            RockText.Text = "rock";
        }



        private void Rock_MouseLeave(object sender, MouseEventArgs e)
        {
            RockText.Text = " ";
        }



        private void Scissors_Click(object sender, RoutedEventArgs e)
        {
            ScissorsText.Text = " ";
            PlayerSelect = 2;
            Calculate();
        }



        private void Scissors_MouseEnter(object sender, MouseEventArgs e)
        {
            ScissorsText.Text = "scissors";
        }



        private void Scissors_MouseLeave(object sender, MouseEventArgs e)
        {
            ScissorsText.Text = " ";
        }



        private void Paper_Click(object sender, RoutedEventArgs e)
        {
            PaperText.Text = " ";
            PlayerSelect = 3;
            Calculate();
        }



        private void Paper_MouseEnter(object sender, MouseEventArgs e)
        {
            PaperText.Text = "paper";

        }



        private void Paper_MouseLeave(object sender, MouseEventArgs e)
        {
            PaperText.Text = " ";
        }



        private void Calculate()
        {
            Rock.Visibility = Visibility.Hidden;
            Paper.Visibility = Visibility.Hidden;
            Scissors.Visibility = Visibility.Hidden;

            if (PlayerSelect == 1)
                Pselect.Source = new BitmapImage(new Uri("Resource/Buttom Icon/rock.png", UriKind.Relative));
            else if (PlayerSelect == 2)
                Pselect.Source = new BitmapImage(new Uri("Resource/Buttom Icon/scissors.png", UriKind.Relative));
            else
                Pselect.Source = new BitmapImage(new Uri("Resource/Buttom Icon/paper.png", UriKind.Relative));


            check = random.Next(1, 101);

            if (check <= rocknum)
                check = 1;
            else if (check <= rocknum + scissorsnum)
                check = 2;
            else
                check = 3;

            Wait.Play();

            if (check <= 1)
                Eselect.Source = new BitmapImage(new Uri("Resource/Buttom Icon/Erock.png", UriKind.Relative));
            else if (check <= 2)
                Eselect.Source = new BitmapImage(new Uri("Resource/Buttom Icon/Escissors.png", UriKind.Relative));
            else
                Eselect.Source = new BitmapImage(new Uri("Resource/Buttom Icon/Epaper.png", UriKind.Relative));

            OK.Visibility = Visibility.Visible;

        }



        private void Game()
        {

            rocknum = random.Next(0, 101);
            scissorsnum = random.Next(0, 101 - rocknum);
            papernum = 100 - (rocknum + scissorsnum);

            RockPer.Text = rocknum.ToString();
            ScissorsPer.Text = scissorsnum.ToString();
            PaperPer.Text = papernum.ToString();
        }



        private void ShowIcon()
        {
            if (PlayerHP > 0 && EnemyHP > 0)
            {
                Rock.Visibility = Visibility.Visible;
                Paper.Visibility = Visibility.Visible;
                Scissors.Visibility = Visibility.Visible;

                Pselect.Visibility = Visibility.Visible;
                Eselect.Visibility = Visibility.Visible;

                RockSelect.Visibility = Visibility.Visible;
                ScissorsSelect.Visibility = Visibility.Visible;
                PaperSelect.Visibility = Visibility.Visible;

                RockText.Visibility = Visibility.Visible;
                ScissorsText.Visibility = Visibility.Visible;
                PaperText.Visibility = Visibility.Visible;

                RockPer.Visibility = Visibility.Visible;
                ScissorsPer.Visibility = Visibility.Visible;
                PaperPer.Visibility = Visibility.Visible;

                Game();
            }
            else
            {
                NormalTheme.Stop();
                End.Visibility = Visibility.Visible;
                if (PlayerHP == 0)
                {
                    Lose.Play();
                    End.Text = "You Lose!";
                    OK.Visibility = Visibility.Visible;
                }
                else
                {
                    Win.Play();
                    End.Text = "You Win!";
                    OK.Visibility = Visibility.Visible;
                }
            }
        }



        private void HiddenIcon()
        {
            Pselect.Visibility = Visibility.Hidden;
            Eselect.Visibility = Visibility.Hidden;

            RockSelect.Visibility = Visibility.Hidden;
            ScissorsSelect.Visibility = Visibility.Hidden;
            PaperSelect.Visibility = Visibility.Hidden;

            RockText.Visibility = Visibility.Hidden;
            ScissorsText.Visibility = Visibility.Hidden;
            PaperText.Visibility = Visibility.Hidden;
        }



        private void OK_Click(object sender, RoutedEventArgs e)
        {
            OK.Visibility = Visibility.Hidden;
            RockSelect.Visibility = Visibility.Hidden;
            ScissorsSelect.Visibility = Visibility.Hidden;
            PaperSelect.Visibility = Visibility.Hidden;
            RockPer.Visibility = Visibility.Hidden;
            ScissorsPer.Visibility = Visibility.Hidden;
            PaperPer.Visibility = Visibility.Hidden;

            if (PlayerHP == 0 || EnemyHP == 0)
                this.NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
            
            Eselect.Source = new BitmapImage(new Uri("Resource/Buttom Icon/QM.png", UriKind.Relative));
            Pselect.Source = new BitmapImage(new Uri("Resource/Buttom Icon/QM.png", UriKind.Relative));
            Eselect.Visibility = Visibility.Hidden;
            Pselect.Visibility = Visibility.Hidden;

            if ((PlayerSelect == 1 && check == 2) || (PlayerSelect == 2 && check == 3) || (PlayerSelect == 3 && check == 1))
            {
                Estatus = 1;
                Swing.Play();
                status = 2;
            }

            else if ((PlayerSelect == 1 && check == 3) || (PlayerSelect == 2 && check == 1) || (PlayerSelect == 3 && check == 2))
            {
                Estatus = 1;
                Shoot.Play();
                status = 3;
            }

            else
            {
                ShowIcon();
            }
        }



        private void Swing_MediaEnded(object sender, RoutedEventArgs e)
        {
            Swing.Stop();
            Crash.Play();
            Etimer.Start();
        }



        private void Crash_MediaEnded(object sender, RoutedEventArgs e)
        {
            Crash.Stop();
        }



        private void Shoot_MediaEnded(object sender, RoutedEventArgs e)
        {
            Shoot.Stop();
            Crash.Play();
            Etimer.Start();
        }



        private void Start_MediaEnded(object sender, RoutedEventArgs e)
        {
            ShowIcon();
        }
    }
}

