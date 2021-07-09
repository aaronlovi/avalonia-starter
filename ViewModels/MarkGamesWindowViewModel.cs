using PV.Models;
using ReactiveUI;
using System.Reactive;

namespace PV.ViewModels {
    public class MarkGamesWindowViewModel : ViewModelBase {
        public PlayerPosition[] PlayerPositions { get; } = new PlayerPosition[] {
            new PlayerPosition { ShortName = "BB" },
            new PlayerPosition { ShortName = "SB" },
            new PlayerPosition { ShortName = "BTN" },
            new PlayerPosition { ShortName = "CO" },
            new PlayerPosition { ShortName = "EP" },
            new PlayerPosition { ShortName = "MP" },
            new PlayerPosition { ShortName = "BB_HU" },
            new PlayerPosition { ShortName = "SB_HU" },
            new PlayerPosition { ShortName = "UTG" },
            new PlayerPosition { ShortName = "HJ" }
        };
        public Round[] Rounds { get; } = new Round[] {
            new Round { LongName = "PF/1st round" },
            new Round { LongName = "Flop/2nd round" },
            new Round { LongName = "Turn/3rd round" },
            new Round { LongName = "River/4th round" },
            new Round { LongName = "5th round" }
        };

        public ActionBehavior[] ActionBehaviors { get; } = new ActionBehavior[] {
            new ActionBehavior { ShortName = "VPIP" },
            new ActionBehavior { ShortName = "Raise" },
            new ActionBehavior { ShortName = "Fold" },
            new ActionBehavior { ShortName = "Check" },
            new ActionBehavior { ShortName = "Call" },
            new ActionBehavior { ShortName = "Bet" },
            new ActionBehavior { ShortName = "C/R" },
            new ActionBehavior { ShortName = "3-bet" },
            new ActionBehavior { ShortName = "4+bet" },
            new ActionBehavior { ShortName = "C-Bet" },
            new ActionBehavior { ShortName = "R+F" }
        };
        public string[] SamplePlayers { get; } = new string[] {
            "Player 1", "Player 2", "Player 3", "Player 4"
        };

        public string[] NumDealtIn { get; } = new string[] {
            "H/U", "3-4", "5-6", "7-10"
        };

        public ReactiveCommand<Unit, Unit> Cancel { get; }
        public ReactiveCommand<Unit, MarkGamesFilter> OK { get; }

        public HemFilterViewModel HemFilterViewModel { get; } = new HemFilterViewModel();

        public MarkGamesFilter markGamesFilter = new MarkGamesFilter();

        public MarkGamesFilter Filter {
            get => markGamesFilter;
            private set => this.RaiseAndSetIfChanged(ref markGamesFilter, value);
        }

        public MarkGamesWindowViewModel() {
            Cancel = ReactiveCommand.Create(() => { });
            OK = ReactiveCommand.Create(() => {
                Filter.ByHemFilterParams.Holdings.Clear();
                for (int i = 0; i < HemFilterViewModel.Holdings.Count; i++) {
                    var item = HemFilterViewModel.Holdings[i];
                    var isSelected = item.Item1;
                    if (isSelected) {
                        var holding = item.Item2;
                        Filter.ByHemFilterParams.Holdings.Add(holding);
                    }
                }

                return Filter;
            });
        }
    }
}
