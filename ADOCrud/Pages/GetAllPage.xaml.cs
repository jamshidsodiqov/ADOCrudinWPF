using ADOCrud.Data.Repositories;
using ADOCrud.Domain.Users;
using System.Windows;
using System.Windows.Controls;

namespace ADOCrud.Pages
{
    /// <summary>
    /// Interaction logic for GetAllPage.xaml
    /// </summary>
    public partial class GetAllPage : Page
    {
        public  GetAllPage()
        {
            InitializeComponent();
        }

        UserRepository userRepository = new UserRepository();
        private async void getall_click(object sender, System.Windows.RoutedEventArgs e)
        {

            var users = await userRepository.GetAllAsync();
            foreach (var user in users)
            {
                User userData = new User();

                userData.Id = user.Id;
                userData.FirstName = user.FirstName;
                userData.LastName = user.LastName;
                userData.Email = user.Email;
                userData.Password = user.Password;
                DataGrid.Items.Add(userData);
            }
            

            //string str = "";
            //var users = await userRepository.GetAllAsync();
            //foreach (var user in users)
            //{
            //    //MessageBox.Show(user.Id + " " + user.FirstName + " " + user.LastName + " " + user.Email + " " + user.Password);
            //    str += user.Id + " " + user.FirstName + " " + user.LastName + " " + user.Email + " " + user.Password + "\n";
            //}
            //MessageBox.Show(str);

        }

        private void exitbtn_click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }


    }
}
