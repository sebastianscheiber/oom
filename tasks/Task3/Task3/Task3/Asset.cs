﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public interface IAsset
    {
        string Name { get; }
        decimal PrintRestValue();
    }
}
