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
        ContactDto GetById(int Id);
        List<ContactDto> GetList();
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

        public ContactDto GetById(int Id)
        {
            string DevConn = _configuration.GetConnectionString("DevConnection");

            using (SqlConnection sqlConn = new SqlConnection(DevConn))
            {          
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("spContactGetById", sqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    var contact = ToContactDto(reader);                 
                    return contact;

                }
            }
        }

        public List<ContactDto> GetList()
        {
            List<ContactDto> listContacts = new List<ContactDto>();
            string DevConnection = _configuration.GetConnectionString("DevConnection");

            using (SqlConnection sqlConn = new SqlConnection(DevConnection))
            {
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("spContactGetById", sqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ContactDto contact = ToContactDto(reader);
                        listContacts.Add(contact);
                    }
                    return listContacts;
                }
            }
        }

        private ContactDto ToContactDto (SqlDataReader reader)
        {
            var contact = new ContactDto();
            contact.Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : int.MinValue;
            contact.Name = reader["Name"] != DBNull.Value ? Convert.ToString(reader["Name"]) : null;
            contact.Surname = reader["Surname"] != DBNull.Value ? Convert.ToString(reader["Surname"]) : null;
            contact.TelephoneNumber = reader["TelephoneNumber"] != DBNull.Value ? Convert.ToString(reader["TelephoneNumber"]) : null;
            contact.Email = reader["Email"] != DBNull.Value ? Convert.ToString(reader["Email"]) : null;
            contact.DateCreated = reader["DateCreated"] != DBNull.Value ? Convert.ToDateTime(reader["DateCreated"]) : DateTime.MinValue;
            contact.TimeCreated = reader["TimeCreated"] != DBNull.Value ? Convert.ToDateTime(reader["TimeCreated"]) : DateTime.MinValue;
            contact.DateChanged = reader["DateChanged"] != DBNull.Value ? Convert.ToDateTime(reader["DateChanged"]) : DateTime.MinValue;

            return contact;
        }
    }
    public class ContactDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime DateChanged { get; set; }
    }
}
