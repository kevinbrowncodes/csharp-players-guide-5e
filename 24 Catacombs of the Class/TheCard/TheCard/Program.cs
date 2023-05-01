using System;
using TheCard;

/* Create a main method that will create a card instance for the whole
 * deck (every color with every rank) and display each
 * (for example, "The Red Ampersand" and "The Blue Seven") */
// all ranks
int cardColorLength = Enum.GetNames(typeof(CardColor)).Length;

CardRank rankCurrent;
CardColor colorCurrent;
// all ranks
foreach (var rank in Enum.GetNames(typeof(CardRank)))
{
    rankCurrent = (CardRank)Enum.Parse(typeof(CardRank), rank);

    // all colors
    foreach (var color in Enum.GetNames(typeof(CardColor)))
    {
        colorCurrent = (CardColor)Enum.Parse(typeof(CardColor), color);

        Card card = new Card(colorCurrent, rankCurrent);

        Console.WriteLine($"The {card.CardColor} {card.CardRank}");
    }

}

/* Questions */
// Why do you think we used a color enumeration here but made a color class in
// the previous challenge?
/// We used a Color class in the previous challenge because we needed to create
/// new instances of the class along with its methods to manipulate date to
/// achieve the challenge result.
/// In this challenge we do not need to create new instances of Enum
/// with methods to manipulate data.
