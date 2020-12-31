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
    public partial class PurchasedPartForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PurchasedPartForm()
        {
            InitializeComponent();
 
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            purchasemodel2BindingSource.DataSource = Dao.Order.GetPurchasemodelModels();
        }

        private void chartControl1_SelectedItemsChanged(object sender, DevExpress.XtraCharts.SelectedItemsChangedEventArgs e)
        {
            Purchasemodel2 selectedItem = chartControl1.SelectedItems[0] as Purchasemodel2;

            if (selectedItem == null)
                return;

            PurchasedPartDetailForm newPurchasedPart = new PurchasedPartDetailForm(this, selectedItem);
            newPurchasedPart.Show();

        }
    }
}