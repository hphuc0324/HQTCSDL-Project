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
            loadAppointmentList();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLichHen addAppointForm = new AddLichHen(this.MaBn);
            IntermediateFunctions.openNewForm(this, addAppointForm);
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

            IntermediateFunctions.con.Open();

            string query2 = "SELECT MATKHAU FROM TAIKHOAN WHERE SDT = @sdt";
            SqlCommand cmd2 = new SqlCommand(query2, IntermediateFunctions.con);

            cmd2.Parameters.AddWithValue("@sdt", currUsernameBox.Text);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.HasRows)
            {
                reader2.Read();

                currPasswordBox.Text = reader2.GetString(reader2.GetOrdinal("MATKHAU"));
            }
            IntermediateFunctions.con.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("sp_updatePatientInfo", IntermediateFunctions.con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", this.MaBn);
            cmd.Parameters.AddWithValue("@sdt", currUsernameBox.Text);
            cmd.Parameters.AddWithValue("@pass", currPasswordBox.Text);
            cmd.Parameters.AddWithValue("@hoten", currNameBox.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", currDobBox.Text);
            cmd.Parameters.AddWithValue("@diachi", currAddressBox.Text);

            int row = cmd.ExecuteNonQuery();
            if(row > 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                IntermediateFunctions.con.Close();
                loadPatientInfo();
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể cập nhật");
                IntermediateFunctions.con.Close();
            }

           
        }

        private void loadAppointmentList()
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LICHHEN WHERE MaBNHen = @MaBN ", IntermediateFunctions.con);
            cmd.Parameters.AddWithValue("@MaBN", this.MaBn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            appointmentList.DataSource = dt;


            IntermediateFunctions.con.Close();


            IntermediateFunctions.con.Open();
            string query = "SELECT * FROM BENHNHAN WHERE MaBN = @MaBN";
            SqlCommand cmd2 = new SqlCommand(query, IntermediateFunctions.con);




            cmd2.Parameters.AddWithValue("@MaBN", this.MaBn);

            SqlDataReader reader = cmd2.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                patientBox.Text = reader.GetString(reader.GetOrdinal("BNHoten"));
                phoneBox.Text = reader.GetString(reader.GetOrdinal("BNSdt"));
                DateTime ngaysinh = reader.GetDateTime(reader.GetOrdinal("BNNgaysinh"));
                dobBox.Text = ngaysinh.ToString("MM-dd-yyyy");
                addressBox.Text = reader.GetString(reader.GetOrdinal("BNDiachi"));
            }
            IntermediateFunctions.con.Close();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            loadAppointmentList();
        }

        private void appointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            appointmentList.CurrentRow.Selected = true;
            dentistBox.Text = appointmentList.Rows[e.RowIndex].Cells["MaNSHen"].Value.ToString();
            timeBox.Text = appointmentList.Rows[e.RowIndex].Cells["ThoiGian"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HSBA_V hsbaViewForm = new HSBA_V(this.MaBn);
            IntermediateFunctions.openNewForm(this, hsbaViewForm);
        }
    }
}
