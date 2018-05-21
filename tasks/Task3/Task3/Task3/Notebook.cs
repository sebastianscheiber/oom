using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Notebook : Asset
    {
        private decimal restvalue;
        public Notebook(string name, string serialnumber, decimal inventorynumber, decimal value)
        {
            if (string.IsNullOrWhiteSpace(serialnumber)) throw new ArgumentException("Serial number is not NULL!", nameof(serialnumber));
            if (inventorynumber == 0) throw new ArgumentException("Inventory number is not 0!", nameof(inventorynumber));

            Name = name;
            Serialnumber = serialnumber;
            Inventorynumber = inventorynumber;
            SetRestvalue(value);

        }

        public string Name { get; private set; }

        public string Serialnumber { get; private set; }

        public decimal Inventorynumber { get; private set; }

        public void SetRestvalue(decimal rvalue)
        {
            if (rvalue > 0)
                restvalue = rvalue;
            else
                throw new ArgumentException("Initial rest value must be larger than zero and positive!", nameof(rvalue));

        }

        public void UpdateRestValue(decimal value)
        {
            if (restvalue >= value)
                restvalue = restvalue - value;
            else
                throw new ArgumentException("Rest value cannot be negative!", nameof(value));

        }

        // public decimal PrintRestValue => restvalue;

        public string SetSerialNumber(string newserialnumber)
        {
            if (string.IsNullOrWhiteSpace(newserialnumber))
                throw new ArgumentException("Serial number is not NULL!", nameof(newserialnumber));
            else
            {
                this.Serialnumber = newserialnumber;
                return this.Serialnumber;
            }
        }

        public void SetInventoryNumber(decimal newinventorynumber)
        {
            if (newinventorynumber <= 0)
                throw new ArgumentException("Inventory number negative or zero!", nameof(newinventorynumber));
            else
                this.Inventorynumber = newinventorynumber;
        }

        decimal Asset.PrintRestValue() => restvalue;
    }




}

