using System;
using PetaPoco;
using PetaPocoExamples.Controllers;

namespace PetaPocoExamples.Models
{
    [TableName("Production.Product")]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public bool MakeFlag { get; set; }
        public bool FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public decimal Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int ProductSubcategoryId{ get; set; }
        public int ProductModelId { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public static Product Create(ProductToCreate x)
        {
            return new Product
            {
                Name = x.Name,
                ProductNumber = x.ProductNumber,
                MakeFlag = x.MakeFlag,
                FinishedGoodsFlag = x.FinishedGoodsFlag,
                Color = x.Color,
                SafetyStockLevel = x.SafetyStockLevel,
                ReorderPoint = x.ReorderPoint,
                StandardCost = x.StandardCost,
                ListPrice = x.ListPrice,
                Size = x.Size,
                SizeUnitMeasureCode = x.SizeUnitMeasureCode,
                WeightUnitMeasureCode = x.WeightUnitMeasureCode,
                Weight = x.Weight,
                DaysToManufacture = x.DaysToManufacture,
                ProductLine = x.ProductLine,
                Class = x.Class,
                Style = x.Style,
                ProductSubcategoryId = x.ProductSubcategoryId,
                ProductModelId = x.ProductModelId,
                SellStartDate = x.SellStartDate,
                SellEndDate = x.SellEndDate,
                DiscontinuedDate = x.DiscontinuedDate,
                ModifiedDate = x.ModifiedDate
            };
        }
    }
}