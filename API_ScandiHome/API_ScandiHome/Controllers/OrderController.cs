using API_ScandiHome.DAO;
using API_ScandiHome.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API_ScandiHome.Controllers
{
    [RoutePrefix("api/Order")]
    public class OrderController : ApiController
    {
        [Route("GetAll")]
        [HttpPost]
        public ResponseModel<DataTable> GetAllProduct()
        {
            try
            {
                return new ResponseModel<DataTable>(OrderDAO.Instance.GetAll(), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }

        [Route("GetOrderDetail")]
        [HttpPost]
        public ResponseModel<DataTable> GetProductBySKU(RequestModel request)
        {
            try
            {
                return new ResponseModel<DataTable>(OrderDAO.Instance.GetOrderDetail(request.DataCode), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }
    }
}