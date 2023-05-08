using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStore
{
    public class Inventory
    {
        public List<Meat> MeatList;
        public List<Produce> ProduceList;

        public Inventory()
        {
            MeatList = new List<Meat>();
            ProduceList = new List<Produce>();
        }
    }
}
