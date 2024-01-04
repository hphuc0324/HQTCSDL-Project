using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC
{
    public partial class LoginForm : Form
    {
        private string userID = "";
        private string userType = "";

        public static LoginForm Instance;
 
        public LoginForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntermediateFunctions.con.Open();
           
            SqlCommand cmd = new SqlCommand("sp_checkLogin", IntermediateFunctions.con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter typePara = new SqlParameter("@type", SqlDbType.VarChar, 5);
            typePara.Direction = ParameterDirection.Output;
            SqlParameter userIdPara = new SqlParameter("@id", SqlDbType.VarChar, 20);
            userIdPara.Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@sdt", sdtBox.Text);
            cmd.Parameters.AddWithValue("@pass", passBox.Text);
            cmd.Parameters.Add(typePara);
            cmd.Parameters.Add(userIdPara);
            cmd.ExecuteNonQuery();

            userID = userIdPara.Value.ToString();
            userType = typePara.Value.ToString();
            IntermediateFunctions.con.Close();

            if (userID != "" && userType != "")
            {
                MessageBox.Show("Đăng nhập thành công");
                //đăng nhập vào login của SQL
                matchUserForm(userType, userID);
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
            }


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            IntermediateFunctions.openNewForm(this, registerForm);      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void matchUserForm(string type, string id)
        {
            switch (type)
            {
                case "BN":
                    KhachHang formKhachHang = new KhachHang(id);
                    IntermediateFunctions.openNewForm(this, formKhachHang);
                    break;
                case "NV":
                    NhanVien formNhanVien = new NhanVien();
                    IntermediateFunctions.openNewForm(this, formNhanVien);
                    break;
                case "NS":
                    Nhasi formNhasi = new Nhasi();
                    IntermediateFunctions.openNewForm(this, formNhasi);
                    break;
                case "QTV":
                    QuanTriVien formQuanTriVien = new QuanTriVien();
                    IntermediateFunctions.openNewForm(this, formQuanTriVien);
                    break;
                default:
                    MessageBox.Show("Lỗi: Không tìm được loại tài khoản tương ứng");
                    break;
            }
        }
    }
}
