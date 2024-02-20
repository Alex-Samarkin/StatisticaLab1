namespace StatisticaLab1
{
    partial class RadToolbarForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.BarSeries barSeries1 = new Telerik.WinControls.UI.BarSeries();
            Telerik.WinControls.UI.BarSeries barSeries2 = new Telerik.WinControls.UI.BarSeries();
            simpleDataBindingSource = new System.Windows.Forms.BindingSource(components);
            radToolbarFormControl1 = new Telerik.WinControls.UI.RadToolbarFormControl();
            radToolbarFormMenuItem1 = new Telerik.WinControls.UI.RadToolbarFormMenuItem();
            radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            radToolbarFormMenuItem2 = new Telerik.WinControls.UI.RadToolbarFormMenuItem();
            radScrollablePanel1 = new Telerik.WinControls.UI.RadScrollablePanel();
            radPageView1 = new Telerik.WinControls.UI.RadPageView();
            radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            radGridView1 = new Telerik.WinControls.UI.RadGridView();
            radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            radChartView1 = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)simpleDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radToolbarFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radScrollablePanel1).BeginInit();
            radScrollablePanel1.PanelContainer.SuspendLayout();
            radScrollablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radPageView1).BeginInit();
            radPageView1.SuspendLayout();
            radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).BeginInit();
            radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radChartView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // simpleDataBindingSource
            // 
            simpleDataBindingSource.DataMember = "Items";
            simpleDataBindingSource.DataSource = typeof(SimpleData);
            // 
            // radToolbarFormControl1
            // 
            radToolbarFormControl1.AutoSize = true;
            radToolbarFormControl1.CausesValidation = false;
            radToolbarFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            radToolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            radToolbarFormControl1.Name = "radToolbarFormControl1";
            radToolbarFormControl1.NearItems.AddRange(new Telerik.WinControls.RadItem[] { radToolbarFormMenuItem1, radToolbarFormMenuItem2 });
            radToolbarFormControl1.ShowIcon = true;
            radToolbarFormControl1.ShowText = true;
            radToolbarFormControl1.Size = new System.Drawing.Size(1310, 41);
            radToolbarFormControl1.TabIndex = 0;
            // 
            // radToolbarFormMenuItem1
            // 
            radToolbarFormMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] { radMenuItem1, radMenuItem2 });
            radToolbarFormMenuItem1.Name = "radToolbarFormMenuItem1";
            radToolbarFormMenuItem1.Text = "Data";
            // 
            // radMenuItem1
            // 
            radMenuItem1.Name = "radMenuItem1";
            radMenuItem1.Text = "Generate";
            // 
            // radMenuItem2
            // 
            radMenuItem2.Name = "radMenuItem2";
            radMenuItem2.Text = "To Clipboard";
            // 
            // radToolbarFormMenuItem2
            // 
            radToolbarFormMenuItem2.Name = "radToolbarFormMenuItem2";
            radToolbarFormMenuItem2.Text = "Graph";
            // 
            // radScrollablePanel1
            // 
            radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            radScrollablePanel1.Location = new System.Drawing.Point(0, 41);
            radScrollablePanel1.Name = "radScrollablePanel1";
            // 
            // radScrollablePanel1.PanelContainer
            // 
            radScrollablePanel1.PanelContainer.Controls.Add(radPageView1);
            radScrollablePanel1.PanelContainer.Size = new System.Drawing.Size(1308, 951);
            radScrollablePanel1.Size = new System.Drawing.Size(1310, 953);
            radScrollablePanel1.TabIndex = 1;
            // 
            // radPageView1
            // 
            radPageView1.Controls.Add(radPageViewPage1);
            radPageView1.Controls.Add(radPageViewPage2);
            radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            radPageView1.Location = new System.Drawing.Point(0, 0);
            radPageView1.Name = "radPageView1";
            radPageView1.SelectedPage = radPageViewPage2;
            radPageView1.Size = new System.Drawing.Size(1308, 951);
            radPageView1.TabIndex = 0;
            // 
            // radPageViewPage1
            // 
            radPageViewPage1.Controls.Add(radGridView1);
            radPageViewPage1.ItemSize = new System.Drawing.SizeF(40F, 29F);
            radPageViewPage1.Location = new System.Drawing.Point(6, 36);
            radPageViewPage1.Name = "radPageViewPage1";
            radPageViewPage1.Size = new System.Drawing.Size(1296, 909);
            radPageViewPage1.Text = "Data";
            // 
            // radGridView1
            // 
            radGridView1.BackColor = System.Drawing.Color.White;
            radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            radGridView1.ForeColor = System.Drawing.Color.Black;
            radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Index";
            gridViewDecimalColumn1.HeaderText = "Index";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Index";
            gridViewDecimalColumn1.Width = 40;
            gridViewDecimalColumn2.DataType = typeof(double);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Value";
            gridViewDecimalColumn2.HeaderText = "Value";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Value";
            gridViewDecimalColumn2.Width = 41;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Gender";
            gridViewTextBoxColumn1.HeaderText = "Gender";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Gender";
            gridViewTextBoxColumn1.Width = 51;
            radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] { gridViewDecimalColumn1, gridViewDecimalColumn2, gridViewTextBoxColumn1 });
            radGridView1.MasterTemplate.DataSource = simpleDataBindingSource;
            radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
            radGridView1.MasterTemplate.EnableFiltering = true;
            radGridView1.MasterTemplate.MultiSelect = true;
            radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridView1.Name = "radGridView1";
            radGridView1.ReadOnly = true;
            radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radGridView1.Size = new System.Drawing.Size(1296, 909);
            radGridView1.TabIndex = 0;
            // 
            // radPageViewPage2
            // 
            radPageViewPage2.Controls.Add(radChartView1);
            radPageViewPage2.ItemSize = new System.Drawing.SizeF(44F, 29F);
            radPageViewPage2.Location = new System.Drawing.Point(6, 36);
            radPageViewPage2.Name = "radPageViewPage2";
            radPageViewPage2.Size = new System.Drawing.Size(1296, 909);
            radPageViewPage2.Text = "Chart";
            // 
            // radChartView1
            // 
            cartesianArea1.ShowGrid = true;
            radChartView1.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            categoricalAxis1.LabelRotationAngle = 300D;
            categoricalAxis1.Title = "";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.LabelRotationAngle = 300D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "";
            radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] { categoricalAxis1, linearAxis1 });
            radChartView1.DataSource = simpleDataBindingSource;
            radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            radChartView1.LegendTitle = "Data";
            radChartView1.Location = new System.Drawing.Point(0, 0);
            radChartView1.Name = "radChartView1";
            radChartView1.SelectionMode = Telerik.WinControls.UI.ChartSelectionMode.MultipleDataPoints;
            barSeries1.DataSource = simpleDataBindingSource;
            barSeries1.HorizontalAxis = categoricalAxis1;
            barSeries1.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top;
            barSeries1.LegendTitle = null;
            barSeries1.VerticalAxis = linearAxis1;
            barSeries2.DataSource = simpleDataBindingSource;
            barSeries2.HorizontalAxis = categoricalAxis1;
            barSeries2.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top;
            barSeries2.LegendTitle = null;
            barSeries2.VerticalAxis = linearAxis1;
            radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] { barSeries1, barSeries2 });
            radChartView1.ShowLegend = true;
            radChartView1.ShowPanZoom = true;
            radChartView1.ShowToolTip = true;
            radChartView1.ShowTrackBall = true;
            radChartView1.Size = new System.Drawing.Size(1296, 909);
            radChartView1.TabIndex = 0;
            radChartView1.ThemeName = "ControlDefault";
            // 
            // RadToolbarForm1
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1310, 994);
            Controls.Add(radScrollablePanel1);
            Controls.Add(radToolbarFormControl1);
            Name = "RadToolbarForm1";
            Text = "Scatterplot";
            Load += RadToolbarForm1_Load;
            ((System.ComponentModel.ISupportInitialize)simpleDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)radToolbarFormControl1).EndInit();
            radScrollablePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radScrollablePanel1).EndInit();
            radScrollablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radPageView1).EndInit();
            radPageView1.ResumeLayout(false);
            radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1).EndInit();
            radPageViewPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radChartView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadToolbarFormControl radToolbarFormControl1;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel1;
        private Telerik.WinControls.UI.RadToolbarFormMenuItem radToolbarFormMenuItem1;
        private Telerik.WinControls.UI.RadToolbarFormMenuItem radToolbarFormMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource simpleDataBindingSource;
        private Telerik.WinControls.UI.RadChartView radChartView1;
    }
}
