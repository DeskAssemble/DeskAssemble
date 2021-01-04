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
    public partial class InOutForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public InOutForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            List<Movement> list = Dao.Movement.Search();
            movementBindingSource.DataSource = list;
            base.OnLoad(e);
        }
    }
}