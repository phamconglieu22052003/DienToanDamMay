using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_máy_tính
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
                FormNhaCungCap frmNCC = new FormNhaCungCap(); //Khởi tạo đối tượng
                frmNCC.ShowDialog(); //Hiển thị

        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            FormDMHangHoa frmHangHoa = new FormDMHangHoa();
            this.Parent = this;
            frmHangHoa.Show();
        }
    }
}
