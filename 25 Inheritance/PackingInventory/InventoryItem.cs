using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    /* Create an InventoryItem class that represents any of the different item types. This class must represent the item's weight and volume, which it needs at creation time (constructor) */
    public class InventoryItem
    {
        private float _weight;
        private float _volume;

        public float Weight { get => _weight; set => _weight = value; }
        public float Volume { get => _volume; set => _volume = value; }

        public InventoryItem() { }
    }
}
