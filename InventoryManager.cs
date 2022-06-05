using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class InventoryManager
    {

        public List<string> StockNames { get; set; }
        public List<int> NoOfShares { get; set; }
        public List<double> SharePrice { get; set; }
    }
}
