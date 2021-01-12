
namespace DeskAssemble
{
    partial class SaledProductDetailForm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.productsaledetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsaledetailModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.productsaledetailModelBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "VendeeName";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "VendeeName";
            this.chartControl1.SeriesTemplate.SeriesDataMember = "VendeeName";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            this.chartControl1.Size = new System.Drawing.Size(738, 439);
            this.chartControl1.TabIndex = 0;
            // 
            // productsaledetailModelBindingSource
            // 
            this.productsaledetailModelBindingSource.DataSource = typeof(DeskAssembleData.Data.ProductsaledetailModel);
            // 
            // SaledProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 439);
            this.Controls.Add(this.chartControl1);
            this.Name = "SaledProductDetailForm";
            this.Text = "제품 판매량 상세";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsaledetailModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource productsaledetailModelBindingSource;
    }
}