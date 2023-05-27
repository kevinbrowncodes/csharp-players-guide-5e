using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory
{
    public class Food : InventoryItem
    {
        public Food()
        {
            Weight = 1F;
            Volume = 0.5F;
        }

        public override string ToString()
        {
            return "food";
        }
    }
}
