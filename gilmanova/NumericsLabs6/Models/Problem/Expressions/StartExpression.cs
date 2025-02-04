﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Numerics6
{
    internal class StartExpression
    {
        public StartExpression(Func<double, double> f)
        {
            this.f = f;
        }

        public Func<double, double> f { get; set; }
    }
}

