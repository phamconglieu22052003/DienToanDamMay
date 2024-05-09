using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;


internal class Functions
{
    public static string chuoiketnoi = @"Data Source=localhost\SQLEXPRESS08;Initial Catalog=QuanLyBanMayTinh;Integrated Security=True;Encrypt=False";
    public static SqlConnection Con;  //Khai báo đối tượng kết nối        

    public static void Connect()
    {
        Con = new SqlConnection();   //Khởi tạo đối tượng
        Con.ConnectionString = chuoiketnoi; // Sử dụng chuỗi kết nối đã khai báo
        //Kiểm tra kết nối
        try
        {
            Con.Open(); // Mở kết nối
            MessageBox.Show("Kết nối thành công");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không thể kết nối với dữ liệu: " + ex.Message);
        }
    }

    public static void Disconnect()
    {
        if (Con != null && Con.State == ConnectionState.Open)
        {
            Con.Close();    //Đóng kết nối
            Con.Dispose();  //Giải phóng tài nguyên
            Con = null;
        }
    }

    //Phương thức thực thi câu lệnh select lấy dữ liệuSystem.InvalidOperationException: 'Fill: SelectCommand.Connection property has not been initialized.'

    public static DataTable GetDataToTable(string sql)
    {
        DataTable table = new DataTable();
        using (SqlConnection connection = new SqlConnection(chuoiketnoi))
        {
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(table);
        }
        return table;
    }
}