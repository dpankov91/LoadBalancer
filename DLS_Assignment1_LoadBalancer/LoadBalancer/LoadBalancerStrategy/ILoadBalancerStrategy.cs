﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer.LoadBalancerStrategy
{
    public interface ILoadBalancerStrategy
    {
        public string NextService(List<string> services);
    }
}
