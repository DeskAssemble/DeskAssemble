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
    public partial class SaledProductDetailForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SaledProductDetailForm(SaledProductForm quantityForm, Salemodel2 smodel)
        {
            InitializeComponent();

            QuantityForm = quantityForm;
            SModel = smodel;
        }

        public SaledProductForm QuantityForm { get; }

        public Salemodel2 SModel { get; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<DeskAssembleData.Item> items = Dao.Item.GetItemsByCategoryId(SModel.ItemId);
            productsaledetailModelBindingSource.DataSource = Dao.Item.GetProductsaledetailModels();
        }
    }
}