using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory
{
    public class Water : InventoryItem
    {
        public Water() 
        {
            Weight = 2F;
            Volume = 3F;
        }

        public override string ToString()
        {
            return "water";
        }
    }
}
