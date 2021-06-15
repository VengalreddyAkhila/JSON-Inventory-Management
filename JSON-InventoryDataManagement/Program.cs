using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace JSON_InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JSON Inventorydatamanagement");
            Inventorymanagement inventory = new Inventorymanagement();
            inventory.GetData();
            inventory.GetValue(35,10);
                
            
           
        }
    }
}
