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
    class IntermediateFunctions
    {
        static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=QLPHONGKHAMNHAKHOA2;Integrated Security=True");
        
        public static string getNewID(string table, string idField)
        {
            con.Open();
            string query = $"SELECT TOP 1 * FROM {table} ORDER BY {idField} DESC";
            SqlCommand cmd = new SqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.Read())
                {
                    con.Close();
                    return matchKey(table) + "0001";
                }

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

                con.Close();
                return letters + numbers;
            }
            
        }

        public static string matchKey(string table)
        {
            switch (table)
            {
                case "BENHNHAN":
                    return "BN";
                case "QUANTRIVIEN":
                    return "QTV";
                case "NHASI":
                    return "NS";
                case "NHANVIEN":
                    return "NV";
                case "DICHVU":
                    return "DV";
                case "HOADON":
                    return "HD";
                case "HOSO":
                    return "HS";
                case "LICHHEN":
                    return "LH";
                case "LICHLAMVIEC":
                    return "LV";
                case "THUOC":
                    return "TH";
                default:
                    return "";
            }
        }
    }
}
