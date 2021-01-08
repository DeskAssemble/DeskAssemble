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
    public partial class WarehouseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public WarehouseListForm()
        {
            InitializeComponent();
        }

        private void WarehouseListForm_Load(object sender, EventArgs e)
        {
            List<WareHouse> list = Dao.WareHouse.GetAll();
            wareHouseBindingSource.DataSource = list;
        }

        //private void pivotGridControl1_Load(object sender, EventArgs e)
        //{
        //    List<Movement> list = Dao.Movement.Search2();
        //    movementBindingSource.DataSource = list;
        //}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            movementBindingSource.DataSource = Dao.Movement.Search2();
        }
    }
}