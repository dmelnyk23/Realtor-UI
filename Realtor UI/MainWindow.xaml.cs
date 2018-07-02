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

namespace Realtor_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int accountButtClickCount = 0;
        Brush colorButtons;

        public MainWindow()
        {
            InitializeComponent();
            colorButtons = ForRent_Button.Background;
            All_RadioButton.IsChecked = true;
            AddLotsToDataGrid();

        }

        private void SignIn_Button_Click(object sender, RoutedEventArgs e)
        {
            SignIn_Button.Visibility = Visibility.Hidden;
            SignUp_Button.Visibility = Visibility.Hidden;
            Account_Button.Visibility = Visibility.Visible;
            Account_Icon.Visibility = Visibility.Visible;
        }
        
        private void SignUp_Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Account_Button_Click(object sender, RoutedEventArgs e)
        {
            accountButtClickCount++;
            if(accountButtClickCount % 2 != 0)
            {
            AccountMenu_ListBox.Visibility = Visibility.Visible;
            }
            else
            {
                AccountMenu_ListBox.Visibility = Visibility.Hidden;
            }
        }

        private void ForSale_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsActions(ForSale_Button.Content.ToString());
        }

        private void ForRent_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsActions(ForRent_Button.Content.ToString());

        }

        private void Reserved_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsActions(Reserved_Button.Content.ToString());

        }

        private void Sold_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsActions(Sold_Button.Content.ToString());

        }

        private void MyListings_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsActions(MyListings_Button.Content.ToString());
            accountButtClickCount++;
            AccountMenu_ListBox.Visibility = Visibility.Hidden;

        }

        private void MyReservations_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsActions(MyReservations_Button.Content.ToString());
            accountButtClickCount++;
            AccountMenu_ListBox.Visibility = Visibility.Hidden;

        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsActions(Exit_Button.Content.ToString());
            accountButtClickCount++;
            AccountMenu_ListBox.Visibility = Visibility.Hidden;
            All_RadioButton.IsChecked = true;
            Account_Button.Visibility = Visibility.Hidden;
            SignIn_Button.Visibility = Visibility.Visible;
            SignUp_Button.Visibility = Visibility.Visible;
            City_TextBox.Text = string.Empty;
            Country_TextBox.Text = string.Empty;
            PriceFrom_TextBox.Text = string.Empty;
            PriceTo_TextBox.Text = string.Empty;
            RoomsFrom_TextBox.Text = string.Empty;
            RoomsTo_TextBox.Text = string.Empty;
            SqrFtFrom_TextBox.Text = string.Empty;
            SqrFtTo_TextBox.Text = string.Empty;
            FloorFrom_TextBox.Text = string.Empty;
            FloorTo_TextBox.Text = string.Empty;
        }

        private void ButtonsActions(string butName)
        {
            switch (butName)
            {
                case "FOR SALE":
                    ForSale_Button.Background = Brushes.Transparent;
                    ForRent_Button.Background = colorButtons;
                    Reserved_Button.Background = colorButtons;
                    Sold_Button.Background = colorButtons;
                    MyListings_Label.Visibility = Visibility.Hidden;
                    MyReservations_Label.Visibility = Visibility.Hidden;
                    break;
                case "FOR RENT":
                    ForSale_Button.Background = colorButtons;
                    ForRent_Button.Background = Brushes.Transparent;
                    Reserved_Button.Background = colorButtons;
                    Sold_Button.Background = colorButtons;
                    MyListings_Label.Visibility = Visibility.Hidden;
                    MyReservations_Label.Visibility = Visibility.Hidden;
                    break;
                case "RESERVED":
                    ForSale_Button.Background = colorButtons;
                    ForRent_Button.Background = colorButtons;
                    Reserved_Button.Background = Brushes.Transparent;
                    Sold_Button.Background = colorButtons;
                    MyListings_Label.Visibility = Visibility.Hidden;
                    MyReservations_Label.Visibility = Visibility.Hidden;
                    break;
                case "SOLD":
                    ForSale_Button.Background = colorButtons;
                    ForRent_Button.Background = colorButtons;
                    Reserved_Button.Background = colorButtons;
                    Sold_Button.Background = Brushes.Transparent;
                    MyListings_Label.Visibility = Visibility.Hidden;
                    MyReservations_Label.Visibility = Visibility.Hidden;
                    break;
                case "My Listings":
                    ForSale_Button.Background = colorButtons;
                    ForRent_Button.Background = colorButtons;
                    Reserved_Button.Background = colorButtons;
                    Sold_Button.Background = colorButtons;
                    MyReservations_Label.Visibility = Visibility.Hidden;
                    MyListings_Label.Visibility = Visibility.Visible;
                    break;
                case "My Reservations":
                    ForSale_Button.Background = colorButtons;
                    ForRent_Button.Background = colorButtons;
                    Reserved_Button.Background = colorButtons;
                    Sold_Button.Background = colorButtons;
                    MyListings_Label.Visibility = Visibility.Hidden;
                    MyReservations_Label.Visibility = Visibility.Visible;
                    break;
                case "Exit":
                    ForSale_Button.Background = colorButtons;
                    ForRent_Button.Background = colorButtons;
                    Reserved_Button.Background = colorButtons;
                    Sold_Button.Background = colorButtons;
                    MyListings_Label.Visibility = Visibility.Hidden;
                    MyReservations_Label.Visibility = Visibility.Hidden;
                    break;
            }
        }

        private void AddLotsToDataGrid()
        {
            Lots_DataGrid.Items.Add(new DataGridLot
            {
                Street = "Soborna",
                City = "Rivne",
                Country = "Ukraine",
                Price = "120000",
                Floor = "5",
                Rooms = "3",
                SQR = "120.25",
                Decriptions = "Best apartment ever"
            });
            Lots_DataGrid.Items.Add(new DataGridLot
            {
                Street = "Makarova",
                City = "Rivne",
                Country = "Ukraine",
                Price = "50000",
                Floor = "3",
                Rooms = "1",
                SQR = "50",
                Decriptions = "Norm"
            });
        }
    }
}