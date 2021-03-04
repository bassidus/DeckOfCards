using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DeckOfCards.Tests {

    [TestClass()]
    public class CardTests {

        [TestMethod()]
        public void UniqueCardsTest() {
            var deck = new DeckOfCards();
            var uniques = new HashSet<Card>();
            var card = deck.Draw();
            deck.Shuffle();

            // Loop through the entire deck and add the cards to
            // a HashSet (which only takes unique items)
            while (card != null) {
                uniques.Add(card);
                card = deck.Draw();
            }

            Assert.AreEqual(expected: 52, actual: uniques.Count);
        }

        [TestMethod()]
        public void NumberOfCardsTest() {
            var deck = new DeckOfCards();
            var expected = 52;
            var actual = deck.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PeekTest() {
            var deck = new DeckOfCards();
            deck.Shuffle();
            var expected = deck.Peek();
            var actual = deck.Draw();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReturnCardTest() {
            var deck = new DeckOfCards();
            deck.Shuffle();
            // Draw a card and then return it to the bottom
            // of the deck
            var expected = deck.Draw();
            deck.ReturnCard(expected);
            var actual = deck[52];

            // Make sure the same card is at place 52
            Assert.AreEqual(expected, actual);

            // Make sure you cant return an already existing card
            // to the deck
            expected = deck[26];
            deck.ReturnCard(expected);
            actual = deck[52];
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        public void OperatorsTest() {
            var deck1 = new DeckOfCards();
            var deck2 = new DeckOfCards();
            var card1 = deck1.Draw();
            var card2 = deck2.Draw();
            var card3 = deck1.Draw();
            Assert.IsTrue(card1 == card2);
            Assert.IsTrue(card1 != card3);
        }

        [TestMethod()]
        public void CompareTest() {
            var a = new Card(Ranks.Ace, Suits.Spades);
            var b = new Card(Ranks.Two, Suits.Spades);
            Assert.AreEqual(expected: -1, actual: a.CompareTo(b));
            Assert.AreEqual(expected: 0, actual: a.CompareTo(a));
            Assert.AreEqual(expected: 1, actual: b.CompareTo(a));
        }
    }
}