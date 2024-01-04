using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDLNC
{
    public partial class KhachHang : Form
    {
        private string MaBn = "";
        public KhachHang(string id)
        {
            InitializeComponent();
            MaBn = id;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            loadPatientInfo();
        }

        private void loadPatientInfo()
        {
            IntermediateFunctions.con.Open();
            string query = "SELECT * FROM BENHNHAN WHERE MaBN = @MaBN";
            SqlCommand cmd = new SqlCommand(query, IntermediateFunctions.con);

            cmd.Parameters.AddWithValue("@MaBN", this.MaBn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                currIDBox.Text = this.MaBn;
                currNameBox.Text = reader.GetString(reader.GetOrdinal("BNHoten"));
                currUsernameBox.Text = reader.GetString(reader.GetOrdinal("BNSdt"));
                DateTime ngaysinh = reader.GetDateTime(reader.GetOrdinal("BNNgaysinh"));
                currDobBox.Text = ngaysinh.ToString("dd-MM-yyyy");
                currAddressBox.Text = reader.GetString(reader.GetOrdinal("BNDiachi"));
            }

            IntermediateFunctions.con.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
