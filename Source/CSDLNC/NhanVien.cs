using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace CSDLNC
{
    public partial class NhanVien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=QLPHONGKHAMNHAKHOA2;Integrated Security=True");
        private string currNVID = "";
        private string PatientIDSelected = "";
        private string DentistIDSelected = "";
        private string HoSoIDSelected = "";
        private string StaffIDSelected = "";
        private void refreshDataGrid(string tableName)
        {
            con.Open();
            string query = $"SELECT * FROM {tableName}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (tableName == "LICHHEN")
            {
                query = $"SELECT * FROM LICHHEN LH JOIN BENHNHAN BN ON LH.MaBNHen=BN.MaBN JOIN NHASI NS ON NS.MaNS=LH.MaNSHen";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (tableName == "HOSO")
            {
                query = $"SELECT MaHS,HSNgayKham,BNHoten,BNSdt,NSHoten\r\nFROM HOSO HS JOIN BENHNHAN BN ON BN.MaBN=HS.BNKham\r\nJOIN NHASI NS ON NS.MaNS=HS.NSKham";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            else if (tableName == "HOSO_DICHVU")
            {
                query = $"SELECT TenDV,PhiDichVu\r\nFROM HOSO HS JOIN HOSO_DICHVU HSDV ON HS.MaHS=HSDV.MaHSKham\r\nJOIN DICHVU DV ON DV.MaDV=HSDV.MaDVSuDung WHERE HS.MaHS=@MaHS";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaHS", this.HoSoIDSelected);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;

                tongPhiDV.Text = getTongPhiDV();
            }
            else if(tableName== "HOSO_THUOC")
            {
                query = $"SELECT TenThuoc,DonViTinh,ChiDinh,NgayHetHan\r\nFROM HOSO HS JOIN HOSO_THUOC HST ON HS.MaHS=HST.MaHSKham\r\nJOIN THUOC T ON T.MaThuoc=HST.MaThuocChiDinh";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;
                tongPhiThuoc.Text = "0";
            }
            

            con.Close();
        }
        private string getTongPhiDV()
        {        
            

            try
            {
                // Call the sp_GetSumPhiDichVu stored procedure
                using (SqlCommand cmd = new SqlCommand("sp_GetSumPhiDichVu", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHS", this.HoSoIDSelected);

                    // Define output parameter
                    SqlParameter sumPhiDichVuParam = new SqlParameter("@SumPhiDichVu", SqlDbType.Int);
                    sumPhiDichVuParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(sumPhiDichVuParam);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    // Retrieve the output parameter value
                    int sumPhiDichVu = (int)sumPhiDichVuParam.Value;
                    return sumPhiDichVu.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return "";
            }
            
        }


        public NhanVien(string currNVID = "US101") // Nho doi cai nay
        {
            InitializeComponent();
            refreshDataGrid("LICHHEN");
            refreshDataGrid("HOSO");

            this.currNVID = currNVID;
            
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
       
        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }       


        private void button1_Click_1(object sender, EventArgs e)
        {
            AddLichHen formAddLichHen = new AddLichHen();
            formAddLichHen.Show();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fromDate.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DateTime from = fromDate.Value;
            DateTime to = toDate.Value;
            if (from > to)
            {
                MessageBox.Show("Thời gian không hợp lệ");
                return;
            }

            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TreatmentPlan TP JOIN Treatment_TreatmentPlan TTP ON TP.TreatmentPlanID = TTP.TreatmentPlanID WHERE TP.DentistID = @DentistID AND @fromDate <= TTP.TreatingDate AND TTP.TreatingDate <= @toDate;", con))
                {
                    cmd.Parameters.AddWithValue("@DentistID", DentistIDSelected);
                    cmd.Parameters.AddWithValue("@fromDate", from);
                    cmd.Parameters.AddWithValue("@toDate", to);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView7.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Unable to retrieve treatment plans\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime from = from2.Value;
            DateTime to = to2.Value;
            if (from > to)
            {
                MessageBox.Show("Thời gian không hợp lệ");
                return;
            }

            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Appointment WHERE DentistID=@DentistID AND @fromDate <= AppointmentDate AND AppointmentDate <= @toDate;", con))
                {
                    cmd.Parameters.AddWithValue("@DentistID", DentistIDSelected);
                    cmd.Parameters.AddWithValue("@fromDate", from);
                    cmd.Parameters.AddWithValue("@toDate", to);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView8.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Unable to retrieve treatment plans\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addLichHen = new AddLichHen();
            IntermediateFunctions.openNewForm(this, addLichHen);
        }

        private void pPhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["BNHoten"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["BNSdt"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["BNNgaysinh"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["BNDiachi"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["NSHoten"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["ThoiGian"].Value.ToString();

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            pNameBox.Text = dataGridView2.Rows[e.RowIndex].Cells["BNHoten"].Value.ToString();
            textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells["NSHoten"].Value.ToString();

            this.HoSoIDSelected = dataGridView2.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
            refreshDataGrid("HOSO_DICHVU");
            refreshDataGrid("HOSO_THUOC");

            int tongHD = int.Parse(tongPhiDV.Text) + int.Parse(tongPhiThuoc.Text);
            tongHoaDon.Text = tongHD.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT MaHS,HSNgayKham,BNHoten,BNSdt,NSHoten\r\nFROM HOSO HS JOIN BENHNHAN BN ON BN.MaBN=HS.BNKham\r\nJOIN NHASI NS ON NS.MaNS=HS.NSKham";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataView dv = dt.DefaultView;
            dv.RowFilter = "BNSdt LIKE '" + textBox7.Text + "%'";
            dataGridView2.DataSource = dv;
        }
    }
}
