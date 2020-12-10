using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFinalProject
{
    public class SQLCommunications
    {
        public int Create(Contact contact)
        {
            var con = new SqlConnection(@"data source=DESKTOP-K72MI89\SQLEXPRESS2;database = Contact;Trusted_Connection=True");

            SqlCommand cm = new SqlCommand("insert into FirstName, LastName, Email, Phonenumber values(@FirstName, @LastName, @desc)", con);
            con.Open();

            cm.Parameters.AddWithValue("@FirstName", contact.fn);
            cm.Parameters.AddWithValue("@LastName", contact.ln);
            cm.Parameters.AddWithValue("@Email", contact.email);
            cm.Parameters.AddWithValue("@Email", contact.phone);

            int newId = 0;
            try
            {
                con.Open();
                cm.ExecuteNonQuery();
                string query2 = "Select @@Identity as newId from Item2";
                cm.CommandText = query2;
                cm.Connection = con;
                newId = Convert.ToInt32(cm.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error inserting data");
            }
            finally
            {
                con.Close();
            }

            return newId;
        }
    }
}
