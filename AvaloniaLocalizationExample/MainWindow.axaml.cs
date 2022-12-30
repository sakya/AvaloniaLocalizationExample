using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaLocalizationExample
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnLanguageChanged(object sender, SelectionChangedEventArgs args)
        {
            var cb = sender as ComboBox;
            var language = cb.SelectedIndex == 0 ? "en-US" : "it-IT";
            Localizer.Localizer.Instance.LoadLanguage(language);
        } // OnLanguageChanged

    }
}
