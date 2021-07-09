using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PV.Views {
    public partial class MarkGamesWindowView : UserControl {
        public MarkGamesWindowView() => InitializeComponent();

        private void InitializeComponent() => AvaloniaXamlLoader.Load(this);
    }
}
