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

namespace Hospital
{
    public partial class frmGiuong : DevExpress.XtraEditors.XtraForm
    {
        bool kiemTraThemMoi = false;
        public frmGiuong()
        {
            InitializeComponent();
        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBVDataSet);

        }

        private void frmGiuong_Load(object sender, EventArgs e)
        {
            this.qLBVDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLBVDataSet.CHITIETO' table. You can move, or remove it, as needed.
            this.cHITIETOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHITIETOTableAdapter.Fill(this.qLBVDataSet.CHITIETO);

            // TODO: This line of code loads data into the 'qLBVDataSet.GIUONG' table. You can move, or remove it, as needed.
            this.gIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIUONGTableAdapter.Fill(this.qLBVDataSet.GIUONG);
            // TODO: This line of code loads data into the 'qLBVDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Connection.ConnectionString= Program.connstr;
            this.pHONGTableAdapter.Fill(this.qLBVDataSet.PHONG);


            pcGiuong.Enabled = false;
        }

        

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsGiuong.AddNew();
                kiemTraThemMoi = true;
                pcGiuong.Enabled = true;

                btnTHEM.Enabled = false;
                btnGHI.Enabled = true;
                btnCANCEL.Enabled = true;
                btnRELOAD.Enabled = false;
                btnTHOAT.Enabled = false;
                btnSUA.Enabled = false;
                btnXOA.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm giường", "Warning", MessageBoxButtons.OK);
                return;
            }
        }

        private bool KiemTraGiuong()
        {
            if(txtMaGiuong.Text.Length == 0) {
                MessageBox.Show("MÃ giường không được để trống", "Warning", MessageBoxButtons.OK);
                return false;
            }
            if(txtSoGiuong.Text.Length == 0)
            {
                MessageBox.Show("Số giường không được để trống", "Warning", MessageBoxButtons.OK);
                return false;

            }

            return true;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ketqua = 0;
            if(KiemTraGiuong()== false)
            {
                return;
            }    

            // kiểm tra mã giường
           if(kiemTraThemMoi == true)
            {
                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaGiuong '" + txtMaGiuong.Text.Trim() + "' " + "select 'Value' =  @kq";
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
                ketqua = int.Parse(Program.myReader.GetValue(0).ToString());

                Program.myReader.Close();

            }    


            if(ketqua == 1)
            {
                MessageBox.Show("Mã giường đã bị trùng hãy thử lại", "Warning", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {

                        this.bdsGiuong.EndEdit();
                        this.gIUONGTableAdapter.Update(this.qLBVDataSet.GIUONG);

                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                        kiemTraThemMoi = false;
                        pcGiuong.Enabled = false;

                        btnTHEM.Enabled = true;
                        btnGHI.Enabled = false;
                        btnCANCEL.Enabled = false;
                        btnRELOAD.Enabled = true;
                        btnTHOAT.Enabled = true;
                        btnSUA.Enabled = true;
                        btnXOA.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi khi ghi giường" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsChiTietO.Count > 0)
            {
                MessageBox.Show("Không thể xóa giường vì đã có chi tiết ở", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            //kiem tra phong
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                try
                {
                    bdsGiuong.RemoveCurrent();
                    this.gIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIUONGTableAdapter.Update(this.qLBVDataSet.GIUONG);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);

                    pcGiuong.Enabled = false;
                    btnTHEM.Enabled = true;
                    btnGHI.Enabled = false;
                    btnCANCEL.Enabled = false;
                    btnRELOAD.Enabled = true;
                    btnTHOAT.Enabled = true;
                    btnSUA.Enabled = true;
                    btnXOA.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giường. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pcGiuong.Enabled = true;
                kiemTraThemMoi = false;

                btnTHEM.Enabled = false;
                btnGHI.Enabled = true;
                btnCANCEL.Enabled = true;
                btnRELOAD.Enabled = false;
                btnTHOAT.Enabled = false;
                btnSUA.Enabled = false;
                btnXOA.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi sửa giường, Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnRELOAD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCANCEL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsGiuong.RemoveCurrent();
                pcGiuong.Enabled = false;
                btnTHEM.Enabled = true;
                btnGHI.Enabled = false;
                btnCANCEL.Enabled = false;
                btnRELOAD.Enabled = true;
                btnTHOAT.Enabled = true;
                btnSUA.Enabled = true;
                btnXOA.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hủy chức năng giường. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}