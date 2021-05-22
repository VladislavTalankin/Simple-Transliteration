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

namespace AAtranslitWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] engletters = "AGB{DE=USNRKVMHOLPCTY/XZJQW`^@agb}de$usnrkvmhofpcty>xzjqwiFI'~\"#".ToCharArray();

        char[] rusletters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯабвгдеёжзийклмнопрстуфхцчшщьыъэюя\"".ToCharArray();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sourcetext = textBox1.Text.ToArray();
            for (int i = 0; i < sourcetext.Length; i++)
            {
                for (int j = 0; j < engletters.Length; j++)
                {
                    if (sourcetext[i] == engletters[j])
                    {
                        sourcetext[i] = rusletters[j];
                        break;
                    }
                }
            }
            textBox2.Text = new string(sourcetext);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var sourcetext = textBox2.Text.ToArray();
            for (int i = 0; i < sourcetext.Length; i++)
            {
                for (int j = 0; j < rusletters.Length; j++)
                {
                    if (sourcetext[i] == rusletters[j])
                    {
                        sourcetext[i] = engletters[j];
                        break;
                    }
                }
            }
            textBox1.Text = new string(sourcetext);
        }
    }
}
