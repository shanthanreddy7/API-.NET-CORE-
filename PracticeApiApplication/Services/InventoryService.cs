using PracticeApiApplication.Models;
using System;
using System.Collections.Generic;

namespace PracticeApiApplication.Services
{
    public class InventoryService: IInventoryServices
    {
        private readonly Dictionary<String, InventoryItems> _inventoryItems;

        public InventoryService( )
        {

            _inventoryItems = new Dictionary<string, InventoryItems>();
        }
        public InventoryItems AddInvetoryItems(InventoryItems items)
        {
            _inventoryItems.Add(items.Name, items);

            return items;
        }

        public  Dictionary<string ,InventoryItems> GetInventoryItems()
        {
            return _inventoryItems;
        }

    }
}
