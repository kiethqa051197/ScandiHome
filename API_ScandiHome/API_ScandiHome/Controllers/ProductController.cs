using API_ScandiHome.DAO;
using API_ScandiHome.Models;
using System;
using System.Data;
using System.Web.Http;

namespace API_ScandiHome.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        [Route("GetAll")]
        [HttpPost]
        public ResponseModel<DataTable> GetAllProduct()
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
        public ResponseModel<DataTable> GetProductBySKU(RequestModel request)
        {
            try
            {
                return new ResponseModel<DataTable>(ProductDAO.Instance.GetProductBySKU(request.DataCode), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }

        [Route("GetAllCategory")]
        [HttpPost]
        public ResponseModel<DataTable> GetAllCategory()
        {
            try
            {
                return new ResponseModel<DataTable>(ProductDAO.Instance.GetAllCategory(), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }

        [Route("GetAllDesign")]
        [HttpPost]
        public ResponseModel<DataTable> GetAllDesign()
        {
            try
            {
                return new ResponseModel<DataTable>(ProductDAO.Instance.GetAllDesign(), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }

        [Route("GetAllModel")]
        [HttpPost]
        public ResponseModel<DataTable> GetAllModel()
        {
            try
            {
                return new ResponseModel<DataTable>(ProductDAO.Instance.GetAllModel(), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }

        [Route("GetAllSeries")]
        [HttpPost]
        public ResponseModel<DataTable> GetAllSeries()
        {
            try
            {
                return new ResponseModel<DataTable>(ProductDAO.Instance.GetAllSeries(), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }

        [Route("GetAllProductSKU")]
        [HttpPost]
        public ResponseModel<DataTable> GetAllProductSKU()
        {
            try
            {
                return new ResponseModel<DataTable>(ProductDAO.Instance.GetAllProductSKU(), true, "Get data success!!!", null);
            }
            catch (Exception ex)
            {
                return new ResponseModel<DataTable>(false, null, "Lỗi: " + ex.Message);
            }
        }
    }
}