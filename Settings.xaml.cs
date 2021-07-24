using System.Linq;
using System.Windows;
using System.Data.Entity;

namespace AAtranslitWPF
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        SymbolContext db;
        public Settings()
        {
            InitializeComponent();
            db = new SymbolContext();
            db.Symbols.Load();
            SettingsDataGrid.DataContext = db;
            SettingsDataGrid.ItemsSource = db.Symbols.Local.ToBindingList();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Symbols.OrderBy(x => x.RUsymbol);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
