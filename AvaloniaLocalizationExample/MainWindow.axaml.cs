using Avalonia.Controls;

namespace AvaloniaLocalizationExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLanguageChanged(object sender, SelectionChangedEventArgs args)
        {
            var cb = sender as ComboBox;
            var language = cb.SelectedIndex == 0 ? "en-US" : "it-IT";
            Localizer.Localizer.Instance.LoadLanguage(language);
        }

    }
}
