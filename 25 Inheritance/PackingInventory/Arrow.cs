using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    /* Create derived classes for each of the types of items above. Each class should pass the correct weight and volume to the base class constructor but should be creatable themselves with a paramterless constructor (for example, new Rope() or new Sword()). */
    public class Arrow : InventoryItem
    {
        public Arrow() 
        {
            Weight = 0.1F;
            Volume = 0.05F;
        }
    }
}
