using ThePropertiesOfArrows;

namespace VinFletchersArrow
{
    /* Modify your Arrow class to have pricate instead of public fields */
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

            /* Modify your Arrow class to use properties instead of GetX 
             * and SetX methods
             */
            //cost = GetCost(GetArrowHead(), GetLength(), GetFletching());
            cost = GetCost(Arrowhead, Length, Fletching);
        }

        /* Add in getter methods for each of the fields that you have */
        //public Arrowhead GetArrowHead() => arrowhead;
        //public Fletching GetFletching() => fletching;
        //public int GetLength() => _length;
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

