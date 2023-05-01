using System;
namespace TheCard
{
	/* Define a Card class to represent a card with color and a rank */
	public class Card
	{
		// fields
		CardColor _color;
		CardRank _rank;

		// constructors
		public Card(CardColor color, CardRank rank)
		{
			_color = color;
			_rank = rank;
		}

		// properties
		public CardColor CardColor
		{
			get => _color;
		}

		public CardRank CardRank
		{
			get => _rank;
		}

		/* Add properties or methods that tell you if a card is a number or
		 * symbol card */
		public bool CardRankIsSymbol()
		{
			CardRank rank = this.CardRank;

			bool isSymbol = false;

			CardRank[] cardRankSymbols = new CardRank[] { CardRank.DollarSign, CardRank.Percent, CardRank.Caret, CardRank.Ampersand};

			foreach (CardRank cardRankSymbol in cardRankSymbols)
			{
				if(cardRankSymbol == rank)
				{
					isSymbol = true;
                }
			}

			return isSymbol;
		}
	}
}

