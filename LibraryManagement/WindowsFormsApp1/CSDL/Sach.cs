using System.Data;
using System.Data.SqlClient;

string connString = @"Server=.;Database=QL_Thu_Vien;Trusted_Connection=True;";
SqlConnection conn = new SqlConnection(connString);

string query = "SELECT * FROM SACH";
SqlDataAdapter da = new SqlDataAdapter(query, conn);
DataTable dt = new DataTable();
da.Fill(dt);
