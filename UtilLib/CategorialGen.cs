using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

using MathNet.Numerics.Random;

namespace UtilLib
{
    public class CategorialGen : BaseGen
    {
        public Categorical Distribution { get; set; } = new Categorical(new double[] { 0.5, 0.5 });
        public CategorialGen(int seed=0) : base(seed) 
        {
            Distribution = new Categorical(new double[] {0.5, 0.5},Rnd);
        }
        public void SetProbability(double[] prob)
        {
            Distribution = new Categorical(prob, Rnd);
        }
        public int Sample()=>Distribution.Sample();
        public int[] Samples(int N = 1000)
        { 
            var res = new int[N];
            Distribution.Samples(res);
            return res;
        }
        char SampleChar(string s) => s[Sample()];
    }

    public class YesNo : CategorialGen
    {
        public string YesOrNo { get; set; } = "YN";
        public double[] prob { get; set; } = new double[] { 0.5, 0.5 };
        public YesNo(double[] p,string s="YN",int seed=0) : base(seed)
        {
            YesOrNo = s;
            prob = p;
            Distribution = new Categorical(prob, Rnd);
        }
        public char GetYesOrNoChar() => YesOrNo[Sample()];
        public string GetYesOrNoStr() =>new string(YesOrNo[Sample()],1);
    }
}
