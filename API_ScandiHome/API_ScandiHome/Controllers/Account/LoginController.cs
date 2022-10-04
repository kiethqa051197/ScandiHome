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
    [System.Web.Http.RoutePrefix("api/Account")]
    public class LoginController : ApiController
    {
        [System.Web.Http.Route("login")]
        [System.Web.Http.HttpPost]
        public ResponseModel<Account> login(RequestModel request)
        {
            try
            {
                return new ResponseModel<Account>(AccountDAO.Instance.Login(request.DataCode, request.DataValue), true, "Get data success!!!" , null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<Account>(false, null, "Lỗi: " + ex.Message);
            }
        }
    }
}
