using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Perishable class

namespace FGInventory
{
    public class Perish : Item
    {
        private int _expireTime;
        private string _expiresOn;


        public Perish(string name, int quant, int exp) : base(name, quant) //Initializer
        {
            _expireTime = exp;
            DateTime date = DateTime.Now;
            date = date.AddDays(_expireTime);
            _expiresOn = date.ToString("MM-dd");
        }

        public override int GetExp()
        {
            return _expireTime;
        }

        public override void AddItems(int quant) //Creates Items and calculates date of expiration
        {
            base.AddItems(quant);
            DateTime date = DateTime.Now;
            date = date.AddDays(_expireTime);
            _expiresOn = date.ToString("MM-dd");
        }

        public override string GetExpiresOn() // various getters and setters
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

        public override string MakeString() //serializes object into string
        {
            return base.MakeString() + $"; {_expireTime}; {_expiresOn}";
        }
    }
}
