
namespace StockAccountManagement
{

    /// <summary>
    ///  Welcome to this program of Stock Managementm, where we are going to print a Stock Report with total value of each Stock and the total value of Stock.
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this program of Stock Management.");
            
            InventoryManager inventoryManager = new InventoryManager();
            Read read = new Read();
            
            string path = "C:/Users/tusha/source/repos/StockAccountManagement/StockAccountManagement/StockInventory.json";
            inventoryManager = read.ReadtheData(path);
            


            for (int i = 0; i<inventoryManager.StockNames.Count;i++)
            {
                Console.WriteLine($"Stock name: {inventoryManager.StockNames[i]} No of Shares: {inventoryManager.NoOfShares[i]} Share Price: {inventoryManager.SharePrice[i]}");
                Console.WriteLine($"Value for {inventoryManager.StockNames[i]} is {inventoryManager.NoOfShares[i]* inventoryManager.SharePrice[i]}\n\n");
            }

            

        }
    }
}