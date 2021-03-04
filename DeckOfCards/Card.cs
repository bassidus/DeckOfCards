using System;

namespace DeckOfCards {

    public class Card : IComparable {
        public Suits Suit { get; }
        public Ranks Rank { get; }

        public Card(Ranks rank, Suits suit) {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString() {
            return $"{Rank} of {Suit}";
        }

        public static bool operator ==(Card a, Card b) => a is null ? b is null : a.Equals(b);

        public static bool operator !=(Card a, Card b) => !(a == b);

        public override bool Equals(object obj) => obj is Card card && Suit == card.Suit && Rank == card.Rank;

        public override int GetHashCode() => HashCode.Combine(Suit, Rank);

        public int CompareTo(object obj) {
            var rank = Rank.CompareTo((obj as Card).Rank);
            var suit = Suit.CompareTo((obj as Card).Suit);

            return rank != 0 ? rank : suit;
        }
    }
}