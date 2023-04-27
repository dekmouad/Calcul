using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALConnection;
namespace DAL
{
    public class CalculatorDAL
    {
        DConnection dcn = new DConnection();
       
        public void InsertResult(string opt, double num1, double num2, double result)
        {
            using (SqlConnection connection = new SqlConnection(dcn.connectionString))
            {
                string query = "INSERT INTO Calculator_Table (Opt, Num1, Num2, Result) VALUES (@Opt, @Num1, @Num2, @Result)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Opt", opt);
                    command.Parameters.AddWithValue("@Num1", num1);
                    command.Parameters.AddWithValue("@Num2", num2);
                    command.Parameters.AddWithValue("@Result", result);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
