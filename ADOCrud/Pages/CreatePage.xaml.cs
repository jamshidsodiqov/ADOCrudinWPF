using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ADOCrud.Data.Repositories;
using ADOCrud.Domain;
using ADOCrud.Domain.Users;

namespace ADOCrud.Pages
{
    public partial class CreatePage : Page
    {
        public CreatePage()
        {
            
            InitializeComponent();
        }

        UserRepository userRepository = new UserRepository();

        public async void create_click(object sender, System.Windows.RoutedEventArgs e)
        {
            await userRepository.CreateAsync(new User
            {
                FirstName = firstname.Text,
                LastName = lastname.Text,
                Email = email.Text,
                Password = password.Password,
            });

            MessageBox.Show("User created successfully!");
            firstname.Clear();
            lastname.Clear();
            email.Clear();
            password.Clear();
        }

        private void exitbtn_click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
