using BookStore3.CommanLayer.Model;
using BookStore3.RepositoryLayer.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore3.RepositoryLayer.services
{
    public class UserRL : IUserRL
    {

        private readonly IConfiguration configuration;
        SqlConnection sqlConnection;
        
        public UserRL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public RegistrationModel AddUser(RegistrationModel usermodel)
        {
            this.sqlConnection = new SqlConnection(this.configuration.GetConnectionString("BookStore3"));
            using (sqlConnection)
                try
                {

                    SqlCommand command = new SqlCommand("spAddUser", this.sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    this.sqlConnection.Open();

                    command.Parameters.AddWithValue("@fullname", usermodel.FullName);
                    command.Parameters.AddWithValue("@email", usermodel.Email);
                    command.Parameters.AddWithValue("@password", usermodel.Password);
                    command.Parameters.AddWithValue("@mobile", usermodel.Mobile);
                    var result = command.ExecuteNonQuery();

                    if (result != 0)
                    {
                        return usermodel;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    this.sqlConnection.Close();
                }

        }

    }
}
