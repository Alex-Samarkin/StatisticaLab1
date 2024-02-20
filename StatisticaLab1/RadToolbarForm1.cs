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
    public partial class RadToolbarForm1 : Telerik.WinControls.UI.RadToolbarForm
    {
        public RadToolbarForm1()
        {
            InitializeComponent();
            
        }
        public Person Person { get; set; } = new Person();
        public SimpleData Data { get; set; } = new SimpleData();

        private void RadToolbarForm1_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 650;

            Data.Seed = Person.HashCode;
            ContGen r = new ContGen(Data.Seed);
            var N = r.NextInt(800, 1200);
            
            Data.FillIndex(N);

            simpleDataBindingSource.DataSource = Data;
            simpleDataBindingSource.DataMember = "Items";
            simpleDataBindingSource.ResetBindings(false);

            radGridView1.BestFitColumns();
            radGridView1.ClipboardCopyMode = GridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            radGridView1.SelectAll();
            radGridView1.Copy();

            radChartView1.DataSource = Data;
            radChartView1.DataMember = "Items";
            radChartView1.Series.Clear();

            var ls = new LineSeries();
            ls.DataSource = Data.Items;
            ls.CategoryMember = "Index";
            ls.ValueMember = "Value";
            ls.ShowLabels = false;
            ls.LegendTitle = "Generated data";

            radChartView1.Series.Add(ls);

            
        }
    }
}
