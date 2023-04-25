using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;


namespace GameMagicBall
{
    public partial class GameWindow : Window
    {
        readonly private string _nickName;

        public GameWindow(string nickName)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _nickName = nickName;
            MessengeTextBlock.Text = $"Уважаемый {nickName}, задайте вопрос\nМагическому шару:";
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void HideWindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void QuestionTextBox_TextChanged(object sender, TextCompositionEventArgs e)
        {
            if (QuestionTextBox.Text.Length == 46)
            {
                e.Handled = true;
            }
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionTextBox.Text.Length >= 3 && QuestionTextBox.Text[QuestionTextBox.Text.Length - 1] == Convert.ToChar("?"))
            {
                MagicBall0.Visibility = Visibility.Collapsed;
                MagicBall1.Visibility = Visibility.Visible;
                QuestionTextBox.Visibility = Visibility.Collapsed;
                QuestionTextBox.IsReadOnly = true;
                QuestionTextBlock.Visibility = Visibility.Visible;
                ResultButton.Visibility = Visibility.Collapsed;
                ContinueButton.Visibility = Visibility.Visible;

                QuestionTextBlock.Text = "Вопрос: " + QuestionTextBox.Text;

                AnswerGeneration();

                QuestionTextBox.Text = "";
            }
            else
            {
                System.Windows.MessageBox.Show("Магический шар вас не понимает! \nВопрос является слишком коротким или в конце отсутствует '?'", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            MessengeTextBlock.Text = $"Уважаемый {_nickName}, задайте вопрос\nМагическому шару:";

            MagicBall0.Visibility = Visibility.Visible;
            MagicBall1.Visibility = Visibility.Collapsed;
            QuestionTextBlock.Visibility = Visibility.Collapsed;
            QuestionTextBox.IsReadOnly = false;
            QuestionTextBox.Visibility = Visibility.Visible;
            ContinueButton.Visibility = Visibility.Collapsed;
            ResultButton.Visibility = Visibility.Visible;
        }

        void AnswerGeneration()
        {
            Random rnd = new Random();

            int answerNum = rnd.Next(1, 7);
            string answer = "";

            switch (answerNum)
            {
                case 1:
                    answer = "да";
                    break;
                case 2:
                    answer = "нет";
                    break;
                case 3:
                    answer = "скорее всего да";
                    break;
                case 4:
                    answer = "скорее всего нет";
                    break;
                case 5:
                    answer = "возможно";
                    break;
                case 6:
                    answer = "имеются перспективы";
                    break;
                default:
                    break;
            }

            int phraseNum = rnd.Next(1, 6);

            switch (phraseNum)
            {
                case 1:
                    MessengeTextBlock.Text = $"За окном прогремел гром, и {_nickName} увидел ответ: {answer}";
                    break;
                case 2:
                    MessengeTextBlock.Text = $"{_nickName} почувствовал, что земля под ним трясется, и увидел ответ в магическом шаре: {answer}";
                    break;
                case 3:
                    MessengeTextBlock.Text = $"По телу {_nickName} пробежала дрожь, он увидел ответ в шаре: {answer}";
                    break;
                case 4:
                    MessengeTextBlock.Text = $"Яркая вспышка на секунду ослепила {_nickName}, магический шар дал свой ответ: {answer}";
                    break;
                case 5:
                    MessengeTextBlock.Text = $"Магический шар в одно мгновение заискрился и дал ответ: {answer}";
                    break;
                default:
                    QuestionTextBlock.Text = "???????????????????????????????????";
                    MessengeTextBlock.Text = $"MаГиЧеСкИй ШаР СоШеЛ c УмА! ОшИбКа В кОдЕ...";
                    break;
            }

            ExportStatistics(answer);
        }

        void ExportStatistics(string answer)
        {
            string pathToExportFile = "Statistics.txt";

            using (StreamWriter sw = new StreamWriter(pathToExportFile, true))
            {
                sw.WriteLine($"{_nickName}   |   {QuestionTextBox.Text}   |   {answer}");
                StatisticsListView.Items.Add($"{_nickName}   |   {QuestionTextBox.Text}   |   {answer}");
            }
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void StatisticCheckButton_Click(object sender, RoutedEventArgs e)
        {
            if (StatisticsListView.Visibility == Visibility.Collapsed)
            {
                StatisticsListView.Visibility = Visibility.Visible;
            }
            else
            {
                StatisticsListView.Visibility = Visibility.Collapsed;
            }
        }


        private void GameWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                Help.ShowHelp(null, "Lab6_3.chm");
            }
        }
    }
}