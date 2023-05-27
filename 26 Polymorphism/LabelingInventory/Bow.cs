using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory
{
    public class Bow : InventoryItem
    {
        public Bow()  
        {
            Weight = 1F;
            Volume = 4F;
        }

        public override String ToString()
        {
            return "bow";
        }
    }
}
