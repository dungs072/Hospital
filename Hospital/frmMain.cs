using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private frmProvidePrivilege providePrivilege;
        public frmMain()
        {
            InitializeComponent();
            frmProvidePrivilege.OnHasPrivilege += OnHasPrivilege;
        }
        public void ShowMenu()
        {
            id.Text = "Mã nhân viên = " + Program.userName;
            fullname.Text = "Họ và tên = " + Program.mFullName;
            group.Text = "Nhóm = " + Program.mGroup;
            btnBarLogin.Enabled = false;
            btnBarLogOut.Enabled = true;
            btnBarChangePassword.Enabled = true;
           
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void ShowForm(Type tForm)
        {
            Form frm = CheckExists(tForm);
            if (frm != null) frm.Activate();
            else
            {
                Form f;
                if (tForm == typeof(frmRegisterLivingRoom))
                {
                    f = new frmRegisterLivingRoom();
                }
                else if (tForm == typeof(frmCure))
                {
                    f = new frmCure();
                }
                else if (tForm == typeof(frmEquipmentDetail))
                {
                    f = new frmEquipmentDetail();
                }
                else if (tForm == typeof(frmAreaWorkingDetail))
                {
                    f = new frmAreaWorkingDetail();
                }
                else if (tForm == typeof(frmUsingEquipment))
                {
                    f = new frmUsingEquipment();
                }
                else if (tForm == typeof(frmPatient))
                {
                    f = new frmPatient();
                }
                else if (tForm == typeof(frmEquipment))
                {
                    f = new frmEquipment();
                }
                else if(tForm == typeof(frmTreatment))
                {
                    f = new frmTreatment();
                }
                else if (tForm == typeof(frmLeaderNurse))
                {
                    f = new frmLeaderNurse();
                }
                else if (tForm == typeof(frmDoctor))
                {
                    f = new frmDoctor();
                }
                else if (tForm == typeof(frmNurse))
                {
                    f = new frmNurse();
                }
                else if (tForm == typeof(frmBed))
                {
                    f = new frmBed();
                }
                else if (tForm == typeof(frmRoomAndArea))
                {
                    f = new frmRoomAndArea();
                }
                else if (tForm == typeof(frmTheoDoiBenhNhan))
                {
                    f = new frmTheoDoiBenhNhan();
                }
                else if (tForm == typeof(frmTaoTK))
                {
                    f = new frmTaoTK();
                }
                else if (tForm == typeof(frmXoaTaiKhoan))
                {
                    f = new frmXoaTaiKhoan();
                }
                else if (tForm == typeof(frmChangePassword))
                {
                    f = new frmChangePassword();
                }
                else
                {
                    f = new frmLogin();
                }
                f.MdiParent = this;
                f.Show();
                if (Program.mGroup == "Boss")
                {
                    if(f is IBoss)
                    {
                        IBoss boss = f as IBoss;
                        boss.InitialSetting();
                    }
                }
            }
        }

        private void btnBarLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmLogin));
        }

        private void btnBarRegisterLivingRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmRegisterLivingRoom));
        }
        private void btnBarCure_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmCure));
        }
        private void btnBarUsingEquipment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmEquipmentDetail));
        }
        private void btnBarRegisterArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmAreaWorkingDetail));
        }
        private void btnBarUsingEquip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmUsingEquipment));
        }
        private void btnBarPatient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmPatient));
        }
        private void btnBarEquipment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmEquipment));
        }
        private void btnBarTreatment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmTreatment));
        }
        private void btnBarUsingEquipNurse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmEquipmentDetail));
        }

        private void btnBarRegisterLivingRoomNurse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmRegisterLivingRoom));
        }
        private void btnBarRegisterLeaderNurse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmLeaderNurse));
        }
        private void btnBarDoctor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmDoctor));
        }
        private void btnBarNurse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmNurse));
        }
        private void btnBarAreaAndRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmRoomAndArea));
        }
        private void btnBarBed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmBed));
        }
        private void btnBarRegisterStalkDoctor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmTheoDoiBenhNhan));
        }
        private void btnBarCreateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmTaoTK));
        }
        private void btnBarDeleteAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmXoaTaiKhoan));
        }
        private void btnBarChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(frmChangePassword));
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowForm(typeof(frmLogin));
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
            ribbonPage4.Visible = false;
            ribbonPage5.Visible = false;
            ribbonPage6.Visible = false;
            btnBarLogOut.Enabled = false;
            btnBarCreateAccount.Enabled = false;
            btnBarDeleteAccount.Enabled = false;
            btnBarChangePassword.Enabled = false;
        }

        public void LoginByBossRole()
        {
            ribbonPage2.Visible = true;
            ribbonPage3.Visible = true;
            ribbonPage4.Visible = true;
            ribbonPage5.Visible = false;
            btnBarCreateAccount.Enabled = true;
            btnBarDeleteAccount.Enabled = true;
            ribbonControl1.SelectedPage = ribbonPage2;
            CloseAllFormCurrentlyOpen();
        }

        public void LoginByHospitalRole()
        {
            ribbonPage2.Visible = true;
            ribbonPage3.Visible = true;
            ribbonPage4.Visible = true;
            ribbonPage5.Visible = false;
            ribbonPage6.Visible = true;
            btnBarCreateAccount.Enabled = true;
            btnBarDeleteAccount.Enabled = true;
            ribbonControl1.SelectedPage = ribbonPage2;
            CloseAllFormCurrentlyOpen();
        }
        public void LoginByDoctorRole()
        {
            ribbonPage3.Visible = true;
            ribbonPage5.Visible = false;
            ribbonControl1.SelectedPage = ribbonPage3;
            CloseAllFormCurrentlyOpen();
        }
        public void LoginByNurseRole()
        {
            ribbonPage5.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage5;
            CloseAllFormCurrentlyOpen();
        }
        private void CloseAllFormCurrentlyOpen()
        {
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
        }
        private void btnBarLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonPage2.Visible = false;
            ribbonPage3.Visible = false;
            ribbonPage4.Visible = false;
            ribbonPage5.Visible = false;
            ribbonPage6.Visible = false;
            btnBarLogin.Enabled = true;
            btnBarLogOut.Enabled = false;
            btnBarCreateAccount.Enabled = false;
            btnBarDeleteAccount.Enabled = false;
            btnBarChangePassword.Enabled = false;
            LogOff();
            btnBarUsingEquip.Enabled = true;
            btnBarRegisterArea.Enabled = true;
            CloseAllFormCurrentlyOpen();
            ShowForm(typeof(frmLogin));
            id.Text = "Mã nhân viên = None" ;
            fullname.Text = "Họ và tên = None";
            group.Text = "Nhóm = None" ;
        }
        private void LogOff()
        {
            Program.conn.Close();
        }

        private void btnBarBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            providePrivilege = new frmProvidePrivilege(true);
            providePrivilege.StartPosition = FormStartPosition.CenterScreen;
            providePrivilege.ShowDialog();
          
        }

        private void btnBarRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            providePrivilege = new frmProvidePrivilege(false);
            providePrivilege.StartPosition = FormStartPosition.CenterScreen;
            providePrivilege.ShowDialog();

        }
        
        private void OnHasPrivilege(bool isBackup)
        {
            providePrivilege.Close();
            if(isBackup)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save File"; // Set the dialog title
                saveFileDialog.Filter = "Bak Files (*.bak)|*.bak|All Files (*.*)|*.*"; // Specify the file filter
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFilePath = saveFileDialog.FileName;
                    if (Program.Connect() == 0) { return; }
                    string cmd = string.Format("EXEC BACK_UP_DATABASE '{0}'", selectedFilePath);
                    int resultl = Program.ExecSqlNonQuery(cmd);
                    if (resultl == 0)
                    {
                        MessageBox.Show("Sao lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sao lưu dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select File"; // Set the dialog title
                openFileDialog.Filter = "Text Files (*.bak)|*.bak|All Files (*.*)|*.*"; // Specify the file filter

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    int resultl = KillAllSessionsAndRestoreWithPrivilege(selectedFilePath);
                    //int resultl = RestoreWithPrivilege(selectedFilePath);
                    if (resultl == 0)
                    {
                        MessageBox.Show("Phục hồi dữ liệu thành công.\nChương trình sẽ tự động khởi động lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Phục hồi dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        
        private int KillAllSessionsAndRestoreWithPrivilege(string selectedFilePath)
        {
            // Create a connection string
            string connectionString = string.Format("Server={0};Database={1};User Id=sa;Password=123;", Program.serverName, Program.database);

            // Create a SqlConnection object
            SqlConnection connection = new SqlConnection(connectionString);

            string cmd = "SELECT * FROM GET_SESSIONS";
            SqlCommand sqlCmd = new SqlCommand(cmd, connection);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandTimeout = 600;//10 mins
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
            try
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                string killStatements = string.Empty;
                while (reader.Read())
                {
                    int sessionId = reader.GetInt16(0);
                    killStatements += $"KILL {sessionId};\n";
                }
                reader.Close();
                
                string commandStr = killStatements+string.Format(" USE master; EXEC RESTORE_DATABASE '{0}'", selectedFilePath);
                sqlCmd = new SqlCommand(commandStr, connection);
                sqlCmd.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return ex.State + 1;
            }
        }
    }
}
