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
    public partial class PurchasedPartDetailForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PurchasedPartDetailForm(PurchasedPartForm quantityForm, Purchasemodel2 pmodel)
        {
            InitializeComponent();

            QuantityForm = quantityForm;
            Model = pmodel;
        }

        public PurchasedPartForm QuantityForm { get; }

        public Purchasemodel2 Model { get; }
    }
}