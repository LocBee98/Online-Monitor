using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace WinformInterface.Functions
{
    class SqlFunction
    {

        public DataTable getDataTb()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-3U4VT91\WINCC;Initial Catalog=CEMS;Integrated Security=True");
            SqlCommand cmd;
            connect.Open();
            string sql = "SELECT * FROM CemsTable WHERE ID > 0";
            cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataReader da1 = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(da1);
            //  dtgv.DataSource = dt;
            connect.Close();
            return dt;
        }
        public DataTable getDataTb_Excel(int _From, int _To, string _frequency)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-3U4VT91\WINCC;Initial Catalog=CEMS;Integrated Security=True");
            SqlCommand cmd;
            connect.Open();
            string sqlCmd = string.Empty;
            string getDataList = "DateTime, Temp, Press, Dust, Flow, SO2, NOx, CO, O2, State";

            switch (_frequency)
            {
                case "1":
                    // Export 1min/file
                    sqlCmd = "SELECT" + " " + getDataList + " " + "FROM CemsTable WHERE ID BETWEEN @_From AND @_To";
                    break;
                case "5":
                    // Export 5min/file
                    sqlCmd = "SELECT" + " " + getDataList + " " + "FROM CemsTable WHERE (ID BETWEEN @_From AND @_To) AND (Minute % 5 = 0)";
                    break;
                case "30":
                    sqlCmd = "SELECT" + " " + getDataList + " " + "FROM CemsTable WHERE (ID BETWEEN @_From AND @_To) AND (Minute % 30 = 0)";
                    break;
                case "60":
                    sqlCmd = "SELECT" + " " + getDataList + " " + "FROM CemsTable WHERE (ID BETWEEN @_From AND @_To) AND (Minute % 60 = 0)";
                    break;
            }

            cmd = new SqlCommand(sqlCmd, connect);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("getData", getData);
            cmd.Parameters.AddWithValue("_From", _From.ToString());
            cmd.Parameters.AddWithValue("_To", _To.ToString());
            SqlDataReader da1 = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            //DataColumn Col = new DataColumn("No.", typeof(int));
            //dt.Columns.Add(Col);


            dt.Load(da1);
            //  dtgv.DataSource = dt;


            connect.Close();
            return dt;
        }


        public void insertInToDataBase(int _ID, int _Minute, string _DateTime, float _Temp, float _Press, float _Dust, float _Flow, float _SO2, float _NOx, float _CO, float _O2, string _State)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-3U4VT91\WINCC;Initial Catalog=CEMS;Integrated Security=True");
            SqlCommand cmd;
            connect.Open();

            string Sql = "INSERT INTO CemsTable VALUES(@ID, @Minute, @DateTime, @Temp, @Press, @Dust, @Flow, @SO2, @NOx, @CO, @O2, @State)";
            //string Sql = "INSERT INTO CemsTable VALUES(@ID, @DateTime, @Temp, @Press, @Dust, @Flow, @SO2, @NOx, @CO, @O2, @State)";
            cmd = new SqlCommand(Sql, connect);
            cmd.Parameters.AddWithValue("ID", _ID.ToString());
            cmd.Parameters.AddWithValue("Minute", _Minute.ToString());
            cmd.Parameters.AddWithValue("DateTime", _DateTime);
            cmd.Parameters.AddWithValue("Temp", _Temp.ToString());
            cmd.Parameters.AddWithValue("Press", _Press.ToString());
            cmd.Parameters.AddWithValue("Dust", _Dust.ToString());
            cmd.Parameters.AddWithValue("Flow", _Flow.ToString());
            cmd.Parameters.AddWithValue("SO2", _SO2.ToString());
            cmd.Parameters.AddWithValue("NOx", _NOx.ToString());
            cmd.Parameters.AddWithValue("CO", _CO.ToString());
            cmd.Parameters.AddWithValue("O2", _O2.ToString());
            cmd.Parameters.AddWithValue("State", _State);

            cmd.ExecuteNonQuery();////Error in here!
            connect.Close();
        }

        public string getID()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-3U4VT91\WINCC;Initial Catalog=CEMS;Integrated Security=True");
            SqlCommand cmd;
            string ID = string.Empty;
            connect.Open();
            string sql = "SELECT MAX(ID) FROM CemsTable WHERE ID > 0";
            cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            try
            {
                ID = cmd.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();
            return ID;
        }

        public string getID_Query(string DateTimeQuery)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-3U4VT91\WINCC;Initial Catalog=CEMS;Integrated Security=True");
            SqlCommand cmd;
            string ID = string.Empty;

            connect.Open();

            string sql = "SELECT ID FROM CemsTable WHERE DateTime = @DateTime";

            //
            cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("DateTime", DateTimeQuery);
            try
            {
                ID = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                //MessageBox.Show(x.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Không có file tại " + DateTimeQuery, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();
            return ID;
        }






        /*
        private void btnDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sqlDelete = "DELETE FROM demo_csdl WHERE id = @id";
            cmd = new SqlCommand(sqlDelete, connect);
            //cmd.Parameters.AddWithValue("param1", txtparam1.Text);
            //cmd.Parameters.AddWithValue("param2", txtparam2.Text);
            cmd.Parameters.AddWithValue("id", txtid.Text);
            cmd.ExecuteNonQuery();
            txtid.Text = "";
            show();
            connect.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sqlUpdate = "UPDATE demo_csdl SET param1 = @param1, param2 = @param2 WHERE id = @id";
            cmd = new SqlCommand(sqlUpdate, connect);
            cmd.Parameters.AddWithValue("param1", txtparam1.Text);
            cmd.Parameters.AddWithValue("param2", txtparam2.Text);
            cmd.Parameters.AddWithValue("id", txtid.Text);
            cmd.ExecuteNonQuery();
            // Clear textbox
            txtparam1.Text = "";
            txtparam2.Text = "";
            txtid.Text = "";
            //
            show();
            connect.Close();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sqlFind = "SELECT * FROM demo_csdl WHERE id = @id";
            cmd = new SqlCommand(sqlFind, connect);
            cmd.Parameters.AddWithValue("id", txtid.Text);
            txtid.Text = "";

            //cmd.CommandType = CommandType.Text;
            SqlDataReader da1 = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(da1);
            dtgv.DataSource = dt;
            connect.Close();
        }
        */
    }
}
