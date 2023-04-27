using ADOCrud.Data.Repositories;
using ADOCrud.Domain.Users;
using System.Windows;
using System.Windows.Controls;

namespace ADOCrud.Pages
{
    public partial class UpdatePage : Page
    {
        public UpdatePage()
        {
            InitializeComponent();
        }

        UserRepository userRepository = new UserRepository();

        private async void update_click(object sender, RoutedEventArgs e)
        {
            await userRepository.UpdateAsync(new User
            {
                Id = int.Parse(update_id.Text),
                FirstName = firstname.Text,
                LastName = lastname.Text,
                Email = email.Text,
                Password = password.Password,
            });
            MessageBox.Show("User updated successfully!");
        }
        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
