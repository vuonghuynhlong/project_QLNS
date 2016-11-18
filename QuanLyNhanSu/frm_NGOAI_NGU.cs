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
    public partial class frm_NGOAI_NGU : frm_TEMPLATE
    {
        public frm_NGOAI_NGU()
        {
            InitializeComponent();
            this.Load += frm_NGOAI_NGU_Load;
        }

        void frm_NGOAI_NGU_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_LANGUAGE.Get_Data();
        }
    }
}
