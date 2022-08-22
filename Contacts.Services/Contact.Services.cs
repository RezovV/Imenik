using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Services
{
    public interface IContactService
    {
        ContactsServicesDto GetById(int Id);
        List<ContactsServicesDto> GetList();
    }
    public class ContactsService : IContactService
    {
        private readonly IConfiguration _configuration;

        public ContactsService()
        {

        }

        public ContactsService(IConfiguration Configuration)
        {
            this._configuration = Configuration;
        }

        public ContactsServicesDto GetById(int Id)
        {
            string DevConn = _configuration.GetConnectionString("DevConnection");

            using (SqlConnection sqlConn = new SqlConnection(DevConn))
            {          
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("spContactGetById", sqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var contact = new ContactsServicesDto();
                        contact.Id = Convert.ToInt32(reader["Id"]);
                        contact.Name = Convert.ToString(reader["Name"]);
                        contact.Surname = Convert.ToString(reader["Surname"]);
                        contact.Tel_num = Convert.ToString(reader["Tel_num"]);
                        contact.Email = Convert.ToString(reader["Email"]);
                        contact.Date_cre = Convert.ToString(reader["Date_cre"]);
                        contact.Time_cre = Convert.ToString(reader["Time_cre"]);
                        contact.Date_cha = Convert.ToString(reader["Date_cha"]);

                        return contact;
                    }
                }
            }
            return null;
        }

        public List<ContactsServicesDto> GetList()
        {
            List<ContactsServicesDto> contactList = new List<ContactsServicesDto>();
            return contactList;
        }
    }
    public class ContactsServicesDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tel_num { get; set; }
        public string Email { get; set; }
        public string Date_cre { get; set; }
        public string Time_cre { get; set; }
        public string Date_cha { get; set; }
    }
}
