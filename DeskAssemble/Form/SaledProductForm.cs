using DeskAssembleData.Dao;
using DeskAssembleData.Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskAssemble
{
    public partial class SaledProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SaledProductForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            salemodel2BindingSource.DataSource = Dao.Order.GetSaleModels();
        }

        private void chartControl1_SelectedItemsChanged(object sender, DevExpress.XtraCharts.SelectedItemsChangedEventArgs e)
        {
            Salemodel2 selectedItem = chartControl1.SelectedItems[0] as Salemodel2;

            if (selectedItem == null)
                return;

            SaledProductDetailForm newSaleProduct = new SaledProductDetailForm(this, selectedItem);
            newSaleProduct.Show();
        }
    }
}