using API_ScandiHome.DAO;
using API_ScandiHome.DTO;
using API_ScandiHome.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        public ResponseModel<Account> Login(RequestModel request)
        {
            try
            {
                var mResult = AccountDAO.Instance.Login(request.DataCode, request.DataValue);

                var mData = mResult.Rows[0];
                if (mData.Field<bool>("Success"))
                    return new ResponseModel<Account>(new Account(mData), true, mData.Field<string>("Message"), null);
                else
                    return new ResponseModel<Account>(false, null, "Lỗi: " + mData.Field<string>("Message"));
            }
            catch (Exception ex)
            {
                return new ResponseModel<Account>(false, null, "Lỗi: " + ex.Message);
            }
        }
    }
}
