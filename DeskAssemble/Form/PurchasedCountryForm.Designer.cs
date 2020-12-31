
namespace DeskAssemble
{
    partial class PurchasedCountryForm
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
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.bubbleChartDataAdapter1 = new DevExpress.XtraMap.BubbleChartDataAdapter();
            this.mapChartModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapChartModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(732, 460);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl1_MapItemClick);
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AgvMO35OGV6SrETYJ66iBZkuemtqDfYvwqHv4in8tjYI7TJU5zG5SZYI-3l-vZZC";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            this.vectorItemsLayer1.Data = this.bubbleChartDataAdapter1;
            this.bubbleChartDataAdapter1.DataSource = this.mapChartModelBindingSource;
            this.bubbleChartDataAdapter1.Mappings.Latitude = "Latitude";
            this.bubbleChartDataAdapter1.Mappings.Longitude = "Longitude";
            this.bubbleChartDataAdapter1.Mappings.Text = "Name";
            this.bubbleChartDataAdapter1.Mappings.Value = "Value";
            // 
            // mapChartModelBindingSource
            // 
            this.mapChartModelBindingSource.DataSource = typeof(DeskAssembleData.Model.MapChartModel);
            // 
            // PurchasedCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 460);
            this.Controls.Add(this.mapControl1);
            this.Name = "PurchasedCountryForm";
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapChartModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.BubbleChartDataAdapter bubbleChartDataAdapter1;
        private System.Windows.Forms.BindingSource mapChartModelBindingSource;
    }
}