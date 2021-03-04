using System;

namespace DeckOfCards {

    public class EmptyDeckException : Exception {

        public EmptyDeckException() {
        }

        public EmptyDeckException(string message) : base(message) {
        }
    }
}