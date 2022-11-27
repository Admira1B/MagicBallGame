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

namespace GameMagicBall
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        public string nickName;

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnterNickNameTextBox.Text))
            {
                EnterNickNameTextBox.Text = "";
                MessageBox.Show("Поле ввода имени не должно быть пустым!", "Магия не работает!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                nickName = EnterNickNameTextBox.Text;
                GameWindow gameWindow = new GameWindow(nickName);
                gameWindow.Show();
                this.Close();
            }
        }

        private void EnterNickName_TextChanged(object sender, TextCompositionEventArgs e)
        {
            if (EnterNickNameTextBox.Text.Length == 15)
            {
                e.Handled = true;
            }
        }
    }
}
