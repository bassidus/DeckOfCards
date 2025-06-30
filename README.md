<img src="https://r2cdn.perplexity.ai/pplx-full-logo-primary-dark%402x.png" class="logo" width="120"/>

# DeckOfCards

**DeckOfCards** is a C\# library that provides a simple, object-oriented implementation of a standard 52-card deck. The project includes classes for representing cards, managing a deck, handling custom exceptions, and a suite of unit tests to ensure correctness.

## Features

- **Card Representation:** Encapsulates card rank and suit, with equality, comparison, and string formatting.
- **Deck Management:**
    - Create and restore a full deck.
    - Shuffle the deck.
    - Draw cards from the top.
    - Peek at the top card.
    - Return cards to the bottom of the deck.
- **Custom Exception:** Throws `EmptyDeckException` when deck operations are invalid (e.g., shuffling an empty deck).
- **Unit Tests:** Comprehensive tests using MSTest to verify deck behavior and card uniqueness.


## Project Structure

| File/Folder | Description |
| :-- | :-- |
| DeckOfCards/ | Main library source code |
| ├── Card.cs | Card class: rank, suit, comparison, equality, string representation |
| ├── DeckOfCards.cs | Deck management: shuffle, draw, restore, return, peek |
| ├── EmptyDeckException.cs | Custom exception for empty deck operations |
| ├── DeckOfCards.csproj | C\# project file |
| DeckOfCardsTests/ | Unit tests for the library |
| ├── DeckOfCardsTests.cs | MSTest test cases for deck and card logic |
| ├── DeckOfCardsTests.csproj | Test project file |
| DeckOfCards.sln | Visual Studio solution file |
| .gitignore, .gitattributes | Git configuration files |

## Usage

### Creating and Using a Deck

```csharp
using DeckOfCards;

// Create a new deck
var deck = new DeckOfCards();

// Shuffle the deck
deck.Shuffle();

// Draw a card
var card = deck.Draw();

// Peek at the next card
var nextCard = deck.Peek();

// Return a card to the bottom
deck.ReturnCard(card);
```


## Card and Deck Details

- **Ranks:** Ace, Two, Three, ..., Ten, Jack, Queen, King.
- **Suits:** Hearts, Clubs, Diamonds, Spades.
- **Deck Size:** 52 unique cards.
- **Equality:** Cards are compared by rank and suit.
- **Exceptions:** `EmptyDeckException` is thrown for invalid operations on an empty deck.


## Testing

Unit tests are implemented using MSTest and cover:

- Deck contains 52 unique cards.
- Card uniqueness and equality.
- Drawing, peeking, and returning cards.
- Exception handling for empty deck scenarios.


## Requirements

- .NET (C\#) development environment.
- MSTest for running unit tests.


## License

No license specified.

## Author

[GitHub: bassidus][^1]

[^1]: This README was generated based on the public repository structure and source code as of June 2025.

<div style="text-align: center">⁂</div>

[^1]: https://github.com/bassidus/DeckOfCards

