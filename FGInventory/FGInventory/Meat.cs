using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGInventory
{
    public class Meat : Perish
    {
        private string _packDate;

        public Meat(string name, int quant, int exp, string pack) : base(name, quant, exp) //initializer
        {
            _packDate = pack;
        }

        public string GetPack() // Various getters and setters
        {
            return _packDate;
        }

        public override void UseItem(int quant) // Adds pack date to use item function in base class
        {
            base.UseItem(quant);
            if (_quantity <= 0)
            {
                _packDate = "N/A";
            }
        }

        public override string MakeString() //serializes object into string
        {
            return base.MakeString() + $"; {_packDate}";
        }
    }
}
