﻿using EntityFX.NetBenchamarks.Core.Generic;
using System.Diagnostics;

namespace EntityFX.NetBenchamarks.Core.Dhrystone
{
    public class DhrystoneBenchmark : BenchmarkBase, IBenchamrk
    {
        private readonly Dhrystone2 dhrystone = new Dhrystone2();

        public DhrystoneBenchmark()
        {
            
        }

        public override BenchResult Bench()
        {
            var sw = new Stopwatch();
            sw.Start();
            var dhrystoneResult = dhrystone.Bench();
            var result = BuildResult(sw);
            result.Output = dhrystoneResult.Output;
            result.Result = dhrystoneResult.VaxMips;
            return result;
        }

        public override void Warmup(double aspect = 0.05)
        {

        }
    }

}