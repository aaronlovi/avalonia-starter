using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using PV.Models;
using PV.ViewModels;
using System;

namespace PV.Views {
    public partial class HemFilterView : UserControl {
        public HemFilterView() => InitializeComponent();

        private void InitializeComponent() => AvaloniaXamlLoader.Load(this);

    }
}
