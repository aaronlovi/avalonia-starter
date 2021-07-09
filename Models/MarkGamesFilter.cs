using System;
using System.Collections.Generic;
using System.Linq;

namespace PV.Models {
    public class MarkGamesByPlayerParams {
        public bool IsMarkByPlayer { get; set; }
        public bool IsHighlightThisPlayer { get; set; }
        public string SelectedPlayer { get; set; } = string.Empty;
        public Round SawRound { get; set; } = new Round() { LongName = "N/A" };
        public bool IsRaiseAndFoldSameRound { get; set; }
        public bool WasDealtIn { get; set; }
        public bool WentAllIn { get; set; }

        public override string ToString() {
            IList<string> list = new List<string>();

            Func<string, bool, string> appendBoolFn = (label, val) => label + ": " + (val ? "YES" : "NO");

            list.Add(appendBoolFn("MarkByPlayer", IsMarkByPlayer));
            list.Add(appendBoolFn("HighlightThisPlayer", IsHighlightThisPlayer));
            list.Add("SelectedPlayer: " + SelectedPlayer);
            list.Add("SawRound: " + SawRound.LongName);
            list.Add(appendBoolFn("IsRaiseAndFoldSameRound", IsRaiseAndFoldSameRound));
            list.Add(appendBoolFn("WasDealtIn", WasDealtIn));
            list.Add(appendBoolFn("WentAllIn", WentAllIn));

            return string.Join(", ", list);
        }
    }

    public class MarkGameByPotSizeParams {
        public enum ComparatorTypes : int {
            None = 0, LT, LTE, GT, GTE
        }
        public bool IsMarkByPotSize { get; set; }
        public ComparatorTypes Comparator { get; set; }

        public override string ToString() {
            return string.Format("MarkByPotSize: {0}, Comparator: {1}",
                IsMarkByPotSize ? "YES" : "NO",
                Comparator.ToString());
        }
    }

    public class MarkGamesByHemFilterParams {
        public IList<HoldemHolding> Holdings { get; set; } = new List<HoldemHolding>();

        public override string ToString() {
            IEnumerable<string> holdingsList = Holdings.Select(val => val.AsString);
            return string.Join("/", holdingsList);
        }
    }

    public class MarkGamesFilter {
        public MarkGamesByPlayerParams ByPlayerParams { get; set; } = new MarkGamesByPlayerParams();
        public MarkGameByPotSizeParams ByPotSizeParams { get; set; } = new MarkGameByPotSizeParams();
        public MarkGamesByHemFilterParams ByHemFilterParams { get; set; } = new MarkGamesByHemFilterParams();

        public override string ToString() {
            return string.Format("ByPlayer: [{1}]{0}ByPotSize: [{2}]{0}ByHemFilter: [{3}]",
                Environment.NewLine,
                ByPlayerParams.ToString(), ByPotSizeParams.ToString(), ByHemFilterParams.ToString());
        }
    }
}
