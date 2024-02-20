using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilLib
{
    public class ContGen :BaseGen
    {
        public IContinuousDistribution Distribution { get; set; } = new Normal(0, 1);
        public ContGen(int seed = 0) : base(seed)
        {
            Distribution = new Normal(0, 1, Rnd);
        }
        public double[] Generate(int N)
        {
            var res = new double[N];
            Distribution.Samples(res);
            return res;
        }
        public double Generate() => Distribution.Sample();
    }
}
