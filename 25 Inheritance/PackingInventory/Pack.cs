using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    /* Build a Pack class that can store an array of items. The total number of items, the maximum weight, and the maximum volume are provided at creation time and cannot change afterward */
    public class Pack
    {
        private int _maxCount;
        private float _maxWeight;
        private float _maxVolume;
        private InventoryItem[] _items;
        private int _currentCount;
        private float _currentWeight;
        private float _currentVolume;
        private bool _full;

        public int MaxCount { get => _maxCount; set => _maxCount = value; }
        public float MaxWeight { get => _maxWeight; set => _maxWeight = value; }
        public float MaxVolume { get => _maxVolume; set => _maxVolume = value; }
        public InventoryItem[] Items { get => _items;  private set => _items = value; }
        public int CurrentCount { get => _currentCount; private set => _currentCount = value; }
        public float CurrentWeight { get => _currentWeight; private set => _currentWeight = value; }
        public float CurrentVolume { get => _currentVolume; private set => _currentVolume = value; }
        public bool Full { get => _full; private set => _full = value; }


        public Pack(int maxCount, float maxVolume, float maxWeight) 
        {
            MaxCount = maxCount;
            MaxVolume = maxVolume;
            MaxWeight = maxWeight;

            Items = new InventoryItem[maxCount]; 
        }

        /* Make a public bool Add (InventoryItem item) method to Pack that allows you to add items of any type to the pack's contents. This method should fail (return false and not modify the pack's fields) if adding the item would cause it to exceed the pack's item, weight, or volume limit */
        public bool Add(InventoryItem item) 
        {
            bool isItemLimit = false;
            bool isWeightLimit = false;
            bool isVolumeLimit = false;

            // check item limit
            if (MaxCount > CurrentCount)
            {
                isItemLimit = true;
            }
            else
            {
                Full = true;
                Console.WriteLine("\nThe bag can not support additional item!");
            }

            // check weight limit
            if (MaxWeight > CurrentWeight)
            {
                isWeightLimit = true;
            }
            else
            {
                Full = true;
                Console.WriteLine("\nThe bag can not support additional weight!");
            }

            // check volume limit
            if (MaxVolume > CurrentVolume)
            {
                isVolumeLimit = true;
            }
            else
            {
                Full = true;
                Console.WriteLine("\nThe bag can not support additional volume!");
            }
            
            if(isItemLimit && isWeightLimit && isVolumeLimit)
            {
                CurrentCount++;
                CurrentWeight += item.Weight;
                CurrentVolume += item.Volume;
                return true;
            }

            return false;
        }
    }
}

// item[0]
// item[9]