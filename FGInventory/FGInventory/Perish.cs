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
        private string _expiresOn;


        public Perish(string name, int quant, int exp) : base(name, quant)
        {
            _expireTime = exp;
            DateTime date = DateTime.Today;
            date = date.AddDays(_expireTime);
            _expiresOn = date.ToShortDateString();
        }

        public override int GetExp()
        {
            return _expireTime;
        }

        public override void AddItems(int quant)
        {
            base.AddItems(quant);
            DateTime date = DateTime.Today;
            date = date.AddDays(_expireTime);
            _expiresOn = date.ToShortDateString();
        }

        public override string GetExpiresOn()
        {
            return _expiresOn;
        }

        public override void UseItem(int quant)
        {
            base.UseItem(quant);
            if (_quantity <= 0)
            {
                _expiresOn = "N/A";
            }

        }

        public override string ToString()
        {
            return base.ToString() + $"; {_expireTime}; {_expiresOn}";
        }
    }
}
