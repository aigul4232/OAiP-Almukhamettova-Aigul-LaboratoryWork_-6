using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OAIP_Laba6_23
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckLeapYear_Click(object sender, RoutedEventArgs e)
        {
            int year;

            if (!int.TryParse(YearTextBox.Text, out year))
            {
                ResultText.Text = "Ошибка ввода года";
                return;
            }

            bool isLeap = false;

            if (year % 400 == 0)
            {
                isLeap = true;
            }
            else
            {
                if (year % 100 == 0)
                {
                    isLeap = false;
                }
                else
                {
                    if (year % 4 == 0)
                    {
                        isLeap = true;
                    }
                }
            }

            if (isLeap)
            {
                ResultText.Text = "Год является високосным";
            }
            else
            {
                ResultText.Text = "Год не является високосным";
            }
        }
    }


}
