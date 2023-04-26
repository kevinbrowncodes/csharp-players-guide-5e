using System;

namespace ArrowFactories
{
    public class Arrow
    {
        // fields
        private Arrowhead _arrowhead;
        private Fletching _fletching;
        private int _length;
        private float cost;

        // properties
        public Arrowhead Arrowhead
        {
            get
            {
                return _arrowhead;
            }
            private set
            {
                _arrowhead = value;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }
            private set
            {
                _length = value;
            }
        }

        public Fletching Fletching
        {
            get
            {
                return _fletching;
            }
            private set
            {
                _fletching = value;
            }
        }

        public Arrow(Arrowhead arrowhead, int length, Fletching fletching)
        {
            Arrowhead = arrowhead;
            Length = length;
            Fletching = fletching;

            //cost = GetCost(GetArrowHead(), GetLength(), GetFletching());
            cost = GetCost(Arrowhead, Length, Fletching);
        }

        /* Modify your Arrow class to include static methods for each of the
         * arrow types */
        // Beginner Arrow
        public static Arrow CreateBeginnerArrow()
        {
            Arrowhead arrowheadBeginner = Arrowhead.Wood;   // cost = $3
            int lengthBeginner = 75;                        // cost = $3.75
            Fletching fletchingBeginner = Fletching.Goose;  // cost = $3

            Arrow arrowBeginner = new Arrow(arrowheadBeginner, lengthBeginner, fletchingBeginner);

            return arrowBeginner;
        }

        // Marksman Arrow
        public static Arrow CreateMarksmanArrow()
        {
            Arrowhead arrowheadMarksman = Arrowhead.Steel;  // cost = $10
            int lengthMarksman = 65;                        // cost = $3.25
            Fletching fletchingMarksman = Fletching.Goose;  // cost = $3

            Arrow arrowMarksman = new Arrow(arrowheadMarksman, lengthMarksman, fletchingMarksman);

            return arrowMarksman;
        }

        // Elite Arrow
        public static Arrow CreateEliteArrow()
        {
            Arrowhead arrowheadElite = Arrowhead.Steel;     // cost = $10
            int lengthElite = 95;                           // cost = $4.75
            Fletching fletchingElite = Fletching.Plastic;   // cost = $10

            Arrow arrowElite = new Arrow(arrowheadElite, lengthElite, fletchingElite);

            return arrowElite;
        }

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

