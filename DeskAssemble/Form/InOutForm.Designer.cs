
namespace DeskAssemble
{
    partial class InOutForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.movementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMovementId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.movementBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 605);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // movementBindingSource
            // 
            this.movementBindingSource.DataSource = typeof(DeskAssembleData.Movement);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMovementId,
            this.colItemId,
            this.colContractId,
            this.colDatetime,
            this.colIsIn,
            this.colWareHouseId,
            this.colQuantity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMovementId
            // 
            this.colMovementId.Caption = "입/출고번호";
            this.colMovementId.FieldName = "MovementId";
            this.colMovementId.Name = "colMovementId";
            this.colMovementId.Visible = true;
            this.colMovementId.VisibleIndex = 0;
            // 
            // colItemId
            // 
            this.colItemId.Caption = "품목";
            this.colItemId.FieldName = "ItemName";
            this.colItemId.Name = "colItemId";
            this.colItemId.Visible = true;
            this.colItemId.VisibleIndex = 1;
            // 
            // colContractId
            // 
            this.colContractId.Caption = "거래처";
            this.colContractId.FieldName = "ContractName";
            this.colContractId.Name = "colContractId";
            this.colContractId.Visible = true;
            this.colContractId.VisibleIndex = 5;
            // 
            // colDatetime
            // 
            this.colDatetime.Caption = "시각";
            this.colDatetime.FieldName = "Datetime";
            this.colDatetime.Name = "colDatetime";
            this.colDatetime.Visible = true;
            this.colDatetime.VisibleIndex = 4;
            // 
            // colIsIn
            // 
            this.colIsIn.Caption = "구분";
            this.colIsIn.FieldName = "IsInName";
            this.colIsIn.Name = "colIsIn";
            this.colIsIn.Visible = true;
            this.colIsIn.VisibleIndex = 3;
            // 
            // colWareHouseId
            // 
            this.colWareHouseId.Caption = "창고";
            this.colWareHouseId.FieldName = "WareHouseName";
            this.colWareHouseId.Name = "colWareHouseId";
            this.colWareHouseId.Visible = true;
            this.colWareHouseId.VisibleIndex = 6;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "수량(개)";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // InOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 605);
            this.Controls.Add(this.gridControl1);
            this.Name = "InOutForm";
            this.Text = "입출고 리스트";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource movementBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMovementId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colContractId;
        private DevExpress.XtraGrid.Columns.GridColumn colDatetime;
        private DevExpress.XtraGrid.Columns.GridColumn colIsIn;
        private DevExpress.XtraGrid.Columns.GridColumn colWareHouseId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
    }
}