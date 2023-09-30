using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGInventory
{
    public class Item
    {
        private int _quantity;
        private string _name;

        public Item(string name, int quant)
        {
            _quantity = quant;
            _name = name;
        }

        public virtual void AddItems(int quant)
        {
            _quantity += quant;
        }

        public void NewQuant(int quant)
        {
            _quantity = quant;
        }

        public int GetQuant()
        {
            return _quantity;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
