using DeskAssembleData.Dao;
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
    }
}