using System;
namespace VinFletchersArrow
{
	/* Define a new Arrow class with fields for arrowhead type, fletching type,
	* and length. */  
	public class Arrow
	{
        public enum Arrowhead
        {
            Steel,
            Wood,
            Obsidian
        }

        public enum Fletching
        {
            Plastic,
            Turkey,
            Goose
        }

        Arrowhead arrowhead;
        Fletching fletching;
		int length;

		public Arrow(Arrowhead arrowhead, int length, Fletching fletching)
		{
			this.arrowhead = arrowhead;
			this.length = length;
            this.fletching = fletching;
        }

        public float GetCost(Arrow arrow)
        {
            float costArrowhead;
            float costLength;
            float costFletching;
            float costTotal;

            // arrowhead money
            if(Arrowhead.Wood == arrow.arrowhead)
            {
                costArrowhead = 3;
            }
            else if(Arrowhead.Obsidian == arrow.arrowhead)
            {
                costArrowhead = 5;
            }
            else if (Arrowhead.Steel == arrow.arrowhead)
            {
                costArrowhead = 10;
            }
            else
            {
                costArrowhead = 0;
            }

            // shaft money
            costLength = length * 0.05F;

            // fletching money
            if (Fletching.Goose == arrow.fletching)
            {
                costFletching = 3;
            }
            else if (Fletching.Turkey == arrow.fletching)
            {
                costFletching = 5;
            }
            else if (Fletching.Plastic == arrow.fletching)
            {
                costFletching = 10;
            }
            else
            {
                costFletching = 0;
            }

            costTotal = (costArrowhead + costLength + costFletching);

            return costTotal;
        }


	}
}

