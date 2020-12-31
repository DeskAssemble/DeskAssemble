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
    public partial class OrderListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            List<Order> list = Dao.Order.Search();
            orderBindingSource.DataSource = list;
            base.OnLoad(e);
        }
    }

}