using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PV.Views {
    public partial class MainTableView : UserControl {
        public MainTableView() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
