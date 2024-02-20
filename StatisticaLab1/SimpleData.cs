using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using UtilLib;
using MathNet.Numerics.Distributions;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace StatisticaLab1
{
    public class Point
    {
        public int Index { get; set; } = 0;
        public double Value { get; set; } = 0;
        public string Gender { get; set; } = "";
    }
    public class Point3d
    {
        public int Index { get; set; } = 0;
        public double Weight { get; set; } = 0;
        public double Height {  get; set; } = 0;
        public double BMI => Math.Round(Height==0? 0 : Weight/(Height*Height)*10000.0,3);
        public string Gender { get; set; } = "";
    }
    public class SimpleData
    {
        public int Seed = 0;
        public List<Point> Items { get; set; } = new List<Point>();
        public void FillIndex(int N) 
        { 
            Items.Clear();

            ContGen contGen = new ContGen(Seed);
            YesNo mf = new YesNo(new double[] { 0.45, 0.55 },"mf");
            Items.Capacity = N;
            for(int i = 0; i < N; i++)
            {
                var p = new Point() { Index=i,Value=Math.Round(contGen.Generate(),3),Gender=mf.GetYesOrNoStr()};
                Items.Add(p);
            } 
        }
    }
    public class Simple3dData
    {
        public int Seed = 0;
        public List<Point3d> Items { get; set; } = new List<Point3d>();
        public void FillIndex(int N)
        {
            Items.Clear();

            ContGen contGen = new ContGen(Seed);
            contGen.Distribution = new Normal(180, 17);
            ContGen contGen1 = new ContGen(Seed);
            contGen1.Distribution = new Normal(24,1.1);

            YesNo mf = new YesNo(new double[] { 0.45, 0.55 }, "mf");

            Items.Capacity = N;
            for (int i = 0; i < N; i++)
            {
                var bmi = Math.Round(contGen1.Generate(),3);
                var h = Math.Round(contGen.Generate(),1);
                var w = Math.Round(bmi * (h * h) / 10000,2);
                var p = new Point3d() { 
                    Index = i, 
                    Height = h,
                    Weight = w,
                    Gender = mf.GetYesOrNoStr() };
                Items.Add(p);
            }
        }
    }
}
