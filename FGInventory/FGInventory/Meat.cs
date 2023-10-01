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

        public Meat(string name, int quant, int exp, string pack) : base(name, quant, exp)
        {
            _packDate = pack;
        }

        public string GetPack()
        {
            return _packDate;
        }

        public override void UseItem(int quant)
        {
            base.UseItem(quant);
            if (_quantity <= 0)
            {
                _packDate = "N/A";
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"; {_packDate}";
        }
    }
}
