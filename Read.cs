using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace StockAccountManagement
{
    public class Read
    {
        public void ReadtheData(string path)
        {
            InventoryManager inventoryManager = new InventoryManager();

            using (StreamReader file = new StreamReader(path))
            {
                string json = file.ReadToEnd();

                inventoryManager = JsonConvert.DeserializeObject<InventoryManager>(json);

            }
        }
    }
}
