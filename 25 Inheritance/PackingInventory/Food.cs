using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    public class Food : InventoryItem
    {
        public Food() 
        {
            Weight = 1F;
            Volume = 0.5F;
        }
    }
}
