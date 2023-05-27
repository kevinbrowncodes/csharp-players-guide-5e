using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory
{
    public class InventoryItem
    {
        private float _weight;
        private float _volume;

        public float Weight { get => _weight; set => _weight = value; }
        public float Volume { get => _volume; set => _volume = value; }

        public InventoryItem() { }
    }
}
