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

namespace Hospital
{
    public partial class frmDsNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmDsNhanVien()
        {
            InitializeComponent();
        }

        private void frmDsNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVDataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter.Fill(this.qLBVDataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN);
            // TODO: This line of code loads data into the 'qLBVDataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter.Fill(this.qLBVDataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bdsNhanVienKhongTK[bdsNhanVienKhongTK.Position];
            Program.MaNhanVienChon = drv["MANV"].ToString();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}