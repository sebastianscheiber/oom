using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{

    class Asset
    {
        private decimal restvalue;
           
        
        public Asset(string name, string serialnumber, decimal inventorynumber, decimal value)
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

        public decimal PrintRestvalue => restvalue;

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

    }


    class Program
    {
        static void Main(string[] args)
        {
            Asset notebook1 = new Asset("super-tablet","bla123", 789, 800);
            Console.WriteLine("The serial number of " + notebook1.Name + " is: " + notebook1.Serialnumber + 
                " the inventory number is: " + notebook1.Inventorynumber + " the rest value is: " + notebook1.PrintRestvalue);
            notebook1.SetSerialNumber("123bla");
            notebook1.SetInventoryNumber(1789);
            Console.WriteLine("The serial number of " + notebook1.Name + " is: " + notebook1.Serialnumber +
                " the inventory number is: " + notebook1.Inventorynumber + " the rest value is: " + notebook1.PrintRestvalue);
            //Console.WriteLine("Set new rest value:");
            //notebook1.SetRestvalue(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Reduce the rest value for amount of or enter 0 if you do not want to reduce the rest value:");
            notebook1.UpdateRestValue(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("The rest value of " + notebook1.Name + " is: " + notebook1.PrintRestvalue);
            Console.WriteLine("\n");

            Asset monitor2 = new Asset("the-monitor","sumsang15", 125, 250);
            Console.WriteLine("The serial number of " + monitor2.Name + " is: " + monitor2.Serialnumber + 
                " the inventory number is: " + monitor2.Inventorynumber + " the rest value is: " + monitor2.PrintRestvalue);
            monitor2.SetSerialNumber("19sumsang");
            monitor2.SetInventoryNumber(130);
            Console.WriteLine("The serial number of " + monitor2.Name + " is: " + monitor2.Serialnumber + 
                " the inventory number is: " + monitor2.Inventorynumber+ " the rest value is: " + monitor2.PrintRestvalue);
            Console.WriteLine("Set new rest value:");
            monitor2.SetRestvalue(Convert.ToDecimal(Console.ReadLine()));
            //Console.WriteLine("Reduce the rest value for amount of or enter 0 if you do not want to reduce the rest value:");
            //monitor2.UpdateRestValue(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("The rest value of " + monitor2.Name + " is: " + monitor2.PrintRestvalue);

        }
    }
}
