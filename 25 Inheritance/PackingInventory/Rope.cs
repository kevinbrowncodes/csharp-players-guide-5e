using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    public class Rope :InventoryItem
    {
        public Rope()
        {
            Weight = 1F;
            Volume = 1.5F;
        }
    }
}
