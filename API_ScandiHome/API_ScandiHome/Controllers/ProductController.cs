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
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        [Route("GetAll")]
        [HttpPost]
        public ResponseModel<DataTable> login()
        {
            try
            {
                return new ResponseModel<DataTable>(ProductDAO.Instance.GetAll(), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }

        [Route("GetProductBySKU")]
        [HttpPost]
        public ResponseModel<DataTable> GetProductBySKU(RequestModel pRequest)
        {
            try
            {
                return new ResponseModel<DataTable>(ProductDAO.Instance.GetProductBySKU(pRequest.DataCode), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }
    }
}