﻿
namespace DeskAssemble
{
    partial class SaledProductForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.salemodel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salemodel2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.salemodel2BindingSource;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single;
            this.chartControl1.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point;
            series1.ArgumentDataMember = "ProductName";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "Quantity";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(850, 555);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.SelectedItemsChanged += new DevExpress.XtraCharts.SelectedItemsChangedEventHandler(this.chartControl1_SelectedItemsChanged);
            // 
            // salemodel2BindingSource
            // 
            this.salemodel2BindingSource.DataSource = typeof(DeskAssembleData.Data.Salemodel2);
            // 
            // SaledProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 555);
            this.Controls.Add(this.chartControl1);
            this.Name = "SaledProductForm";
            this.Text = "제품 판매비율";
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salemodel2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource salemodel2BindingSource;
    }
}