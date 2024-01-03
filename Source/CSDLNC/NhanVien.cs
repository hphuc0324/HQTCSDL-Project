using System;
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
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CSDLNC;Integrated Security=True");
        private string currNVID = "";
        private string PatientIDSelected = "";
        private string DentistIDSelected = "";
        private string AppointmentIDSelected = "";
        private string StaffIDSelected = "";
        private void refreshDataGrid(string tableName)
        {
           


            
        }
        private void intializeTTCaNhanTab()
        {
            

        }
        public NhanVien(string currNVID = "US101") // Nho doi cai nay
        {
            InitializeComponent();
            refreshDataGrid("PatientProfile");
            refreshDataGrid("Dentist");
            refreshDataGrid("Appointment");
            refreshDataGrid("Staff");
            this.currNVID = currNVID;
            intializeTTCaNhanTab();
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
        private void deleteRow(string tableName, string idField)
        {
            con.Open();
            string id = "";
            if (tableName == "PatientProfile")
                id = this.PatientIDSelected;
            else if (tableName == "Dentist")
            {
                id = this.DentistIDSelected;
                tableName = "SystemUser";
                idField = "UserID";
            }
            else if (tableName == "Staff")
            {
                id = this.StaffIDSelected;
                tableName = "SystemUser";
                idField = "UserID";
            }

            try
            {
                string query = $"DELETE {tableName} WHERE {idField}=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi: Không thể xóa");
                con.Close();
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
            deleteRow("PatientProfile", "PatientID");
            refreshDataGrid("PatientProfile");
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
            this.Close();
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
            dataGridView6.CurrentRow.Selected = true;
            apDateBox.Text = dataGridView6.Rows[e.RowIndex].Cells["AppointmentDate"].Value.ToString();
            apStatusBox.Text = dataGridView6.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            apRoomBox.Text = dataGridView6.Rows[e.RowIndex].Cells["RoomID"].Value.ToString();
            apDentistBox.Text = dataGridView6.Rows[e.RowIndex].Cells["DentistID"].Value.ToString();
            apPatientBox.Text = dataGridView6.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();

            AppointmentIDSelected = dataGridView6.Rows[e.RowIndex].Cells["AppointmentID"].Value.ToString();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            deleteRow("Appointment", "AppointmentID");
            refreshDataGrid("Appointment");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateAppointment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AppointmentID", this.AppointmentIDSelected);
                    cmd.Parameters.AddWithValue("@Status", apStatusBox.Text);
                    cmd.Parameters.AddWithValue("@RoomID", apRoomBox.Text);
                    cmd.Parameters.AddWithValue("@DentistID", apDentistBox.Text);
                    cmd.Parameters.AddWithValue("@PatientID", apPatientBox.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thông tin thành công");
                    refreshDataGrid("Appointment");
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi: Không thể sửa thông tin");
                con.Close();
            }
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
         

          
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
    }
}
