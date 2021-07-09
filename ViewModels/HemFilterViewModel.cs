using PV.Models;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive;

namespace PV.ViewModels {
    public class HemFilterViewModel {
        public ObservableCollection<Tuple<bool, HoldemHolding>> Holdings { get; } = new ObservableCollection<Tuple<bool, HoldemHolding>>();
        public ReactiveCommand<string, Unit> ToggleState { get; }
        public ReactiveCommand<string, Unit> SuitedClicked { get; }
        public ReactiveCommand<string, Unit> OffsuitClicked { get; }
        public ReactiveCommand<string, Unit> PocketPairsClicked { get; }
        public ReactiveCommand<string, Unit> SuitedConnectorsClicked { get; }
        public ReactiveCommand<string, Unit> UnsuitedConnectorsClicked { get; }
        public ReactiveCommand<string, Unit> SuitedOneGappersClicked { get; }
        public ReactiveCommand<string, Unit> UnsuitedOneGappersClicked { get; }
        public ReactiveCommand<string, Unit> SuitedTwoGappersClicked { get; }
        public ReactiveCommand<string, Unit> OffsuitTwoGappersClicked { get; }
        public ReactiveCommand<string, Unit> SuitedThreeGappersClicked { get; }
        public ReactiveCommand<string, Unit> OffsuitThreeGappersClicked { get; }
        public ReactiveCommand<string, Unit> SuitedBroadwaysClicked { get; }
        public ReactiveCommand<string, Unit> UnsuitedBroadwaysClicked { get; }
        public ReactiveCommand<string, Unit> AllClicked { get; }


        public HemFilterViewModel() {
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.AA));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.AKs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.AQs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.AJs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.ATs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A9s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A8s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A7s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A6s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A5s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A4s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A3s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A2s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.AKo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.KK));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.KQs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.KJs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.KTs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K9s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K8s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K7s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K6s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K5s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K4s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K3s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K2s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.AQo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.KQo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.QQ));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.QJs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.QTs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q9s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q8s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q7s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q6s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q5s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q4s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q3s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q2s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.AJo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.KJo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.QJo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.JJ));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.JTs));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J9s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J8s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J7s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J6s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J5s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J4s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J3s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J2s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.ATo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.KTo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.QTo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.JTo));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.TT));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T9s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T8s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T7s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T6s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T5s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T4s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T3s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T2s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A9o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K9o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q9o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J9o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T9o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._99));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._98s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._97s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._96s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._95s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._94s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._93s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._92s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A8o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K8o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q8o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J8o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T8o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._98o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._88));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._87s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._86s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._85s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._84s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._83s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._82s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A7o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K7o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q7o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J7o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T7o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._97o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._87o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._77));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._76s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._75s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._74s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._73s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._72s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A6o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K6o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q6o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J6o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T6o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._96o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._86o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._76o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._66));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._65s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._64s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._63s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._62s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A5o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K5o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q5o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J5o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T5o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._95o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._85o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._75o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._65o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._55));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._54s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._53s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._52s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A4o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K4o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q4o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J4o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T4o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._94o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._84o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._74o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._64o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._54o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._44));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._43s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._42s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A3o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K3o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q3o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J3o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T3o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._93o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._83o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._73o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._63o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._53o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._43o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._33));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._32s));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.A2o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.K2o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.Q2o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.J2o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding.T2o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._92o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._82o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._72o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._62o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._52o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._42o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._32o));
            Holdings.Add(new Tuple<bool, HoldemHolding>(false, HoldemHolding._22));

            ToggleState = ReactiveCommand.Create<string>(DoToggleState);
            SuitedClicked = ReactiveCommand.Create<string>(DoSuitedClicked);
            OffsuitClicked = ReactiveCommand.Create<string>(DoOffsuitClicked);
            PocketPairsClicked = ReactiveCommand.Create<string>(DoPocketPairsClicked);
            SuitedConnectorsClicked = ReactiveCommand.Create<string>(DoSuitedConnectorsClicked);
            UnsuitedConnectorsClicked = ReactiveCommand.Create<string>(DoUnsuitedConnectorsClicked);
            SuitedOneGappersClicked = ReactiveCommand.Create<string>(DoSuitedOneGappersClicked);
            UnsuitedOneGappersClicked = ReactiveCommand.Create<string>(DoUnsuitedOneGappersClicked);
            SuitedTwoGappersClicked = ReactiveCommand.Create<string>(DoSuitedTwoGappersClicked);
            OffsuitTwoGappersClicked = ReactiveCommand.Create<string>(DoOffsuitTwoGappersClicked);
            SuitedThreeGappersClicked = ReactiveCommand.Create<string>(DoSuitedThreeGappersClicked);
            OffsuitThreeGappersClicked = ReactiveCommand.Create<string>(DoOffsuitThreeGappersClicked);
            SuitedBroadwaysClicked = ReactiveCommand.Create<string>(DoSuitedBroadwaysClicked);
            UnsuitedBroadwaysClicked = ReactiveCommand.Create<string>(DoUnsuitedBroadwaysClicked);
            AllClicked = ReactiveCommand.Create<string>(DoAllClicked);
        }

        public void DoToggleState(string holdingName) {
            for (int i = 0; i < Holdings.Count; i++) {
                var curItem = Holdings[i];
                var isSelected = curItem.Item1;
                var curHolding = curItem.Item2;
                if (curHolding.AsString.Equals(holdingName)) {
                    Holdings[i] = new Tuple<bool, HoldemHolding>(!isSelected, curHolding);
                }
            }
        }

        private void DoSuitedClicked(string val) => ToggleCellSelection(val == "1", holding => holding.isSuited);
        private void DoOffsuitClicked(string val) => ToggleCellSelection(val == "1", holding => holding.IsStrictOffsuit);
        private void DoPocketPairsClicked(string val) => ToggleCellSelection(val == "1", holding => holding.IsPaired);
        private void DoSuitedConnectorsClicked(string val) => ToggleCellSelection(val == "1", holding => holding.IsStrictSuitedConnector);
        private void DoUnsuitedConnectorsClicked(string val) => ToggleCellSelection(val == "1", holding => holding.IsStrictUnsuitedConnector);
        private void DoSuitedOneGappersClicked(string val) => ToggleCellSelection(val == "1", holding => holding.IsStrictSuitedOneGapper);
        private void DoUnsuitedOneGappersClicked(string val)  => ToggleCellSelection(val == "1", holding => holding.IsStrictUnsuitedOneGapper);
        private void DoSuitedTwoGappersClicked(string val)  => ToggleCellSelection(val == "1", holding => holding.IsStrictSuitedTwoGapper);
        private void DoOffsuitTwoGappersClicked(string val)  => ToggleCellSelection(val == "1", holding => holding.IsStrictUnsuitedTwoGapper);
        private void DoSuitedThreeGappersClicked(string val)  => ToggleCellSelection(val == "1", holding => holding.IsStrictSuitedThreeGapper);
        private void DoOffsuitThreeGappersClicked(string val)  => ToggleCellSelection(val == "1", holding => holding.IsStrictUnsuitedThreeGapper);
        private void DoSuitedBroadwaysClicked(string val)  => ToggleCellSelection(val == "1", holding => holding.IsSuitedBroadway);
        private void DoUnsuitedBroadwaysClicked(string val)  => ToggleCellSelection(val == "1", holding => holding.IsUnsuitedBroadway);
        private void DoAllClicked(string val)  => ToggleCellSelection(val == "1", holding => true);

        private void ToggleCellSelection(bool newVal, Func<HoldemHolding, bool> conditionFn) {
            for (int i = 0; i < Holdings.Count; i++) {
                var curItem = Holdings[i];
                var curHolding = curItem.Item2;
                if (conditionFn(curHolding)) {
                    Holdings[i] = new Tuple<bool, HoldemHolding>(newVal, curHolding);
                }
            }
        }
    }
}
