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
    public partial class DSThuoc : Form
    {
        private string idHoso;
       
        public DSThuoc(string idHoso)
        {
            InitializeComponent();
            this.idHoso = idHoso;
            loadDonThuoc();
            loadThuoc();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            donthuocList.CurrentRow.Selected = true;
            idThuocCombox.Text = donthuocList.Rows[e.RowIndex].Cells["MaThuocChiDinh"].Value.ToString();
            soluongBox.Text = donthuocList.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("sp_addTreatingMed", IntermediateFunctions.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHS", this.idHoso);
            cmd.Parameters.AddWithValue("@maThuoc", idThuocCombox.Text);
            int soluong = Int32.Parse(soluongBox.Text);
            cmd.Parameters.AddWithValue("@soluong", soluong);

            cmd.ExecuteNonQuery();

            IntermediateFunctions.con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("sp_updateTreatingMed", IntermediateFunctions.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHS", this.idHoso);
            cmd.Parameters.AddWithValue("@maThuoc", idThuocCombox.Text);
            int soluong = Int32.Parse(soluongBox.Text);
            cmd.Parameters.AddWithValue("@soluong", soluong);

            cmd.ExecuteNonQuery();

            IntermediateFunctions.con.Close();
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("sp_delTreatingMed", IntermediateFunctions.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHS", this.idHoso);
            cmd.Parameters.AddWithValue("@maThuoc", idThuocCombox.Text);

            cmd.ExecuteNonQuery();

            IntermediateFunctions.con.Close();
        }

        private void loadDonThuoc()
        {
            IntermediateFunctions.con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM HOSO_THUOC WHERE MaHSKham=@idHoso", IntermediateFunctions.con);
            cmd.Parameters.AddWithValue("@idHoso", this.idHoso);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            donthuocList.DataSource = dt;

            IntermediateFunctions.con.Close();
        }

        private void loadThuoc()
        {
            IntermediateFunctions.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM THUOC", IntermediateFunctions.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            thuocList.DataSource = dt;

            IntermediateFunctions.con.Close();
            loadThuocCombox();
        }

        private void loadThuocCombox()
        {
            loadCombobox("THUOC", "MaThuoc", idThuocCombox);
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
    }
}
