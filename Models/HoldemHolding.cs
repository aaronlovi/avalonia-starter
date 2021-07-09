using System;

namespace PV.Models {
    /// <summary>
    /// Holdings are like A2s, KK, KQo, etc.
    /// </summary>
    public struct HoldemHolding : IEquatable<HoldemHolding> {
        #region CONSTANTS

        private const int ConnectedRanks = 1;
        private const int OneRankGap = 2;
        private const int TwoRankGap = 3;
        private const int ThreeRankGap = 4;

        #endregion

        #region ENUMERATED VALUES

        public static readonly HoldemHolding AA = new HoldemHolding(false, Rank.ACE, Rank.ACE);
        public static readonly HoldemHolding AKs = new HoldemHolding(true, Rank.ACE, Rank.KING);
        public static readonly HoldemHolding AQs = new HoldemHolding(true, Rank.ACE, Rank.QUEEN);
        public static readonly HoldemHolding AJs = new HoldemHolding(true, Rank.ACE, Rank.JACK);
        public static readonly HoldemHolding ATs = new HoldemHolding(true, Rank.ACE, Rank.TEN);
        public static readonly HoldemHolding A9s = new HoldemHolding(true, Rank.ACE, Rank.NINE);
        public static readonly HoldemHolding A8s = new HoldemHolding(true, Rank.ACE, Rank.EIGHT);
        public static readonly HoldemHolding A7s = new HoldemHolding(true, Rank.ACE, Rank.SEVEN);
        public static readonly HoldemHolding A6s = new HoldemHolding(true, Rank.ACE, Rank.SIX);
        public static readonly HoldemHolding A5s = new HoldemHolding(true, Rank.ACE, Rank.FIVE);
        public static readonly HoldemHolding A4s = new HoldemHolding(true, Rank.ACE, Rank.FOUR);
        public static readonly HoldemHolding A3s = new HoldemHolding(true, Rank.ACE, Rank.THREE);
        public static readonly HoldemHolding A2s = new HoldemHolding(true, Rank.ACE, Rank.TWO);

        public static readonly HoldemHolding AKo = new HoldemHolding(false, Rank.ACE, Rank.KING);
        public static readonly HoldemHolding KK = new HoldemHolding(false, Rank.KING, Rank.KING);
        public static readonly HoldemHolding KQs = new HoldemHolding(true, Rank.KING, Rank.QUEEN);
        public static readonly HoldemHolding KJs = new HoldemHolding(true, Rank.KING, Rank.JACK);
        public static readonly HoldemHolding KTs = new HoldemHolding(true, Rank.KING, Rank.TEN);
        public static readonly HoldemHolding K9s = new HoldemHolding(true, Rank.KING, Rank.NINE);
        public static readonly HoldemHolding K8s = new HoldemHolding(true, Rank.KING, Rank.EIGHT);
        public static readonly HoldemHolding K7s = new HoldemHolding(true, Rank.KING, Rank.SEVEN);
        public static readonly HoldemHolding K6s = new HoldemHolding(true, Rank.KING, Rank.SIX);
        public static readonly HoldemHolding K5s = new HoldemHolding(true, Rank.KING, Rank.FIVE);
        public static readonly HoldemHolding K4s = new HoldemHolding(true, Rank.KING, Rank.FOUR);
        public static readonly HoldemHolding K3s = new HoldemHolding(true, Rank.KING, Rank.THREE);
        public static readonly HoldemHolding K2s = new HoldemHolding(true, Rank.KING, Rank.TWO);

        public static readonly HoldemHolding AQo = new HoldemHolding(false, Rank.ACE, Rank.QUEEN);
        public static readonly HoldemHolding KQo = new HoldemHolding(false, Rank.KING, Rank.QUEEN);
        public static readonly HoldemHolding QQ = new HoldemHolding(false, Rank.QUEEN, Rank.QUEEN);
        public static readonly HoldemHolding QJs = new HoldemHolding(true, Rank.QUEEN, Rank.JACK);
        public static readonly HoldemHolding QTs = new HoldemHolding(true, Rank.QUEEN, Rank.TEN);
        public static readonly HoldemHolding Q9s = new HoldemHolding(true, Rank.QUEEN, Rank.NINE);
        public static readonly HoldemHolding Q8s = new HoldemHolding(true, Rank.QUEEN, Rank.EIGHT);
        public static readonly HoldemHolding Q7s = new HoldemHolding(true, Rank.QUEEN, Rank.SEVEN);
        public static readonly HoldemHolding Q6s = new HoldemHolding(true, Rank.QUEEN, Rank.SIX);
        public static readonly HoldemHolding Q5s = new HoldemHolding(true, Rank.QUEEN, Rank.FIVE);
        public static readonly HoldemHolding Q4s = new HoldemHolding(true, Rank.QUEEN, Rank.FOUR);
        public static readonly HoldemHolding Q3s = new HoldemHolding(true, Rank.QUEEN, Rank.THREE);
        public static readonly HoldemHolding Q2s = new HoldemHolding(true, Rank.QUEEN, Rank.TWO);

        public static readonly HoldemHolding AJo = new HoldemHolding(false, Rank.ACE, Rank.JACK);
        public static readonly HoldemHolding KJo = new HoldemHolding(false, Rank.KING, Rank.JACK);
        public static readonly HoldemHolding QJo = new HoldemHolding(false, Rank.QUEEN, Rank.JACK);
        public static readonly HoldemHolding JJ = new HoldemHolding(false, Rank.JACK, Rank.JACK);
        public static readonly HoldemHolding JTs = new HoldemHolding(true, Rank.JACK, Rank.TEN);
        public static readonly HoldemHolding J9s = new HoldemHolding(true, Rank.JACK, Rank.NINE);
        public static readonly HoldemHolding J8s = new HoldemHolding(true, Rank.JACK, Rank.EIGHT);
        public static readonly HoldemHolding J7s = new HoldemHolding(true, Rank.JACK, Rank.SEVEN);
        public static readonly HoldemHolding J6s = new HoldemHolding(true, Rank.JACK, Rank.SIX);
        public static readonly HoldemHolding J5s = new HoldemHolding(true, Rank.JACK, Rank.FIVE);
        public static readonly HoldemHolding J4s = new HoldemHolding(true, Rank.JACK, Rank.FOUR);
        public static readonly HoldemHolding J3s = new HoldemHolding(true, Rank.JACK, Rank.THREE);
        public static readonly HoldemHolding J2s = new HoldemHolding(true, Rank.JACK, Rank.TWO);

        public static readonly HoldemHolding ATo = new HoldemHolding(false, Rank.ACE, Rank.TEN);
        public static readonly HoldemHolding KTo = new HoldemHolding(false, Rank.KING, Rank.TEN);
        public static readonly HoldemHolding QTo = new HoldemHolding(false, Rank.QUEEN, Rank.TEN);
        public static readonly HoldemHolding JTo = new HoldemHolding(false, Rank.JACK, Rank.TEN);
        public static readonly HoldemHolding TT = new HoldemHolding(false, Rank.TEN, Rank.TEN);
        public static readonly HoldemHolding T9s = new HoldemHolding(true, Rank.TEN, Rank.NINE);
        public static readonly HoldemHolding T8s = new HoldemHolding(true, Rank.TEN, Rank.EIGHT);
        public static readonly HoldemHolding T7s = new HoldemHolding(true, Rank.TEN, Rank.SEVEN);
        public static readonly HoldemHolding T6s = new HoldemHolding(true, Rank.TEN, Rank.SIX);
        public static readonly HoldemHolding T5s = new HoldemHolding(true, Rank.TEN, Rank.FIVE);
        public static readonly HoldemHolding T4s = new HoldemHolding(true, Rank.TEN, Rank.FOUR);
        public static readonly HoldemHolding T3s = new HoldemHolding(true, Rank.TEN, Rank.THREE);
        public static readonly HoldemHolding T2s = new HoldemHolding(true, Rank.TEN, Rank.TWO);

        public static readonly HoldemHolding A9o = new HoldemHolding(false, Rank.ACE, Rank.NINE);
        public static readonly HoldemHolding K9o = new HoldemHolding(false, Rank.KING, Rank.NINE);
        public static readonly HoldemHolding Q9o = new HoldemHolding(false, Rank.QUEEN, Rank.NINE);
        public static readonly HoldemHolding J9o = new HoldemHolding(false, Rank.JACK, Rank.NINE);
        public static readonly HoldemHolding T9o = new HoldemHolding(false, Rank.TEN, Rank.NINE);
        public static readonly HoldemHolding _99 = new HoldemHolding(false, Rank.NINE, Rank.NINE);
        public static readonly HoldemHolding _98s = new HoldemHolding(true, Rank.NINE, Rank.EIGHT);
        public static readonly HoldemHolding _97s = new HoldemHolding(true, Rank.NINE, Rank.SEVEN);
        public static readonly HoldemHolding _96s = new HoldemHolding(true, Rank.NINE, Rank.SIX);
        public static readonly HoldemHolding _95s = new HoldemHolding(true, Rank.NINE, Rank.FIVE);
        public static readonly HoldemHolding _94s = new HoldemHolding(true, Rank.NINE, Rank.FOUR);
        public static readonly HoldemHolding _93s = new HoldemHolding(true, Rank.NINE, Rank.THREE);
        public static readonly HoldemHolding _92s = new HoldemHolding(true, Rank.NINE, Rank.TWO);

        public static readonly HoldemHolding A8o = new HoldemHolding(false, Rank.ACE, Rank.EIGHT);
        public static readonly HoldemHolding K8o = new HoldemHolding(false, Rank.KING, Rank.EIGHT);
        public static readonly HoldemHolding Q8o = new HoldemHolding(false, Rank.QUEEN, Rank.EIGHT);
        public static readonly HoldemHolding J8o = new HoldemHolding(false, Rank.JACK, Rank.EIGHT);
        public static readonly HoldemHolding T8o = new HoldemHolding(false, Rank.TEN, Rank.EIGHT);
        public static readonly HoldemHolding _98o = new HoldemHolding(false, Rank.NINE, Rank.EIGHT);
        public static readonly HoldemHolding _88 = new HoldemHolding(false, Rank.EIGHT, Rank.EIGHT);
        public static readonly HoldemHolding _87s = new HoldemHolding(true, Rank.EIGHT, Rank.SEVEN);
        public static readonly HoldemHolding _86s = new HoldemHolding(true, Rank.EIGHT, Rank.SIX);
        public static readonly HoldemHolding _85s = new HoldemHolding(true, Rank.EIGHT, Rank.FIVE);
        public static readonly HoldemHolding _84s = new HoldemHolding(true, Rank.EIGHT, Rank.FOUR);
        public static readonly HoldemHolding _83s = new HoldemHolding(true, Rank.EIGHT, Rank.THREE);
        public static readonly HoldemHolding _82s = new HoldemHolding(true, Rank.EIGHT, Rank.TWO);

        public static readonly HoldemHolding A7o = new HoldemHolding(false, Rank.ACE, Rank.SEVEN);
        public static readonly HoldemHolding K7o = new HoldemHolding(false, Rank.KING, Rank.SEVEN);
        public static readonly HoldemHolding Q7o = new HoldemHolding(false, Rank.QUEEN, Rank.SEVEN);
        public static readonly HoldemHolding J7o = new HoldemHolding(false, Rank.JACK, Rank.SEVEN);
        public static readonly HoldemHolding T7o = new HoldemHolding(false, Rank.TEN, Rank.SEVEN);
        public static readonly HoldemHolding _97o = new HoldemHolding(false, Rank.NINE, Rank.SEVEN);
        public static readonly HoldemHolding _87o = new HoldemHolding(false, Rank.EIGHT, Rank.SEVEN);
        public static readonly HoldemHolding _77 = new HoldemHolding(false, Rank.SEVEN, Rank.SEVEN);
        public static readonly HoldemHolding _76s = new HoldemHolding(true, Rank.SEVEN, Rank.SIX);
        public static readonly HoldemHolding _75s = new HoldemHolding(true, Rank.SEVEN, Rank.FIVE);
        public static readonly HoldemHolding _74s = new HoldemHolding(true, Rank.SEVEN, Rank.FOUR);
        public static readonly HoldemHolding _73s = new HoldemHolding(true, Rank.SEVEN, Rank.THREE);
        public static readonly HoldemHolding _72s = new HoldemHolding(true, Rank.SEVEN, Rank.TWO);

        public static readonly HoldemHolding A6o = new HoldemHolding(false, Rank.ACE, Rank.SIX);
        public static readonly HoldemHolding K6o = new HoldemHolding(false, Rank.KING, Rank.SIX);
        public static readonly HoldemHolding Q6o = new HoldemHolding(false, Rank.QUEEN, Rank.SIX);
        public static readonly HoldemHolding J6o = new HoldemHolding(false, Rank.JACK, Rank.SIX);
        public static readonly HoldemHolding T6o = new HoldemHolding(false, Rank.TEN, Rank.SIX);
        public static readonly HoldemHolding _96o = new HoldemHolding(false, Rank.NINE, Rank.SIX);
        public static readonly HoldemHolding _86o = new HoldemHolding(false, Rank.EIGHT, Rank.SIX);
        public static readonly HoldemHolding _76o = new HoldemHolding(false, Rank.SEVEN, Rank.SIX);
        public static readonly HoldemHolding _66 = new HoldemHolding(false, Rank.SIX, Rank.SIX);
        public static readonly HoldemHolding _65s = new HoldemHolding(true, Rank.SIX, Rank.FIVE);
        public static readonly HoldemHolding _64s = new HoldemHolding(true, Rank.SIX, Rank.FOUR);
        public static readonly HoldemHolding _63s = new HoldemHolding(true, Rank.SIX, Rank.THREE);
        public static readonly HoldemHolding _62s = new HoldemHolding(true, Rank.SIX, Rank.TWO);

        public static readonly HoldemHolding A5o = new HoldemHolding(false, Rank.ACE, Rank.FIVE);
        public static readonly HoldemHolding K5o = new HoldemHolding(false, Rank.KING, Rank.FIVE);
        public static readonly HoldemHolding Q5o = new HoldemHolding(false, Rank.QUEEN, Rank.FIVE);
        public static readonly HoldemHolding J5o = new HoldemHolding(false, Rank.JACK, Rank.FIVE);
        public static readonly HoldemHolding T5o = new HoldemHolding(false, Rank.TEN, Rank.FIVE);
        public static readonly HoldemHolding _95o = new HoldemHolding(false, Rank.NINE, Rank.FIVE);
        public static readonly HoldemHolding _85o = new HoldemHolding(false, Rank.EIGHT, Rank.FIVE);
        public static readonly HoldemHolding _75o = new HoldemHolding(false, Rank.SEVEN, Rank.FIVE);
        public static readonly HoldemHolding _65o = new HoldemHolding(false, Rank.SIX, Rank.FIVE);
        public static readonly HoldemHolding _55 = new HoldemHolding(false, Rank.FIVE, Rank.FIVE);
        public static readonly HoldemHolding _54s = new HoldemHolding(true, Rank.FIVE, Rank.FOUR);
        public static readonly HoldemHolding _53s = new HoldemHolding(true, Rank.FIVE, Rank.THREE);
        public static readonly HoldemHolding _52s = new HoldemHolding(true, Rank.FIVE, Rank.TWO);

        public static readonly HoldemHolding A4o = new HoldemHolding(false, Rank.ACE, Rank.FOUR);
        public static readonly HoldemHolding K4o = new HoldemHolding(false, Rank.KING, Rank.FOUR);
        public static readonly HoldemHolding Q4o = new HoldemHolding(false, Rank.QUEEN, Rank.FOUR);
        public static readonly HoldemHolding J4o = new HoldemHolding(false, Rank.JACK, Rank.FOUR);
        public static readonly HoldemHolding T4o = new HoldemHolding(false, Rank.TEN, Rank.FOUR);
        public static readonly HoldemHolding _94o = new HoldemHolding(false, Rank.NINE, Rank.FOUR);
        public static readonly HoldemHolding _84o = new HoldemHolding(false, Rank.EIGHT, Rank.FOUR);
        public static readonly HoldemHolding _74o = new HoldemHolding(false, Rank.SEVEN, Rank.FOUR);
        public static readonly HoldemHolding _64o = new HoldemHolding(false, Rank.SIX, Rank.FOUR);
        public static readonly HoldemHolding _54o = new HoldemHolding(false, Rank.FIVE, Rank.FOUR);
        public static readonly HoldemHolding _44 = new HoldemHolding(false, Rank.FOUR, Rank.FOUR);
        public static readonly HoldemHolding _43s = new HoldemHolding(true, Rank.FOUR, Rank.THREE);
        public static readonly HoldemHolding _42s = new HoldemHolding(true, Rank.FOUR, Rank.TWO);

        public static readonly HoldemHolding A3o = new HoldemHolding(false, Rank.ACE, Rank.THREE);
        public static readonly HoldemHolding K3o = new HoldemHolding(false, Rank.KING, Rank.THREE);
        public static readonly HoldemHolding Q3o = new HoldemHolding(false, Rank.QUEEN, Rank.THREE);
        public static readonly HoldemHolding J3o = new HoldemHolding(false, Rank.JACK, Rank.THREE);
        public static readonly HoldemHolding T3o = new HoldemHolding(false, Rank.TEN, Rank.THREE);
        public static readonly HoldemHolding _93o = new HoldemHolding(false, Rank.NINE, Rank.THREE);
        public static readonly HoldemHolding _83o = new HoldemHolding(false, Rank.EIGHT, Rank.THREE);
        public static readonly HoldemHolding _73o = new HoldemHolding(false, Rank.SEVEN, Rank.THREE);
        public static readonly HoldemHolding _63o = new HoldemHolding(false, Rank.SIX, Rank.THREE);
        public static readonly HoldemHolding _53o = new HoldemHolding(false, Rank.FIVE, Rank.THREE);
        public static readonly HoldemHolding _43o = new HoldemHolding(false, Rank.FOUR, Rank.THREE);
        public static readonly HoldemHolding _33 = new HoldemHolding(false, Rank.THREE, Rank.THREE);
        public static readonly HoldemHolding _32s = new HoldemHolding(true, Rank.THREE, Rank.TWO);

        public static readonly HoldemHolding A2o = new HoldemHolding(false, Rank.ACE, Rank.TWO);
        public static readonly HoldemHolding K2o = new HoldemHolding(false, Rank.KING, Rank.TWO);
        public static readonly HoldemHolding Q2o = new HoldemHolding(false, Rank.QUEEN, Rank.TWO);
        public static readonly HoldemHolding J2o = new HoldemHolding(false, Rank.JACK, Rank.TWO);
        public static readonly HoldemHolding T2o = new HoldemHolding(false, Rank.TEN, Rank.TWO);
        public static readonly HoldemHolding _92o = new HoldemHolding(false, Rank.NINE, Rank.TWO);
        public static readonly HoldemHolding _82o = new HoldemHolding(false, Rank.EIGHT, Rank.TWO);
        public static readonly HoldemHolding _72o = new HoldemHolding(false, Rank.SEVEN, Rank.TWO);
        public static readonly HoldemHolding _62o = new HoldemHolding(false, Rank.SIX, Rank.TWO);
        public static readonly HoldemHolding _52o = new HoldemHolding(false, Rank.FIVE, Rank.TWO);
        public static readonly HoldemHolding _42o = new HoldemHolding(false, Rank.FOUR, Rank.TWO);
        public static readonly HoldemHolding _32o = new HoldemHolding(false, Rank.THREE, Rank.TWO);
        public static readonly HoldemHolding _22 = new HoldemHolding(false, Rank.TWO, Rank.TWO);

        #endregion

        #region PROPERTIES
        public readonly bool isSuited;
        public readonly Rank topRank;
        public readonly Rank bottomRank;
        public bool IsConnected {
            get {
                return (topRank.asByte - bottomRank.asByte == ConnectedRanks)
                    || (topRank == Rank.ACE && bottomRank == Rank.TWO);
            }
        }
        public bool IsOneGapper {
            get {
                return (topRank.asByte - bottomRank.asByte == OneRankGap)
                    || (topRank == Rank.ACE && bottomRank == Rank.THREE);
            }
        }
        public bool IsTwoGapper {
            get {
                return (topRank.asByte - bottomRank.asByte == TwoRankGap)
                    || (topRank == Rank.ACE && bottomRank == Rank.FOUR);
            }
        }
        public bool IsThreeGapper {
            get {
                return (topRank.asByte - bottomRank.asByte == ThreeRankGap)
                    || (topRank == Rank.ACE && bottomRank == Rank.FIVE);
            }
        }
        public bool IsBroadway => (topRank != bottomRank) && topRank.IsBroadway && bottomRank.IsBroadway;
        public bool IsOffsuit => !isSuited;
        public bool IsPaired => topRank == bottomRank;
        public bool IsSuitedConnector => isSuited && IsConnected;
        public bool IsUnsuitedConnector => IsOffsuit && IsConnected;
        public bool IsSuitedOneGapper => isSuited && IsOneGapper;
        public bool IsUnsuitedOneGapper => IsOffsuit && IsOneGapper;
        public bool IsSuitedTwoGapper => isSuited && IsTwoGapper;
        public bool IsUnsuitedTwoGapper => IsOffsuit && IsTwoGapper;
        public bool IsSuitedThreeGapper => isSuited && IsThreeGapper;
        public bool IsUnsuitedThreeGapper => IsOffsuit && IsThreeGapper;
        public bool IsSuitedBroadway => isSuited && IsBroadway;
        public bool IsUnsuitedBroadway => IsOffsuit && IsBroadway;
        public bool IsStrictOffsuit => IsOffsuit && !IsPaired;
        public bool IsStrictSuitedConnector => IsSuitedConnector && this != A2s;
        public bool IsStrictUnsuitedConnector => IsUnsuitedConnector && this != A2o;
        public bool IsStrictSuitedOneGapper => IsSuitedOneGapper && this != A3s;
        public bool IsStrictUnsuitedOneGapper => IsUnsuitedOneGapper && this != A3o;
        public bool IsStrictSuitedTwoGapper => IsSuitedTwoGapper && this != A4s;
        public bool IsStrictUnsuitedTwoGapper => IsUnsuitedTwoGapper && this != A4o;
        public bool IsStrictSuitedThreeGapper => IsSuitedThreeGapper && this != A5s;
        public bool IsStrictUnsuitedThreeGapper => IsUnsuitedThreeGapper && this != A5o;

        public string AsString => ToString();

        #endregion

        #region CONSTRUCTORS

        public HoldemHolding(bool isSuited, Rank topRank, Rank bottomRank) {
            this.isSuited = isSuited;

            if (topRank.asByte >= bottomRank.asByte) {
                this.topRank = topRank;
                this.bottomRank = bottomRank;
            }
            else {
                this.topRank = bottomRank;
                this.bottomRank = topRank;
            }
        }

        #endregion

        #region EQUALS, GETHASHCODE, OPERATORS, AND OVERRIDES

        public override bool Equals(object obj) => obj is HoldemHolding holding && Equals(holding);
        public bool Equals(HoldemHolding other) => isSuited == other.isSuited && topRank.Equals(other.topRank) && bottomRank.Equals(other.bottomRank);

        public override int GetHashCode() => HashCode.Combine(isSuited, topRank, bottomRank);

        public static bool operator ==(HoldemHolding left, HoldemHolding right) => left.Equals(right);
        public static bool operator !=(HoldemHolding left, HoldemHolding right) => !(left == right);

        public override string ToString() {
            return topRank == bottomRank
                ? topRank.ToString() + bottomRank.ToString()
                : topRank.ToString() + bottomRank.ToString() + (IsOffsuit ? 'o' : 's');
        }

        #endregion
    }
}
