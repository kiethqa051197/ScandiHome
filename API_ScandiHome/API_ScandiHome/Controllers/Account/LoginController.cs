using API_ScandiHome.DAO;
using API_ScandiHome.DTO;
using API_ScandiHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace API_ScandiHome.Controllers
{
    public class LoginController : ApiController
    {
        [System.Web.Http.HttpPost]
        public ResponseModel Login(RequestModel request)
        {
            string username = request.DataCode;
            string password = request.DataValue;

            return new ResponseModel(200, username, AccountDAO.Instance.Login(username, password), null);
        }
    }
}
