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
    public partial class formCHUCVUvaNHANVIEN : DevExpress.XtraEditors.XtraForm
    {

        bool kiemtraThemMoi = false;// chức vụ
        bool kiemTraThemMoiNhanVien = false;// nhân viên
        public formCHUCVUvaNHANVIEN()
        {
            InitializeComponent();
        }

      
        private void cHUCVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsChucVu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBVDataSet);

        }

        private void formCHUCVUvaNHANVIEN_Load(object sender, EventArgs e)
        {
            this.qLBVDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETLAMVIECKHUCHUATRI' table. You can move, or remove it, as needed.
            this.cHITIETLAMVIECKHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHITIETLAMVIECKHUCHUATRITableAdapter.Fill(this.qLBVDataSet.CHITIETLAMVIECKHUCHUATRI);
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETCHUATRI' table. You can move, or remove it, as needed.
            this.cHITIETCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHITIETCHUATRITableAdapter.Fill(this.qLBVDataSet.CHITIETCHUATRI);
            // TODO: This line of code loads data into the 'qLBVDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bENHNHANTableAdapter.Fill(this.qLBVDataSet.BENHNHAN);
            // TODO: This line of code loads data into the 'qLBVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.qLBVDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'qLBVDataSet.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUCVUTableAdapter.Fill(this.qLBVDataSet.CHUCVU);
            this.cbbPhai.Items.Add("Nam");
            this.cbbPhai.Items.Add("Nữ");
            cbbPhai.SelectedIndex = 0;

           
            panelNhanVien.Enabled = false;
            panelChucVu.Enabled = false;

        }

        
        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsChucVu.AddNew();
                btnTHEM.Enabled = false;
                btnSUA.Enabled = false;
                this.btnXoaCV.Enabled = false;
                this.btnGHI.Enabled = true;
                this.btnCANCEL.Enabled = true;
                this.btnRELOAD.Enabled = false;
                this.btnTHOAT.Enabled = false;

                this.panelNhanVien.Enabled = false;


                panelChucVu.Enabled = true;
                kiemtraThemMoi = true;
                /*txtMaNV.Enabled = false;
                txtTen.Enabled = false;
                txtHo.Enabled = false;
                cbbPhai.Enabled = false;
                txtDiaChi.Enabled = false;
                txtDienThoai.Enabled = false;
                txtCCCD.Enabled = false;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chúc vụ " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }

        }
        private bool KiemTraNhanVien()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Không được để trống Mã nhân viên ", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtMaNV.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("MÃ NHÂN VIÊN chỉ có chữ cái và số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return false;
            }*/

            if (txtHo.Text == "")
            {
                MessageBox.Show("Không được để trống Họ ", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return false;
            }
            /*
            if (Regex.IsMatch(txtHo.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Họ chỉ có chữ cái", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }*/
            if (txtTen.Text == "")
            {
                MessageBox.Show("Không được để trống Tên ", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtTen.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Tên chỉ có chữ cái", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }*/
            
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Không được để trống địa chỉ ", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtDiaChi.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }*/

            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Không được để trống điện thoại ", "Thông báo", MessageBoxButtons.OK);
                txtDienThoai.Focus();
                return false;
            }
            if (Regex.IsMatch(txtDienThoai.Text, @"^[0-9 ]+$") == false)
            {
                MessageBox.Show("điện thoại chỉ có số", "Thông báo", MessageBoxButtons.OK);
                txtDienThoai.Focus();
                return false;
            }


            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Không được để trống căn cước công dân ", "Thông báo", MessageBoxButtons.OK);
                txtCCCD.Focus();
                return false;
            }
            if (Regex.IsMatch(txtCCCD.Text, @"^[0-9 ]+$") == false)// phải cho kahnưgs
            {
                MessageBox.Show("căn cước công dân chỉ có số", "Thông báo", MessageBoxButtons.OK);
                txtCCCD.Focus();
                return false;
            }
            return true;
        }
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int KETQUA = 0;
            if (KiemTraChucVu() == false)
            {
                return;
            }

            if(kiemtraThemMoi == true)
            {
                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaChucVu '" + txtMaChucVu.Text.Trim() + "' " + "select 'Value' =  @kq";
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
                MessageBox.Show("Mã Chức vụ  đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);

                return;

            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {

                    this.bdsChucVu.EndEdit();
                    this.cHUCVUTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cHUCVUTableAdapter.Update(this.qLBVDataSet.CHUCVU);

                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    btnTHEM.Enabled = btnXoaCV.Enabled = btnRELOAD.Enabled= btnSUA.Enabled = true;
                    btnGHI.Enabled = btnTHOAT.Enabled = false;
                    btnCANCEL.Enabled = false;
                    txtMaChucVu.Enabled = txtTenChucVu.Enabled = true;
                    kiemtraThemMoi = false;
                    panelNhanVien.Enabled = false;
                }
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnRELOAD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cHUCVUTableAdapter.Update(this.qLBVDataSet.CHUCVU);
                btnTHEM.Enabled = btnXoaCV.Enabled = btnRELOAD.Enabled = btnSUA.Enabled = true;
                btnGHI.Enabled = btnTHOAT.Enabled = true;
                btnCANCEL.Enabled = false;
                panelChucVu.Enabled = false;

                this.panelNhanVien.Enabled = false;
                //this.gridControlMonHoc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelChucVu.Enabled = true;
            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXoaCV.Enabled = false;
            this.btnGHI.Enabled = true;
            this.btnCANCEL.Enabled = true;
            this.btnRELOAD.Enabled = false;
            this.btnTHOAT.Enabled = false;
            kiemtraThemMoi = false;

        }

        

       

        private void xÓACHỨCVỤToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
        }
        private bool KiemTraChucVu()
        {
            if(txtMaChucVu.Text == "")
            {
                MessageBox.Show("Không đc để trống mã chức vụ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
           
           /* if (Regex.IsMatch(txtMaChucVu.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã chức vụ chỉ gồm chữ và số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }*/
            if (txtTenChucVu.Text == "")
            {
                MessageBox.Show("Không đc để trống tên chức vụ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            /*
            if (Regex.IsMatch(txtTenChucVu.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Mã chức vụ chỉ gồm chữ và số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }*/
            return true;
        }
      

        private void btnCANCEL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnTHEM.Enabled = true;
            this.btnXoaCV.Enabled = true;
            this.btnGHI.Enabled = false;
            this.btnSUA.Enabled = true;
            this.btnRELOAD.Enabled = true;
            this.btnTHOAT.Enabled = true;
            panelChucVu.Enabled = false;
            bdsChucVu.RemoveCurrent();
        }

        private void bdsBenhNhan_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cHUCVUBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsChucVu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBVDataSet);

        }
        // xóa chức vụ
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsNhanVien.Count > 0)
            {
                MessageBox.Show("Đã tồn tại nhân viên , không thể xóa chức vụ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string macv = "";
                try
                {
                    macv = ((DataRowView)bdsChucVu[bdsChucVu.Position])["MACV"].ToString();// lưu lại
                    bdsChucVu.RemoveCurrent();


                    this.cHUCVUTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cHUCVUTableAdapter.Update(this.qLBVDataSet.CHUCVU);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);

                    this.btnTHEM.Enabled = true;
                    this.btnXoaCV.Enabled = true;
                    this.btnGHI.Enabled = false;
                    this.btnSUA.Enabled = true;
                    this.btnRELOAD.Enabled = true;
                    this.btnTHOAT.Enabled = true;
                    panelChucVu.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chức vụ. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.cHUCVUTableAdapter.Update(this.qLBVDataSet.CHUCVU);
                    bdsChucVu.Position = bdsNhanVien.Find("MACV", macv);
                    return;
                }
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                bdsNhanVien.AddNew();
                panelChucVu.Enabled = false;
                panelNhanVien.Enabled = true;
                
                    btnThemNV.Enabled = false;
                    btnCancelNV.Enabled = true;
                    btnGhiNV.Enabled = true;
                    btnXoaNV.Enabled = false;
                    btnSuaNV.Enabled = false;
            

                // kiểm tra trước khi ghi là nút thêm hay sửa
                kiemTraThemMoiNhanVien = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên"+ ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        
        private void btnGhiNV_Click(object sender, EventArgs e)
        {
            int KETQUA = 0;
            if (KiemTraNhanVien() == false)
            {
                return;
            }

            // kiểm tra 

            if(kiemTraThemMoiNhanVien == true)
            {
                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaNhanVien '" + txtMaNV.Text.Trim() + "' " + "select 'Value' =  @kq";
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
                MessageBox.Show("Nhân viên  đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);

                return;

            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {

                    this.bdsNhanVien.EndEdit();
                    this.nHANVIENTableAdapter.Update(this.qLBVDataSet.NHANVIEN);

                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    panelNhanVien.Enabled = false;

                    btnThemNV.Enabled = true;
                    btnCancelNV.Enabled = false;
                    btnGhiNV.Enabled = false;
                    btnXoaNV.Enabled = true;
                    btnSuaNV.Enabled = true;
                }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (bdsBenhNhan.Count > 0)
            {

                MessageBox.Show("Không thể xóa nhân viên này vì đã có bệnh nhân ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsChiTietChuaTri.Count > 0)
            {

                MessageBox.Show("Không thể xóa nhân viên này vì đã có chi tiết chữa trị ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsChiTietLamViec.Count > 0)
            {

                MessageBox.Show("Không thể xóa nhân viên này vì đã có chi tiết làm việc tại khu chữa trị ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string manv = "";
                try
                {
                   
                    bdsNhanVien.RemoveCurrent();


                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHANVIENTableAdapter.Update(this.qLBVDataSet.NHANVIEN);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    panelNhanVien.Enabled = false;
                    btnThemNV.Enabled = true;
                    btnCancelNV.Enabled = false;
                    btnGhiNV.Enabled = false;
                    btnXoaNV.Enabled = true;
                    btnSuaNV.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Nhân Viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    
                    return;
                }
            }

        }

        private void btnCancelNV_Click(object sender, EventArgs e)
        {
            bdsNhanVien.RemoveCurrent();
            panelNhanVien.Enabled=false;
            btnThemNV.Enabled = true;
            btnCancelNV.Enabled = false;
            btnGhiNV.Enabled = false;
            btnXoaNV.Enabled = true;
            btnSuaNV.Enabled = true;
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            panelNhanVien.Enabled = true;
            // thực hiện các nút kia
            btnThemNV.Enabled = false;
            btnCancelNV.Enabled = true;
            btnGhiNV.Enabled = true;
            btnXoaNV.Enabled = false;
            btnSuaNV.Enabled = false;

            kiemTraThemMoiNhanVien = false;
        }

        private void formCHUCVUvaNHANVIEN_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsNhanVien.Count > 0)
            {
                btnXoaNV.Enabled = true;
                btnSuaNV.Enabled = true;
            }
            else if(bdsNhanVien.Count == 0)
            {
                btnXoaNV.Enabled = false;
                btnSuaNV.Enabled = false;
            }
        }

        private void nHANVIENGridControl_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (bdsNhanVien.Count > 0)
            {
                btnXoaNV.Enabled = true;
                btnSuaNV.Enabled = true;
            }
            else if (bdsNhanVien.Count == 0)
            {
                btnXoaNV.Enabled = false;
                btnSuaNV.Enabled = false;
            }
        }
    }
}