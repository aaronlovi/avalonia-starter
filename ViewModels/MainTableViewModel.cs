using PV.Models;
using ReactiveUI;
using System;
using System.Reactive;

namespace PV.ViewModels {
    public class MainTableViewModel : ViewModelBase {
        public MainWindowViewModel MainWindowViewModel { get; private set; }
        public ReactiveCommand<Unit, Unit> ShowMarkGamesView { get; }

        public MarkGamesFilter Filter { get; set; } = new MarkGamesFilter();

        public MainTableViewModel(MainWindowViewModel mainWindowViewModel_) {
            MainWindowViewModel = mainWindowViewModel_;
            ShowMarkGamesView = ReactiveCommand.Create(DoShowMarkGamesView);
        }

        public void DoShowMarkGamesView() => MainWindowViewModel.DoShowMarkGamesView();
    }
}
