﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockObjectDemo
{
    public interface IInterfaceToMock
    {
        int PerformExpensiveDatabaseLookup(int index);
    }
}
