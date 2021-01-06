using DeskAssembleData;
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
    public partial class ProfitRateForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ProfitRateForm()
        {
            InitializeComponent();
        }

        private void ProfitRateForm_Load(object sender, EventArgs e)
        {
            List<OrderModel> list = Dao.Order.OrderModels();
            orderModelBindingSource.DataSource = list;
        }
    }
}