using System;
namespace VinFletchersArrow
{
    /* Modify your Arrow class to have pricate instead of public fields */
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

        private Arrowhead arrowhead;
        private Fletching fletching;
        private int length;
        private float cost;

        public Arrow(Arrowhead arrowhead, int length, Fletching fletching)
        {
            this.arrowhead = arrowhead;
            this.length = length;
            this.fletching = fletching;

            cost = GetCost(this.arrowhead, this.length, this.fletching);
        }

        /* Add in getter methods for each of the fields that you have */
        public Arrowhead GetArrowHead() => arrowhead;
        public Fletching GetFletching() => fletching;
        public int GetLength() => length;
        public float GetCost() => cost;

        private float GetCost(Arrowhead arrowhead, int length, Fletching fletching)
        {
            float costArrowhead;
            float costLength;
            float costFletching;
            float costTotal;

            // arrowhead money
            if (Arrowhead.Wood == arrowhead)
            {
                costArrowhead = 3;
            }
            else if (Arrowhead.Obsidian == arrowhead)
            {
                costArrowhead = 5;
            }
            else if (Arrowhead.Steel == arrowhead)
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
            if (Fletching.Goose == fletching)
            {
                costFletching = 3;
            }
            else if (Fletching.Turkey == fletching)
            {
                costFletching = 5;
            }
            else if (Fletching.Plastic == fletching)
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

