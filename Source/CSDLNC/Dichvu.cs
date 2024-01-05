using System;
using System.Collections.Generic;
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
    public partial class Dichvu : Form
    {
        private string idHoso = "";
        public Dichvu(string idHoso)
        {
            InitializeComponent();
            this.idHoso = idHoso;
            loadTreatingList();
            loadUsedList();
        }

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treatingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            treatingList.CurrentRow.Selected = true;
            idBox.Text = treatingList.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
            nameBox.Text = treatingList.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
            feeBox.Text = treatingList.Rows[e.RowIndex].Cells["PhiDichVu"].Value.ToString();
        }       

        private void viewToothbtn_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("sp_addTreating", IntermediateFunctions.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@maHS", this.idHoso);
            cmd.Parameters.AddWithValue("@maDV", idBox.Text);

            int row = cmd.ExecuteNonQuery();

            if(row <= 0)
            {
                MessageBox.Show("Lỗi: Đã sử dụng dịch vụ hoặc lỗi không xác định");
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thành công");
            }

            IntermediateFunctions.con.Close();
            loadUsedList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void treatmentName_TextChanged(object sender, EventArgs e)
        {
            
        }


      
        private void adjustBtn_Click(object sender, EventArgs e)
        {
           

            
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("sp_delTreating", IntermediateFunctions.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHS", this.idHoso);
            cmd.Parameters.AddWithValue("@maDV", idBox.Text);
            int row =  cmd.ExecuteNonQuery();
            if(row <= 0)
            {
                MessageBox.Show("Lỗi: Không thể xóa");
            }
            else
            {
                MessageBox.Show("Xóa thành công");
            }

            IntermediateFunctions.con.Close();
            loadUsedList();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadUsedList()
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOSO_DICHVU WHERE MaHSKham=@idHoso", IntermediateFunctions.con);
            cmd.Parameters.AddWithValue("@idHoso", this.idHoso);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            usedTreatingList.DataSource = dt;


            IntermediateFunctions.con.Close();


        }

        private void loadTreatingList()
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DICHVU", IntermediateFunctions.con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            treatingList.DataSource = dt;


            IntermediateFunctions.con.Close();
        }
    }
}
