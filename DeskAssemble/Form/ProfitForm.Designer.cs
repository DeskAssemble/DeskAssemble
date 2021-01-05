
namespace DeskAssemble
{
    partial class ProfitForm
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding9 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding10 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding11 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding12 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding13 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding14 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding15 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding16 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding17 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding18 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldItemName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTeamName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldContractName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIsSaleName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldItemPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantityPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYearQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderId = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldItemId = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTeamId = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIsSale = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldContractId = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldContract = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldItem = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTeam = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.orderBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldItemName,
            this.fieldTeamName,
            this.fieldContractName,
            this.fieldIsSaleName,
            this.fieldCountryName,
            this.fieldItemPrice,
            this.fieldQuantityPrice,
            this.fieldYearQuarter,
            this.fieldOrderId,
            this.fieldItemId,
            this.fieldDate,
            this.fieldTeamId,
            this.fieldQuantity,
            this.fieldIsSale,
            this.fieldContractId,
            this.fieldContract,
            this.fieldItem,
            this.fieldTeam});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(962, 504);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DeskAssembleData.Order);
            // 
            // fieldItemName
            // 
            this.fieldItemName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldItemName.AreaIndex = 2;
            this.fieldItemName.Caption = "Item Name";
            dataSourceColumnBinding1.ColumnName = "ItemName";
            this.fieldItemName.DataBinding = dataSourceColumnBinding1;
            this.fieldItemName.Name = "fieldItemName";
            // 
            // fieldTeamName
            // 
            this.fieldTeamName.AreaIndex = 0;
            this.fieldTeamName.Caption = "Team Name";
            dataSourceColumnBinding2.ColumnName = "TeamName";
            this.fieldTeamName.DataBinding = dataSourceColumnBinding2;
            this.fieldTeamName.Name = "fieldTeamName";
            // 
            // fieldContractName
            // 
            this.fieldContractName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldContractName.AreaIndex = 1;
            this.fieldContractName.Caption = "Contract Name";
            dataSourceColumnBinding3.ColumnName = "ContractName";
            this.fieldContractName.DataBinding = dataSourceColumnBinding3;
            this.fieldContractName.Name = "fieldContractName";
            // 
            // fieldIsSaleName
            // 
            this.fieldIsSaleName.AreaIndex = 1;
            this.fieldIsSaleName.Caption = "Is Sale Name";
            dataSourceColumnBinding4.ColumnName = "IsSaleName";
            this.fieldIsSaleName.DataBinding = dataSourceColumnBinding4;
            this.fieldIsSaleName.Name = "fieldIsSaleName";
            // 
            // fieldCountryName
            // 
            this.fieldCountryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCountryName.AreaIndex = 0;
            this.fieldCountryName.Caption = "Country Name";
            dataSourceColumnBinding5.ColumnName = "CountryName";
            this.fieldCountryName.DataBinding = dataSourceColumnBinding5;
            this.fieldCountryName.Name = "fieldCountryName";
            // 
            // fieldItemPrice
            // 
            this.fieldItemPrice.AreaIndex = 2;
            this.fieldItemPrice.Caption = "Item Price";
            dataSourceColumnBinding6.ColumnName = "ItemPrice";
            this.fieldItemPrice.DataBinding = dataSourceColumnBinding6;
            this.fieldItemPrice.Name = "fieldItemPrice";
            // 
            // fieldQuantityPrice
            // 
            this.fieldQuantityPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantityPrice.AreaIndex = 0;
            this.fieldQuantityPrice.Caption = "Quantity Price";
            dataSourceColumnBinding7.ColumnName = "QuantityPrice";
            this.fieldQuantityPrice.DataBinding = dataSourceColumnBinding7;
            this.fieldQuantityPrice.Name = "fieldQuantityPrice";
            // 
            // fieldYearQuarter
            // 
            this.fieldYearQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYearQuarter.AreaIndex = 0;
            this.fieldYearQuarter.Caption = "Year Quarter";
            dataSourceColumnBinding8.ColumnName = "YearQuarter";
            this.fieldYearQuarter.DataBinding = dataSourceColumnBinding8;
            this.fieldYearQuarter.Name = "fieldYearQuarter";
            // 
            // fieldOrderId
            // 
            this.fieldOrderId.AreaIndex = 3;
            this.fieldOrderId.Caption = "Order Id";
            dataSourceColumnBinding9.ColumnName = "OrderId";
            this.fieldOrderId.DataBinding = dataSourceColumnBinding9;
            this.fieldOrderId.Name = "fieldOrderId";
            // 
            // fieldItemId
            // 
            this.fieldItemId.AreaIndex = 4;
            this.fieldItemId.Caption = "Item Id";
            dataSourceColumnBinding10.ColumnName = "ItemId";
            this.fieldItemId.DataBinding = dataSourceColumnBinding10;
            this.fieldItemId.Name = "fieldItemId";
            // 
            // fieldDate
            // 
            this.fieldDate.AreaIndex = 5;
            this.fieldDate.Caption = "Date";
            dataSourceColumnBinding11.ColumnName = "Date";
            this.fieldDate.DataBinding = dataSourceColumnBinding11;
            this.fieldDate.Name = "fieldDate";
            // 
            // fieldTeamId
            // 
            this.fieldTeamId.AreaIndex = 6;
            this.fieldTeamId.Caption = "Team Id";
            dataSourceColumnBinding12.ColumnName = "TeamId";
            this.fieldTeamId.DataBinding = dataSourceColumnBinding12;
            this.fieldTeamId.Name = "fieldTeamId";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.AreaIndex = 7;
            this.fieldQuantity.Caption = "Quantity";
            dataSourceColumnBinding13.ColumnName = "Quantity";
            this.fieldQuantity.DataBinding = dataSourceColumnBinding13;
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldIsSale
            // 
            this.fieldIsSale.AreaIndex = 8;
            this.fieldIsSale.Caption = "Is Sale";
            dataSourceColumnBinding14.ColumnName = "IsSale";
            this.fieldIsSale.DataBinding = dataSourceColumnBinding14;
            this.fieldIsSale.Name = "fieldIsSale";
            // 
            // fieldContractId
            // 
            this.fieldContractId.AreaIndex = 9;
            this.fieldContractId.Caption = "Contract Id";
            dataSourceColumnBinding15.ColumnName = "ContractId";
            this.fieldContractId.DataBinding = dataSourceColumnBinding15;
            this.fieldContractId.Name = "fieldContractId";
            // 
            // fieldContract
            // 
            this.fieldContract.AreaIndex = 10;
            this.fieldContract.Caption = "Contract";
            dataSourceColumnBinding16.ColumnName = "Contract";
            this.fieldContract.DataBinding = dataSourceColumnBinding16;
            this.fieldContract.Name = "fieldContract";
            // 
            // fieldItem
            // 
            this.fieldItem.AreaIndex = 11;
            this.fieldItem.Caption = "Item";
            dataSourceColumnBinding17.ColumnName = "Item";
            this.fieldItem.DataBinding = dataSourceColumnBinding17;
            this.fieldItem.Name = "fieldItem";
            // 
            // fieldTeam
            // 
            this.fieldTeam.AreaIndex = 12;
            this.fieldTeam.Caption = "Team";
            dataSourceColumnBinding18.ColumnName = "Team";
            this.fieldTeam.DataBinding = dataSourceColumnBinding18;
            this.fieldTeam.Name = "fieldTeam";
            // 
            // ProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 504);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "ProfitForm";
            this.Text = "분기별 매출";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldItemName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTeamName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldContractName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsSaleName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldItemPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantityPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYearQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderId;
        private DevExpress.XtraPivotGrid.PivotGridField fieldItemId;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTeamId;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsSale;
        private DevExpress.XtraPivotGrid.PivotGridField fieldContractId;
        private DevExpress.XtraPivotGrid.PivotGridField fieldContract;
        private DevExpress.XtraPivotGrid.PivotGridField fieldItem;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTeam;
    }
}