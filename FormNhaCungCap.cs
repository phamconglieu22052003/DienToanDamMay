using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using Quản_lý_bán_máy_tính.Class; //Sử dụng class Functions.cs

namespace Quản_lý_bán_máy_tính
{
    public partial class FormNhaCungCap : Form
    {
        DataTable tblNCC; //Chứa dữ liệu bảng Chất liệu
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNCC, TenNCC FROM tblNCC";
            tblNCC =Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvNhaCungCap.DataSource = tblNCC; //Nguồn dữ liệu            
            dgvNhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNhaCungCap.Columns[0].Width = 100;
            dgvNhaCungCap.Columns[1].Width = 300;
            dgvNhaCungCap.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvNhaCungCap.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }
}
