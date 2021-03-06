﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Logger
{
    /// <summary>
    /// Class that exposes methods for creating loggers
    /// </summary>
    public class LoggerFactory
    {
        /// <summary>
        /// The logger output
        /// </summary>
        private static TextBox mOutputBox = null;

        /// <summary>
        /// Set the text box that this logger will print to.
        /// This must be called first to initialize this factory
        /// </summary>
        /// <param name="outputBox">The text box</param>
        public static void SetLoggerOutput(TextBox outputBox)
        {
            mOutputBox = outputBox;
        }

        /// <summary>
        /// Build and return a logger to use
        /// </summary>
        /// <param name="name">The name of the logger. Recommend using the class type name</param>
        /// <returns>A logger</returns>
        public static ILogger CreateLogger(string name)
        {
            if(mOutputBox == null) // SetLoggerOutput has not been called!
            {
                return new NullLogger();
            }
            else
            {
                return new TextBoxLogger(name, mOutputBox);
            }
        }
    }
}
