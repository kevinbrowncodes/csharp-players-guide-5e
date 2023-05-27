using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory
{
    public class Arrow : InventoryItem
    {
        public Arrow() 
        {
            Weight = 0.1F;
            Volume = 0.05F;
        }

        public override String ToString()
        {
            return "arrow";
        }
    }
}
