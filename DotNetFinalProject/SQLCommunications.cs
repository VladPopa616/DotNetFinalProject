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
        private const string CON_STRING = @"data source=localhost\SQLEXPRESS2;database = Contact;Trusted_Connection=True";
        public void AddContacts(Contact contact)
        {
            using (var con = new SqlConnection(CON_STRING))
            {
                var query = "insert into FirstName, LastName, Email, Phonenumber values(@FirstName, @LastName, @desc)";
                using (SqlCommand cm = new SqlCommand(query, con))
                {
                    con.Open();

                    cm.Parameters.AddWithValue("@FirstName", contact.fn);
                    cm.Parameters.AddWithValue("@LastName", contact.ln);
                    cm.Parameters.AddWithValue("@Email", contact.email);
                    cm.Parameters.AddWithValue("@PhoneNumber", contact.phone);

                    cm.ExecuteNonQuery();
                }

            }

            
        } 
        public List<Contact> ReadContacts(Contact contact)
        {
            List<Contact> contacts = new List<Contact>();
            using(var con = new SqlConnection(CON_STRING))
            {
                var query = "select * from contact";

                using(var cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object Id = reader["Id"];
                            object FName = reader["fn"];
                            object LName = reader["ln"];
                            object Email = reader["email"];
                            object Phone = reader["phone"];

                            contacts.Add(new Contact(Id, FName, LName, Email, Phone));
                        }
                    }
                }
            }
            return contacts;
        }

        public void UpdateContacts(Contact contact)
        {

        }

        public void DeleteContacts(Contact contact)
        {

        }

       
    }


}
