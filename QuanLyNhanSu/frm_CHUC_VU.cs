﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyNhanSu.DAO;
namespace QuanLyNhanSu
{
    public partial class frm_CHUC_VU : frm_TEMPLATE
    {
        public frm_CHUC_VU()
        {
            InitializeComponent();
            this.Load += frm_CHUC_VU_Load;
        }

        void frm_CHUC_VU_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_POSITION.Get_Data();
        }

        

       
    }
}
