using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards {

    public enum Ranks { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

    public enum Suits { Hearts, Clubs, Diamonds, Spades }

    public class DeckOfCards {
        private Queue<Card> deckOfCards;
        public int Count => deckOfCards.Count;
        public Card this[int key] => deckOfCards.ToList()[key - 1];

        public DeckOfCards() {
            Restore();
        }

        /// <summary>
        /// Generate a new deck of cards
        /// </summary>
        public void Restore() {
            deckOfCards = new Queue<Card>();
            foreach (var suit in Enum.GetValues(typeof(Suits))) {
                foreach (var rank in Enum.GetValues(typeof(Ranks))) {
                    deckOfCards.Enqueue(new Card((Ranks)rank, (Suits)suit));
                }
            }
        }

        /// <summary>
        /// Shuffles the deck. Throws EmptyDeckException if deck is empty
        /// </summary>
        public void Shuffle() {
            if (deckOfCards.Count == 0) {
                throw new EmptyDeckException("No cards left to shuffle!");
            }
            var deck = deckOfCards.ToList();
            deckOfCards.Clear();
            while (deck.Count > 0) {
                var randomIndex = new Random(deck.Count * DateTime.Now.Millisecond).Next(deck.Count);
                deckOfCards.Enqueue(deck.ElementAt(randomIndex));
                deck.RemoveAt(randomIndex);
            }
        }

        /// <summary>
        /// Draw a card from the top of the deck. May be null if deck is empty
        /// </summary>
        public Card Draw() => deckOfCards.Any() ? deckOfCards.Dequeue() : null;

        /// <summary>
        /// Return a card to the deck
        /// </summary>
        public void ReturnCard(Card card) {
            if (!deckOfCards.Contains(card)) {
                deckOfCards.Enqueue(card);
            }
        }

        /// <summary>
        /// Peek at the next card in the deck. May be null if deck is empty.
        /// </summary>
        public Card Peek() {
            deckOfCards.TryPeek(out var peek);
            return peek;
        }
    }
}