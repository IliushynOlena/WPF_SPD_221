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
using System.Windows.Threading;

namespace _06_Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private List<Button> buttons; // Список кнопок для елементів таблиці Шульте
        //private int currentButtonIndex = 1; // Поточний індекс кнопки для натискання
        //private DispatcherTimer timer; // Таймер для відліку часу гри
        //private int gameTimeInSeconds; // Кількість секунд на гру
        //private DateTime gameStartTime; // Час початку гри

        //public MainWindow()
        //{
        //    InitializeComponent();
        //    buttons = new List<Button>
        //    {
        //        Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8,
        //        Btn9, Btn10, Btn11, Btn12, Btn13, Btn14, Btn15, Btn16
        //    };

        //    // Перемішуємо значення на кнопках
        //    ShuffleButtons();

        //    timer = new DispatcherTimer();
        //    timer.Interval = TimeSpan.FromSeconds(1);
        //    timer.Tick += Timer_Tick;
        //}

        //private void ShuffleButtons()
        //{
        //    Random random = new Random();
        //    var shuffledNumbers = Enumerable.Range(1, 16).OrderBy(x => random.Next()).ToList();

        //    for (int i = 0; i < buttons.Count; i++)
        //    {
        //        buttons[i].Content = shuffledNumbers[i];
        //    }
        //}

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    int elapsedSeconds = (int)(DateTime.Now - gameStartTime).TotalSeconds;
        //    int remainingSeconds = gameTimeInSeconds - elapsedSeconds;

        //    if (remainingSeconds <= 0)
        //    {
        //        timer.Stop();
        //        ShowGameResult("You Lose!");
        //    }

        //    UpdateProgressBar(remainingSeconds);
        //}

        //private void StartButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (int.TryParse(timeSlider.Value.ToString(), out gameTimeInSeconds))
        //    {
        //        gameStartTime = DateTime.Now;
        //        currentButtonIndex = 1;
        //        ShuffleButtons();
        //        timer.Start();
        //        EnableButton(currentButtonIndex);
        //    }
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (sender is Button button)
        //    {
        //        int buttonValue = int.Parse(button.Content.ToString());

        //        if (buttonValue == currentButtonIndex)
        //        {
        //            button.IsEnabled = false;
        //            currentButtonIndex++;

        //            if (currentButtonIndex > buttons.Count)
        //            {
        //                timer.Stop();
        //                ShowGameResult("You Win!");
        //            }
        //            else
        //            {
        //                EnableButton(currentButtonIndex);
        //            }
        //        }
        //    }
        //}

        //private void EnableButton(int index)
        //{
        //    foreach (var button in buttons)
        //    {
        //        button.IsEnabled = (int.Parse(button.Content.ToString()) == index);
        //    }
        //}

        //private void ShowGameResult(string result)
        //{
        //    MessageBox.Show(result, "Game Result", MessageBoxButton.OK, MessageBoxImage.Information);
        //}

        //private void UpdateProgressBar(int remainingSeconds)
        //{
        //    ProgBar.Value = gameTimeInSeconds - remainingSeconds;
        //}










        private DispatcherTimer timer;
        private int seconds = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); // Інтервал 5 секунд
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            seconds++;
            Time_Lb.Content = $"Time : {seconds} sec";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            Random random = new Random();

            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            int index = 0;
            foreach (var item in uniformGrid.Children)
            {
                if (item is Button button)
                {
                    button.Content = arr[index];
                    index++;
                }
            }

            //foreach (var item in uniformGrid.Children)
            //{
            //    if (item is Button button)
            //    {
            //        if ((int)button.Content != 1)
            //            button.IsEnabled = false;
            //    }
            //}
        }


        private int currentButtonIndex = 1;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            //foreach (var item in uniformGrid.Children)
           
                Button item = sender as Button;
                if (item is Button button)
                {
                    if ((int)button.Content == currentButtonIndex)
                    {
                        button.Background = Brushes.Green;
                       
                        //button.IsEnabled = true;
                        currentButtonIndex++;
                    }
                    else
                    {
                        button.Background = Brushes.Red;    
                    }

                    if ((int)button.Content == currentButtonIndex - 1)
                    {
                        

                    }
                }

           
            if (currentButtonIndex == 17)
            {
                timer.Stop();
                currentButtonIndex = 1;
            }
            ProgBar.Value += ProgBar.Maximum / uniformGrid.Children.Count;
            //item.IsEnabled = false;
            //// Переконайтеся, що індекс кнопки не виходить за межі масиву
            //if (currentButtonIndex < uniformGrid.Children.Count)
            //{
            //    // Деактивуйте попередню кнопку, якщо вона існує
            //    if (currentButtonIndex > 0)
            //    {
            //        var prevButton = uniformGrid.Children[currentButtonIndex - 1] as Button;
            //        if (prevButton != null)
            //        {
            //            prevButton.IsEnabled = false;
            //            prevButton.Background = Brushes.Gray; // Змініть колір фону на початковий
            //        }
            //    }
            //    // Активуйте поточну кнопку
            //    var currentButton = uniformGrid.Children[currentButtonIndex] as Button;
            //    if (currentButton != null)
            //    {
            //        currentButton.IsEnabled = true;
            //        currentButton.Background = Brushes.Green; // Змініть колір фону на зелений
            //    }
            //    currentButtonIndex++; // Перейдіть до наступної кнопки
            //}
        }
    }
}
