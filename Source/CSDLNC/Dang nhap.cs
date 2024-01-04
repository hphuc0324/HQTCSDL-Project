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
 
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=QLPHONGKHAMNHAKHOA2;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
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
            con.Open();
           
            SqlCommand cmd = new SqlCommand("sp_checkLogin", con);
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

            if(userID != "" && userType != "")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
            }

    

            MessageBox.Show(userID + " " + userType);

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
