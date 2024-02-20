using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace StatisticaLab1
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }
        public Person Person { get; set; } = new Person();

        private void RadForm1_Load(object sender, EventArgs e)
        {
            radPropertyGrid1.SelectedObject = Person;
        }

        private void radTileElement1_Click(object sender, EventArgs e)
        {
            Person = new Person();
            radPropertyGrid1.SelectedObject = Person;
        }

        private void radTileElement2_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("statist.exe");

        }

        private void radTileElement11_Click(object sender, EventArgs e)
        {
            var f = new RadToolbarForm1();
            f.Person = Person;
            f.ShowDialog();
        }

        private void radTileElement12_Click(object sender, EventArgs e)
        {
            var f = new RadToolbarForm2();
            f.Person = Person;
            f.ShowDialog();
        }
    }
}
