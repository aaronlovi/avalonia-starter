using PV.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;

namespace PV.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        readonly MainTableViewModel mainTableViewModel;

        ViewModelBase content;
        public ViewModelBase Content {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public ReactiveCommand<Unit, Unit> ShowMarkGamesView { get; }

        public MainWindowViewModel() {
            mainTableViewModel = new MainTableViewModel(this);
            ShowMarkGamesView = ReactiveCommand.Create(DoShowMarkGamesView);

            Content = mainTableViewModel;
        }

        public void DoShowMarkGamesView() {
            var markGamesViewModel = new MarkGamesWindowViewModel();

            markGamesViewModel.OK
                .Take(1)
                .Subscribe(markGamesFilter =>
                {
                    mainTableViewModel.Filter = markGamesFilter;
                    Content = mainTableViewModel;
                });

            markGamesViewModel.Cancel
                .Take(1)
                .Subscribe(_ => Content = mainTableViewModel);

            Content = markGamesViewModel;
        }
    }
}
