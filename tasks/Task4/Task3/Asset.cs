using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public interface IAsset
    {
        string Name { get; }
        decimal PrintRestValue { get; }
    }
}
