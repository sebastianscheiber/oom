using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class Desk : IAsset
    {
        private decimal m_restvalue;
        public Desk(string name, decimal roomnumber, decimal inventorynumber, decimal restvalue)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be NULL!", nameof(name));

            if (inventorynumber <= 0) throw new ArgumentException("Inventory number is not 0!", nameof(inventorynumber));
            if (roomnumber <= 0) throw new ArgumentException("Room number cannot be 0 or negative!", nameof(roomnumber));
            if (restvalue <= 0) throw new ArgumentException("Rest value cannot be 0 or negative!", nameof(restvalue));

            Name = name;
            Inventorynumber = inventorynumber;
            Roomnumber = roomnumber;

            SetRestvalue(restvalue);

        }

        public string Name { get; private set; }

        public decimal Roomnumber { get; private set; }

        public decimal Inventorynumber { get; private set; }

        public decimal Restvalue => m_restvalue;

        public void SetRestvalue(decimal rvalue)
        {
            if (rvalue >= 0)
                m_restvalue = rvalue;
            else
                throw new ArgumentException("Initial rest value must be larger than zero and positive!", nameof(rvalue));

        }


        decimal IAsset.PrintRestValue => m_restvalue;
    }
}
