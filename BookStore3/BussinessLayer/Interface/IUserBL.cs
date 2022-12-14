using BookStore3.CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore3.BussinessLayer.Interface
{
    public  interface IUserBL
    {
        public RegistrationModel AddUser(RegistrationModel usermodel);
    }
}
