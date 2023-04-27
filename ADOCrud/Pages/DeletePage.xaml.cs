using ADOCrud.Data.Repositories;
using System.Windows;
using System.Windows.Controls;

namespace ADOCrud.Pages
{
    /// <summary>
    /// Interaction logic for DeletePage.xaml
    /// </summary>
    public partial class DeletePage : Page
    {
        public DeletePage()
        {
            InitializeComponent();
        }

        UserRepository userRepository = new UserRepository();
        private async void delete_click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(delete_id.Text);

            await userRepository.DeleteAsync(num);
            MessageBox.Show("User delete successfully!");

            delete_id.Clear();

        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

    }
}
