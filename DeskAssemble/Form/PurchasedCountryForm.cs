﻿using DevExpress.XtraEditors;
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
    }
}