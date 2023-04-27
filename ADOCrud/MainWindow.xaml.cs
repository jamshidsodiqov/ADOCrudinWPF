using ADOCrud.Data.Contexts;
using ADOCrud.Data.Repositories;
using ADOCrud.Pages;
using System.Windows;

namespace ADOCrud
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void createbtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new CreatePage();
        }

        private void deletebtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new DeletePage();
        }

        private void getallbtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new GetAllPage();
        }

        private void getbtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new GetPage();
        }

        private void updatebtn_click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new UpdatePage();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void truncatebtn_click(object sender, RoutedEventArgs e)
        {
            UserRepository repos = new UserRepository();

            repos.TruncateAsync();
            MessageBox.Show("Database TRUNCATED successfully!");
        }
    }
}
