using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Desk : IAsset
    {


        private decimal restvalue;
        public Desk(string name, decimal roomnumber, decimal inventorynumber, decimal value)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be NULL!", nameof(name));
            if (inventorynumber == 0) throw new ArgumentException("Inventory number is not 0!", nameof(inventorynumber));

            Name = name;
            Inventorynumber = inventorynumber;
            Roomnumber = roomnumber;

            SetRestvalue(value);

        }

        public string Name { get; private set; }

        public decimal Roomnumber { get; private set; }

        public decimal Inventorynumber { get; private set; }

        public void SetRestvalue(decimal rvalue)
        {
            if (rvalue > 0)
                restvalue = rvalue;
            else
                throw new ArgumentException("Initial rest value must be larger than zero and positive!", nameof(rvalue));

        }


        decimal IAsset.PrintRestValue() => restvalue;
    }
}
