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
    public partial class HSBA : Form
    {

        private string patientID;
        private string idHoso;
       
       
        public HSBA(string id= "")
        {
            InitializeComponent();
            this.patientID = id;
            loadHoso(patientID);
            loadPaitentCombox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hosoList.CurrentRow.Selected = true;
            patientCombox.Text = hosoList.Rows[e.RowIndex].Cells["BNKham"].Value.ToString();
            tpDentistName.Text = hosoList.Rows[e.RowIndex].Cells["NSKham"].Value.ToString();
            tpDate.Text = hosoList.Rows[e.RowIndex].Cells["HSNgayKham"].Value.ToString();
            this.idHoso = hosoList.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
            loadDonThuoc(idHoso);
            loadDichvu(hosoList.Rows[e.RowIndex].Cells["MaHS"].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void addDentistCombox()
        {
          
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           
           
        }

        

        private void delBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteRow(string tableName, string field, string key)
        {
            
        }

        private void adjustBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadDichvu(string idHoso)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOSO_DICHVU WHERE MaHSKham=@idHoso", IntermediateFunctions.con);
            cmd.Parameters.AddWithValue("@idHoso", idHoso);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dichvuList.DataSource = dt;

            IntermediateFunctions.con.Close();
        }

        private void loadDonThuoc(string idHoso)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOSO_THUOC WHERE MaHSKham=@idHoso", IntermediateFunctions.con);
            cmd.Parameters.AddWithValue("@idHoso", idHoso);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            donThuocList.DataSource = dt;

            IntermediateFunctions.con.Close();
        }

        private void loadHoso(string patientID)
        {
            SqlCommand cmd;
            if(patientID == "")
            {
                cmd = new SqlCommand("SELECT * FROM HOSO", IntermediateFunctions.con);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM HOSO WHERE BNKham = @id", IntermediateFunctions.con);
                cmd.Parameters.AddWithValue("@id", patientID);
            }

            IntermediateFunctions.con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            hosoList.DataSource = dt;

            IntermediateFunctions.con.Close();
        }

        private void loadPaitentCombox()
        {
            loadCombobox("BENHNHAN", "MaBN", patientCombox);

            if(this.patientID != "")
            {
                patientCombox.Text = patientID;
            }
        }

        private void loadCombobox(string table, string field, ComboBox combox)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {table}", IntermediateFunctions.con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    combox.Items.Add(reader[field].ToString());

                }
            }

            IntermediateFunctions.con.Close();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            loadHoso(patientCombox.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dichvu dichVuForm = new Dichvu(idHoso);
            IntermediateFunctions.openNewForm(this, dichVuForm);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DSThuoc dsThuocForm = new DSThuoc(idHoso);
            IntermediateFunctions.openNewForm(this, dsThuocForm);
        }
    }
}
