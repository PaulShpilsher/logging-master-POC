﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Logger
{
    internal interface ILoggerWriter
    {
        void WriteLogEntry(LogEntry logEntry);
    }
}
