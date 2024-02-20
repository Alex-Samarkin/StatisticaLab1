using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics;
using MathNet.Numerics.Random;

namespace UtilLib
{
    public class BaseGen
    {
        public int Seed { get; set; } = 0;
        public Random Rnd { get; set; } =new MersenneTwister();
        
        public BaseGen() { Seed = 0; Rnd = new MersenneTwister(Seed); }
        public BaseGen(int seed) {  Seed = seed; Rnd = new MersenneTwister(seed); }
        public void Reset (int seed=0) { Seed = seed; Rnd = new MersenneTwister(seed); }

        public int NextInt(int minValue = 0, int maxValue = 100) => Rnd.Next(minValue, maxValue);
        public int[] NextInt(int N, int minValue = 0, int maxValue = 100)
        {
            var res = new int[N];
            Rnd.NextInt32s(res, minValue, maxValue);
            return res;
        }
        public double NextDouble(double minValue=0d, double maxValue=1d) => minValue+Rnd.NextDouble()*(-minValue+maxValue);
        public double[] NextDouble(int N, double minValue=0d,double maxValue=1d)
        { 
            var res = new double[N];
            Rnd.NextDoubles(res);
            for (int i = 0; i < N; i++)
            {
                res[i] = minValue +(maxValue - minValue)*res[i];
            }
            return res;
        }
        public int[] SeqInt(int N) => Generate.LinearRangeInt32(0, N);
        public double[] ARange(double start = 0, double step = 0.1, double stop = 100) => Generate.LinearRange(start, step, stop);
        public double[] Linspace(int N=1000,double start = 0, double stop = 100) => Generate.LinearSpaced(N,start, stop);
        public double[] Normal(int N=1000,double mean = 1,double sd = 1) => Generate.Normal(N,mean,sd);
    }
}
