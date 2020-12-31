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
    public partial class SaledCountryForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SaledCountryForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            mapChartModelBindingSource.DataSource = Dao.Order.GetSoldCountryModels();
        }
    }
}