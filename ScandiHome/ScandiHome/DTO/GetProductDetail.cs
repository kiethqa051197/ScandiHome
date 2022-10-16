using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScandiHome.DTO
{
    class GetProductDetail
    {
        public int TypeCode;
        public string CategoryCode;
        public string GroupSKUCode;
        public string NewProductNote;
        public string SKU;
        public string ProductCode;
        public string Size;
        public float Weight;
        public string DraftName;
        public string ProductName;
        public string DesignDate;
        public string Designer;
        public string SeriesCode;
        public string DataCode;
        public string DataName;
        public double Quantity;
        public double Amount;
        public double TotalAmount;
        public string Created;
        public string CreatedBy;
        public string LastModified;
        public string LastModifiedBy;

        public GetProductDetail(int pTypeCode, string pCategoryCode, string pGroupSKUCode, string pNewProductNote, string pSKU, string pProductCode, string pSize, float pWeight, string pDraftName,
                                string pProductName, string pDesignDate, string pDesigner, string pSeriesCode, string pDataCode, string pDataName, double pQuantity, double pAmount, 
                                double pTotalAmount, string pCreated, string pCreatedBy, string pLastModified, string pLastModifiedBy)
        {
            this.TypeCode = pTypeCode;
            this.CategoryCode = pCategoryCode;
            this.GroupSKUCode = pGroupSKUCode;
            this.NewProductNote = pNewProductNote;
            this.SKU = pSKU;
            this.ProductCode = pProductCode;
            this.Size = pSize;
            this.Weight = pWeight;
            this.DraftName = pDraftName;
            this.ProductName = pProductName;
            this.DesignDate = pDesignDate;
            this.Designer = pDesigner;
            this.SeriesCode = pSeriesCode;
            this.DataCode = pDataCode;
            this.DataName = pDataName;
            this.Quantity = pQuantity;
            this.Amount = pAmount;
            this.TotalAmount = pTotalAmount;
            this.Created = pCreated;
            this.CreatedBy = pCreatedBy;
            this.LastModified = pLastModified;
            this.LastModifiedBy = pLastModifiedBy;
        }
    }
}
