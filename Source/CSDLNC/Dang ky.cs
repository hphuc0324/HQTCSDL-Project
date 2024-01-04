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
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=QLPHONGKHAMNHAKHOA2;Integrated Security=True");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string getNewID(string tableName, string idField)
        {
            string query = $"SELECT TOP 1 * FROM {tableName} ORDER BY {idField} DESC";
            SqlCommand cmd = new SqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.Read()) return "";

                string currUserID = reader[idField].ToString();

                int index = 0;
                while (index < currUserID.Length && char.IsLetter(currUserID[index]))
                {
                    index++;
                }

                string letters = currUserID.Substring(0, index);


                // Extract numbers (suffix)
                string numbersString = currUserID.Substring(2);
                int numbers = int.Parse(numbersString) + 1;

                return letters + numbers;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_register", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sdt", sdtBox.Text);
                cmd.Parameters.AddWithValue("@pass", passwordBox.Text);
                cmd.Parameters.AddWithValue("@mabn", IntermediateFunctions.getNewID("BENHNHAN", "MaBN"));
                cmd.Parameters.AddWithValue("@hoten", nameBox.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dobBox.Text);
                cmd.Parameters.AddWithValue("@diachi", addressBox.Text);

                int row = cmd.ExecuteNonQuery();

                if (row <= 0)
                {
                    MessageBox.Show("Lỗi: Số điện thoại đã tồn tại hoặc có thông tin bị thiếu\n");
                }
                else
                {
                    MessageBox.Show("Đăng ký thành công");
                }
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không thể đăng ký\n" + ex.ToString());
                con.Close();
            }
            
           
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            LoginForm loginForm = new LoginForm();
            IntermediateFunctions.openNewForm(this, loginForm);
        }
    }
}
