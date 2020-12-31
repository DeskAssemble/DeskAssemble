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
using DevExpress.XtraMap;
using DeskAssembleData.Dao;
using DeskAssembleData;

namespace DeskAssemble
{
    public partial class PurchasedCountryForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PurchasedCountryForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            mapChartModelBindingSource.DataSource = Dao.Order.GetPurchasedCountryModels();
        }

        private void mapControl1_MapItemClick(object sender, MapItemClickEventArgs e)
        {
            MapBubble a = e.Item as MapBubble;

            if (a != null)
                MessageBox.Show(Convert.ToString(a));
        }
    }
    
}