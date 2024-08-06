
using System.Data.SqlClient;

public class ADONET
{
    public static void Main(String[] arg)
    {
        const string connectionStr =  "Server=LAPTOP-MLT5J99G\\SQLEXPRESS;database=divine;trusted_connection=true;trustservercertificate=yes";

        using (SqlConnection conn = new SqlConnection(connectionStr)) 
        {
            SqlCommand sdr = new SqlCommand("Select * from Constantinopole", conn);
            conn.Open();
            SqlDataReader rd = sdr.ExecuteReader();
            while(rd.Read())
            {   
                Console.WriteLine("placeName: "+rd["placeName"]);
                Console.WriteLine("countryName: " + rd["countryName"]);

            }


        }
    }


}