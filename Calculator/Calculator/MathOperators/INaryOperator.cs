﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MathOperators
{
    /// <summary>
    /// Interface for all operators that take many operands
    /// </summary>
    public interface INaryOperator
    {
        /// <summary>
        /// Takes a list of operands and performs some operation on them
        /// </summary>
        /// <param name="operands">A list of operands</param>
        /// <returns>The result of the operation</returns>
        double PerformOperation(params double[] operands);

        /// <summary>
        /// Get the number of operands this operator requires
        /// </summary>
        /// <returns>The number of operands expected</returns>
        int NumOperandsExpected();

        /// <summary>
        /// ToString method
        /// </summary>
        /// <returns>The operator's symbol</returns>
        string ToString();
    }
}
