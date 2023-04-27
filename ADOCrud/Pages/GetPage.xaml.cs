using ADOCrud.Data.Repositories;
using System.Windows;
using System.Windows.Controls;

namespace ADOCrud.Pages
{
    /// <summary>
    /// Interaction logic for GetPage.xaml
    /// </summary>
    public partial class GetPage : Page
    {
        public GetPage()
        {
            InitializeComponent();
        }

        UserRepository userRepository = new UserRepository();

        private async void get_click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(get_id.Text);
            var user = await userRepository.GetAsync(num);
            MessageBox.Show(user.Id + "\n" + user.FirstName + "\n" + user.LastName + "\n" + user.Email + "\n" + user.Password);
            get_id.Clear();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

    }
}
