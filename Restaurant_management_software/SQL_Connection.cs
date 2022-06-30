using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; //add to every form 

namespace Restaurant_management_software
{
    class SQL_Connection
    {
        public SqlConnection connection;
        public SqlCommand command;
        public DataTable data;
        public SqlDataAdapter adapter;

        public void startConnect()
        {
            string connect = "Data Source=LONGNN;Initial Catalog=QLHOADON;Integrated Security=True";
            connection = new SqlConnection(connect);
            connection.Open();
        }

        public void cancelConnect()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable getData(string sql)
        {
            startConnect();
            adapter = new SqlDataAdapter(sql, connection);
            data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public void excute(string sql)
        {
            startConnect();
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            cancelConnect();
        }
        public String GetMaxId(string sql)
        {
            startConnect();
            String txt = "";
            command = new SqlCommand(sql, connection);
            SqlDataReader res = command.ExecuteReader();
            while (res.Read() == true)
            {
                txt = (string)res["max_number"].ToString();
                int number = Int32.Parse(txt) + 1;
                txt = number.ToString();
            }
            return txt;
        }

        public String GetMaLoai(string sql)
        {
            startConnect();
            String txt = "";
            command = new SqlCommand(sql, connection);
            SqlDataReader res = command.ExecuteReader();
            while (res.Read() == true)
            {
                txt = (string)res["MaLoai"].ToString();
            }
            return txt;
        }

        public List<string> GetTenLoai(string sql)
        {
            List<string> results = new List<string>();
            command = new SqlCommand(sql, connection);
            SqlDataReader res = command.ExecuteReader();
            while (res.Read() == true)
            {
                string txt = (string)res["TenLoai"].ToString();
                results.Add(txt);
            }
            return results;
        }
    }
}