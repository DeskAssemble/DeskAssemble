﻿using DeskAssembleData.Dao;
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

namespace DeskAssemble.Form
{
    public partial class SalePerformanceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SalePerformanceForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            salesPerformanceModelBindingSource.DataSource = Dao.Team.GetModel();
        }
    }
}