﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceOnset.Common
{
    public enum ServiceRunMode
    {
        Daemon,
        Launch,
        Interval,
        ForceInterval
    }
}