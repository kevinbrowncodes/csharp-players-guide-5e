using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory
{
    public class Sword : InventoryItem
    {
        public Sword()
        {
            Weight = 5F;
            Volume = 3F;
        }

        public override string ToString()
        {
            return "sword";
        }
    }
}
