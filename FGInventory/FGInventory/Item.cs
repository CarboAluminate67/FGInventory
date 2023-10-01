using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//base item class

namespace FGInventory
{
    public class Item
    {
        protected int _quantity;
        private string _name;

        public Item(string name, int quant) // initializer
        {
            _quantity = quant;
            _name = name;
        }

        public virtual void AddItems(int quant) // increases quantity
        {
            _quantity += quant;
        }

        public void NewQuant(int quant)
        {
            _quantity = quant;
        }

        public int GetQuant() // various getters and setters
        {
            return _quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public virtual void UseItem(int quant) // reduces quantity
        {
            _quantity -= quant;
        }

        public virtual string MakeString() //serializes object into string
        {
            return $"{_name}; {_quantity}";
        }

        public virtual string GetPack()
        {
            return "N/A";
        }
        public virtual string GetExpiresOn() // defining inherited methods
        {
            return "N/A";
        }
        public virtual int GetExp()
        {
            return 0;
        }
    }
}
