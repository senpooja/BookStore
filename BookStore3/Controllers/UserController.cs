using BookStore3.BussinessLayer.Interface;
using BookStore3.CommanLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }
        [HttpPost("Register")]
        public IActionResult UserRegistration(RegistrationModel userRegistration)
        {
            try
            {
                RegistrationModel registrationModel = userBL.AddUser(userRegistration);
                if (registrationModel != null)
                {
                    return this.Ok(new { success = true, message = "Registration Successfull", data = registrationModel });
                }
                else
                {
                    return this.BadRequest();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
