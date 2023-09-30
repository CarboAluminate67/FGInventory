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

        public int GetExp()
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

        public string GetExpiresOn()
        {
            return _expiresOn;
        }
    }
}
