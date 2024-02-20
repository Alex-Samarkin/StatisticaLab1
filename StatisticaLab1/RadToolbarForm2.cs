using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using UtilLib;

namespace StatisticaLab1
{
    public partial class RadToolbarForm2 : Telerik.WinControls.UI.RadToolbarForm
    {
        public RadToolbarForm2()
        {
            InitializeComponent();
        }
        public Person Person { get; set; } = new Person();
        public Simple3dData Data { get; set; } = new Simple3dData();

        private void RadToolbarForm2_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 650;

            Data.Seed = Person.HashCode;
            ContGen r = new ContGen(Data.Seed);
            var N = r.NextInt(800, 1200);

            Data.FillIndex(N);

            simple3dDataBindingSource.DataSource = Data;
            simple3dDataBindingSource.DataMember = "Items";
            simple3dDataBindingSource.ResetBindings(false);

            radGridView1.BestFitColumns();
            radGridView1.ClipboardCopyMode = GridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            radGridView1.SelectAll();
            radGridView1.Copy();

            radChartView1.DataSource = Data;
            radChartView1.DataMember = "Items";
            radChartView1.Series.Clear();

            /*var ls = new LineSeries();
            ls.DataSource = Data.Items;
            ls.CategoryMember = "Index";
            ls.ValueMember = "Value";
            ls.ShowLabels = false;
            ls.LegendTitle = "Generated data";*/

            //radChartView1.Series.Add(ls);
            
            var ls = new LineSeries();
            ls.DataSource = Data.Items;
            ls.CategoryMember = "Index";
            ls.ValueMember = "Weight";
            ls.ShowLabels = false;
            ls.LegendTitle = "Generated data Weight";

            radChartView1.Series.Add(ls);

            var ls1 = new LineSeries();
            ls1.DataSource = Data.Items;
            ls1.CategoryMember = "Index";
            ls1.ValueMember = "Height";
            ls1.ShowLabels = false;
            ls1.LegendTitle = "Generated data Height";

            radChartView1.Series.Add(ls1);
        }

        private void Ge(object sender, EventArgs e)
        {

        }
    }
}
