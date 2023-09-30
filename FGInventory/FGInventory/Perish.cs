using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGInventory
{
    public class Perish : Item
    {
        private int _expireTime;

        public Perish(string name, int quant, int exp) : base(name, quant)
        {
            _expireTime = exp;
        }
    }
}
