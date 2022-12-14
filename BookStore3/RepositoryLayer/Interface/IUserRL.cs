using BookStore3.CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore3.RepositoryLayer.Interface
{
     public interface IUserRL
   
    {
        public RegistrationModel AddUser(RegistrationModel usermodel);
    }
}
