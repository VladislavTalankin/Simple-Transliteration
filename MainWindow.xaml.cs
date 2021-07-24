using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AAtranslitWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> rus = new List<string>();
        List<string> eql = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getDb()
        {
            SymbolContext db = new SymbolContext();
            var symbs = db.Symbols.OrderBy(f => f.Equalsymbol.Length);
            foreach (Symbol symb in symbs)
            {
                rus.Add(symb.RUsymbol);
                eql.Add(symb.Equalsymbol);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sourcetext = textBox1.Text;
            for(int i = 0; i < rus.Count(); i++)
            {
                if (eql[i] == null || rus[i] == null) continue;
                else sourcetext = sourcetext.Replace(eql[i], rus[i]);
            }
            textBox2.Text = sourcetext;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var sourcetext = textBox2.Text;
            for (int i = 0; i < rus.Count(); i++)
            {
                if (eql[i] == null || rus[i] == null) continue;
                else sourcetext = sourcetext.Replace(rus[i], eql[i]);
            }
            textBox1.Text = sourcetext;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            getDb();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Settings window = new Settings();
            window.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            rus.Clear();
            eql.Clear();
            getDb();
        }
    }
}
