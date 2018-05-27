using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;



namespace Task4
{
    public class Notebook : IAsset
    {
        private decimal m_restvalue;

        public Notebook(string name, string serialnumber, decimal inventorynumber, decimal restvalue)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Serial number is not NULL!", nameof(name));
            if (string.IsNullOrWhiteSpace(serialnumber)) throw new ArgumentException("Serial number is not NULL!", nameof(serialnumber));
            
            
            if (inventorynumber <= 0) throw new ArgumentException("Inventory number cannot be 0 or negative!", nameof(inventorynumber));
            if (restvalue <= 0) throw new ArgumentException("Rest value cannot be 0 or negative!", nameof(restvalue));

            Name = name;
            Serialnumber = serialnumber;
            Inventorynumber = inventorynumber;
            SetRestvalue(restvalue);

        }



        public string Name { get; private set; }

        public string Serialnumber { get; private set; }

        public decimal Inventorynumber { get; private set; }

        public decimal Restvalue => m_restvalue;

        public void SetRestvalue(decimal rvalue)
        {
            if (rvalue >= 0)
                m_restvalue = rvalue;
            else
                throw new ArgumentException("Initial rest value must be larger than zero and positive!", nameof(rvalue));

        }

        public void UpdateRestValue(decimal value)
        {
            if (m_restvalue >= value)
                m_restvalue = m_restvalue - value;
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

       decimal IAsset.PrintRestValue => m_restvalue;
    }




}

