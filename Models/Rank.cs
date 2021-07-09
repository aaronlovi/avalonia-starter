using System;
using System.Linq;

namespace PV.Models {
    public struct Rank : IEquatable<Rank> {

        #region ENUMERATED VALUES

        public static readonly Rank TWO = new Rank(2, '2', Flags.IS_VALID);
        public static readonly Rank THREE = new Rank(3, '3', Flags.IS_VALID);
        public static readonly Rank FOUR = new Rank(4, '4', Flags.IS_VALID);
        public static readonly Rank FIVE = new Rank(5, '5', Flags.IS_VALID);
        public static readonly Rank SIX = new Rank(6, '6', Flags.IS_VALID);
        public static readonly Rank SEVEN = new Rank(7, '7', Flags.IS_VALID);
        public static readonly Rank EIGHT = new Rank(8, '8', Flags.IS_VALID);
        public static readonly Rank NINE = new Rank(9, '9', Flags.IS_VALID);
        public static readonly Rank TEN = new Rank(10, 'T', Flags.IS_VALID | Flags.IS_BROADWAY);
        public static readonly Rank JACK = new Rank(11, 'J', Flags.IS_VALID | Flags.IS_BROADWAY);
        public static readonly Rank QUEEN = new Rank(12, 'Q', Flags.IS_VALID | Flags.IS_BROADWAY);
        public static readonly Rank KING = new Rank(13, 'K', Flags.IS_VALID | Flags.IS_BROADWAY);
        public static readonly Rank ACE = new Rank(14, 'A', Flags.IS_VALID | Flags.IS_BROADWAY);
        public static readonly Rank INVALID = default;
        public static readonly Rank UNKNOWN = new Rank(byte.MaxValue, '?', Flags.NONE);
        public static readonly Rank[] ALL_RANKS_ARR = new Rank[] {
            TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE, INVALID, UNKNOWN
        };

        #endregion

        #region CONSTANTS

        [Flags]
        public enum Flags : int {
            NONE = 0,
            IS_VALID = 1,
            IS_BROADWAY = 1 << 1
        }

        #endregion

        #region FIELDS AND PROPERTIES

        public readonly byte asByte;
        public readonly char asChar;
        public readonly int flags;
        public bool IsValid => (flags & (int)Flags.IS_VALID) == (int)Flags.IS_VALID;
        public bool IsBroadway => (flags & (int)Flags.IS_BROADWAY) == (int)Flags.IS_BROADWAY;

        #endregion

        #region CONSTRUCTORS

        public Rank(byte asByte, char asChar, Flags flags) {
            this.asByte = asByte;
            this.asChar = asChar;
            this.flags = (int)flags;
        }

        #endregion

        #region STATIC BUILDERS

        public static Rank FromByte(byte rankByte) => ALL_RANKS_ARR.FirstOrDefault(val => val.asByte == rankByte);
        public static Rank FromChar(char rankChar) => ALL_RANKS_ARR.FirstOrDefault(val => val.asChar == rankChar);

        #endregion

        public override string ToString() => asChar.ToString();
        public override bool Equals(object obj) => obj is Rank rank && Equals(rank);
        public bool Equals(Rank other) => asByte == other.asByte && asChar == other.asChar && flags == other.flags;

        public override int GetHashCode() => HashCode.Combine(asByte, asChar, flags);

        public static bool operator ==(Rank left, Rank right) => left.Equals(right);
        public static bool operator !=(Rank left, Rank right) => !(left == right);
    }
}
