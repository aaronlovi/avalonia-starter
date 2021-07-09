using System;
using System.Linq;

namespace PV.Models {
    public struct Suit : IEquatable<Suit> {
        public static readonly Suit CLUBS = new Suit(true, 1, 'c');
        public static readonly Suit DIAMONDS = new Suit(true, 2, 'd');
        public static readonly Suit HEARTS = new Suit(true, 3, 'h');
        public static readonly Suit SPADES = new Suit(true, 4, 's');
        public static readonly Suit INVALID = default;
        public static readonly Suit UNKNOWN = new Suit(false, byte.MaxValue, '?');
        public static readonly Suit[] VALID_SUITS_ARR = new Suit[] {
            CLUBS, DIAMONDS, HEARTS, SPADES
        };
        public static readonly Suit[] ALL_SUITS_ARR = new Suit[] {
            CLUBS, DIAMONDS, HEARTS, SPADES, INVALID, UNKNOWN
        };

        public readonly bool isValid;
        public readonly byte asByte;
        public readonly char asChar;
        public Suit(bool isValid, byte asByte, char asChar) {
            this.isValid = isValid;
            this.asByte = asByte;
            this.asChar = asChar;
        }

        public static Suit FromChar(char suitChar) => ALL_SUITS_ARR.FirstOrDefault(val => val.asChar == suitChar);

        public static Suit FromByte(byte suitByte) => ALL_SUITS_ARR.FirstOrDefault(val => val.asByte == suitByte);

        public override string ToString() => asChar.ToString();
        public override bool Equals(object obj) => obj is Suit suit && Equals(suit);
        public bool Equals(Suit other) => isValid == other.isValid && asByte == other.asByte && asChar == other.asChar;

        public override int GetHashCode() => HashCode.Combine(isValid, asByte, asChar);

        public static bool operator ==(Suit left, Suit right) => left.Equals(right);
        public static bool operator !=(Suit left, Suit right) => !(left == right);
    }
}
