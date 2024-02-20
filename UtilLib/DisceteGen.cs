using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.Distributions;

namespace UtilLib
{
    public class DisceteGen : BaseGen
    {
        public IDiscreteDistribution Distribution { get; set; } = new DiscreteUniform(0,100);
        public DisceteGen(int seed=0) : base(seed) 
        {
            Distribution = new DiscreteUniform(0,100,Rnd);
        }
        public int[] Generate(int N)
        {
            var res = new int[N];
            Distribution.Samples(res);
            return res;
        }
        public int Generate() => Distribution.Sample();
    }
}
