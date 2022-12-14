using BookStore3.BussinessLayer.Interface;
using BookStore3.CommanLayer.Model;
using BookStore3.RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore3.BussinessLayer.Services
{
    public class UserBL:IUserBL
    {
        private readonly IUserRL userRL;
        public UserBL(IUserRL userRL)
        {
            this.userRL = userRL;
        }
        public RegistrationModel AddUser(RegistrationModel usermodel)
        {
            try
            {
                return this.userRL.AddUser(usermodel);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
    }

