using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSON_InventoryDataManagement
{
    class Inventorymanagement
    {
        /// <summary>
        /// intializing the inventories by using json file
        /// </summary>

        public void GetData()
        {
            try
            {
                var json = File.ReadAllText(@"C:\Users\divak\Source\Repos\JSON-InventoryDataManagement\JSON-InventoryDataManagement\json1.json");
                var jobject = JObject.Parse(json);

                JArray inventoriesArr = (JArray)jobject["inventories"];
                if (inventoriesArr != null)
                {
                    foreach (var item in inventoriesArr)
                    {
                        Console.WriteLine("name is = " + item["name"]);
                        Console.WriteLine("price is = " + item["price"]);
                        Console.WriteLine("weight is = " + item["weight"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.Message.ToString());
            }
        }
        /// <summary>
        /// calculating the inventories
        /// using jtoken calculating waight and price
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="price"></param>


        public void GetValue(JToken weight, JToken price)
        {
            int weightConv = weight.ToObject<int>();
            int priceConv = price.ToObject<int>();
            try
            {
                int totalValue = weightConv * priceConv;
                Console.WriteLine($"Value of Inventories : {totalValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
            
            
            





               
                
    

