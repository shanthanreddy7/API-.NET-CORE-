using PracticeApiApplication.Models;
using System.Collections.Generic;

namespace PracticeApiApplication.Services
{
    interface IInventoryServices
    {
        InventoryItems AddInvetoryItems(InventoryItems items);
        Dictionary<string, InventoryItems> GetInventoryItems();
    }   
}
