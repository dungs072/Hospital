using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmPhongvaKhuChuaTri : DevExpress.XtraEditors.XtraForm
    {
        bool kiemTraThemKhuChua= false;
        bool kiemtraThemPhong = false;
        public frmPhongvaKhuChuaTri()
        {
            InitializeComponent();
        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBVDataSet);

        }

        private void frmPhongvaKhuChuaTri_Load(object sender, EventArgs e)
        {
            
            this.qLBVDataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLBVDataSet.GIUONG' table. You can move, or remove it, as needed.
            //this.gIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIUONGTableAdapter.Fill(this.qLBVDataSet.GIUONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHONGTableAdapter.Fill(this.qLBVDataSet.PHONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.KHUCHUATRI' table. You can move, or remove it, as needed.
            this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHUCHUATRITableAdapter.Fill(this.qLBVDataSet.KHUCHUATRI);
            // TODO: This line of code loads data into the 'qLBVDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHONGTableAdapter.Fill(this.qLBVDataSet.PHONG);

            panelKhuChuaTri.Enabled = false;
            panelPhong.Enabled = false;
            

        }

        private void pHONGBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBVDataSet);

        }

        private void pHONGBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnADD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsKhuChuaTri.AddNew();
                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = true;

                this.btnRELOAD.Enabled = false;
                this.btnTHOAT.Enabled = false;
                this.btnCANCEL.Enabled = true;
                this.btnSUA.Enabled = false;
                panelKhuChuaTri.Enabled = true;

                kiemTraThemKhuChua = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm  " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }


        private bool KiemTraKhuDieuTri()
        {
           // vì mã khu là khóa tự sinh nên khỏi cần kiểm tra
            if (txtTenKhu.Text == "")
            {
                MessageBox.Show("Không đc để trống Tên Khu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            /*if (Regex.IsMatch(txtTenKhu.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Mã chức vụ chỉ gồm chữ và số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }*/
            return true;
        }
      
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(KiemTraKhuDieuTri()==false)
            {
                return;
            }
                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.bdsPhong.EndEdit();
                    this.pHONGTableAdapter.Update(this.qLBVDataSet.PHONG);

                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    this.btnADD.Enabled = true;
                    this.btnXOA.Enabled = true;
                    this.btnGHI.Enabled = false;

                    this.btnRELOAD.Enabled = true;
                    this.btnTHOAT.Enabled = true;
                    this.btnCANCEL.Enabled = false;
                    this.btnSUA.Enabled = true;
                    panelKhuChuaTri.Enabled = false;
                }
            
        }


        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (bdsPhong.Count > 0)
            {
                MessageBox.Show("Đã tồn tại phòng trong khu chữa trị", "Thông báo", MessageBoxButtons.OK);
                return;
            }
           if(bdsChiTietLamViec.Count > 0)
            {
                MessageBox.Show("Đã tồn tại chi tiết làm việc trong khu chữa trị", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                
                try
                {

                    bdsKhuChuaTri.RemoveCurrent();
                    this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHUCHUATRITableAdapter.Update(this.qLBVDataSet.KHUCHUATRI);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    
                    this.btnADD.Enabled = true;
                    this.btnXOA.Enabled = true;
                    this.btnGHI.Enabled = false;

                    this.btnRELOAD.Enabled = true;
                    this.btnTHOAT.Enabled = true;
                    this.btnCANCEL.Enabled = false;
                    this.btnSUA.Enabled = true;
                    panelKhuChuaTri.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khu chữa trị. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);

                    return;
                }
            }
        }

        private void btnCANCEL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnADD.Enabled = true;
            this.btnXOA.Enabled = true;
            this.btnGHI.Enabled = false;

            this.btnRELOAD.Enabled = true;
            this.btnTHOAT.Enabled = true;
            this.btnCANCEL.Enabled = false;
            this.btnSUA.Enabled = true;
            bdsKhuChuaTri.RemoveCurrent();
            panelKhuChuaTri.Enabled = false;
        }
        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnRELOAD.Enabled = false;
            this.btnTHOAT.Enabled = false;
            this.btnCANCEL.Enabled = true;
            this.btnSUA.Enabled = false;
            panelKhuChuaTri.Enabled = true;
            kiemTraThemKhuChua = false;
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnRELOAD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHUCHUATRITableAdapter.Update(this.qLBVDataSet.KHUCHUATRI);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
            }
        }




        private void sỬAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc sửa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                try
                {

                    this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHUCHUATRITableAdapter.Update(this.qLBVDataSet.KHUCHUATRI);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK);
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa CHỨC VỤ. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);

                    return;
                }
            }
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                bdsPhong.AddNew();
                panelPhong.Enabled = true;
                this.btnThemPhong.Enabled = false;
                this.btnXoaPhong.Enabled =false;
                this.btnGhiPhong.Enabled = true;
                this.btnSuaPhong.Enabled =false;
                this.btnCancelPhong.Enabled = true;

                kiemtraThemPhong = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm phòng" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private bool KiemTraPhong()
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Không đc để trống mã Phòng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            /*if (Regex.IsMatch(txtMaPhong.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã phòng chỉ gồm chữ và số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            */
            if (txtSoPhong.Text == "")
            {
                MessageBox.Show("Không đc để trống số Phòng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            
            if (Regex.IsMatch(txtSoPhong.Text, @"^[0-9 ]+$") == false)
            {
                MessageBox.Show("Số phòng chỉ gồm số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            

            return true;
        }

        private void btnGhiPhong_Click(object sender, EventArgs e)
        {

            int KETQUA = 0;
            if(KiemTraPhong() == false)
            {
                return;
            }    
            
            if(kiemtraThemPhong == true)
            {
                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaPhong '" + txtMaPhong.Text.Trim() + "' " + "select 'Value' =  @kq";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(truyvan);
                    if (Program.myReader == null)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.myReader.Read();
                KETQUA = int.Parse(Program.myReader.GetValue(0).ToString());

                Program.myReader.Close();
            }

            if (KETQUA == 1)
            {
                MessageBox.Show("Mã phòng đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);

                return;

            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {

                        this.bdsPhong.EndEdit();
                        this.pHONGTableAdapter.Update(this.qLBVDataSet.PHONG);

                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                        panelPhong.Enabled = false;
                        this.btnThemPhong.Enabled = true;
                        this.btnXoaPhong.Enabled = true;
                        this.btnGhiPhong.Enabled = false;
                        this.btnSuaPhong.Enabled = true;
                        this.btnCancelPhong.Enabled = false;

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("lỗi khi ghi  phòng", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (bdsGiuong.Count > 0)
            {
                MessageBox.Show("Đã tồn tại giường không thể xóa phòng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            //kiem tra phong
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                try
                {
                    bdsPhong.RemoveCurrent();
                    this.pHONGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.pHONGTableAdapter.Update(this.qLBVDataSet.PHONG);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                  
                    panelPhong.Enabled = false;
                    this.btnThemPhong.Enabled = true;
                    this.btnXoaPhong.Enabled = true;
                    this.btnGhiPhong.Enabled = false;
                    this.btnSuaPhong.Enabled = true;
                    this.btnCancelPhong.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phòng. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            try
            {
               

                panelPhong.Enabled = true;
                this.btnThemPhong.Enabled = false;
                this.btnXoaPhong.Enabled = false;
                this.btnGhiPhong.Enabled = true;
                this.btnSuaPhong.Enabled = false;
                this.btnCancelPhong.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi  sửa phòng. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnCancelPhong_Click(object sender, EventArgs e)
        {

            try
            {
                bdsPhong.RemoveCurrent();
                panelPhong.Enabled = false;
                this.btnThemPhong.Enabled = true;
                this.btnXoaPhong.Enabled = true;
                this.btnGhiPhong.Enabled = false;
                this.btnSuaPhong.Enabled = true;
                this.btnCancelPhong.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hủy chức năng phòng. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void pHONGGridControl_Click(object sender, EventArgs e)
        {
            
        }

        private void context_Opening(object sender, CancelEventArgs e)
        {
            if (bdsPhong.Count > 0)
            {
                btnXoaPhong.Enabled = true;
                btnSuaPhong.Enabled = true;
            }
            else if (bdsPhong.Count == 0)
            {
                btnXoaPhong.Enabled = false;
                btnSuaPhong.Enabled = false;
            }
        }
    }
}