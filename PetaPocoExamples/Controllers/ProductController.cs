using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class ProductController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {
            ////Get single record
            var product = new GetProductById().Execute(id);
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        public HttpResponseMessage Get(string productName)
        {
            var product = new GetProductsByName().Execute(productName);
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        public HttpResponseMessage Get(string productName, int pageNumber, int recordCount)
        {
            var product = new GetProductByNameWithPaging().Execute(productName, pageNumber, recordCount);
            return Request.CreateResponse(HttpStatusCode.OK, product.Items);
        }

        // POST api/<controller>
        public void Post([FromBody] ProductToCreate productToCreate)
        {
            ////for the purposes of a demo use something like postman to send a post to http://localhost:57096/api/product with an empty JSON obj
            productToCreate = new ProductToCreate
            {
                Class = null,
                Color = "color",
                DaysToManufacture = 1,
                DiscontinuedDate = DateTime.Now,
                FinishedGoodsFlag = true,
                ListPrice = 0,
                MakeFlag = true,
                ModifiedDate = DateTime.Now,
                Name = DateTime.Now.ToString(),
                ProductLine = "R",
                ProductModelId = 1,
                ProductNumber = DateTime.Now.ToString(),
                ProductSubcategoryId = 1,
                ReorderPoint = 1,
                rowguid = Guid.NewGuid(),
                SafetyStockLevel = 1,
                SellEndDate = DateTime.Now,
                SellStartDate = DateTime.Now,
                Size = "size",
                SizeUnitMeasureCode = null,
                Style = null,
                Weight = 1,
                WeightUnitMeasureCode = null
            };

            var product = Product.Create(productToCreate);
            new UpsertProduct().Execute(product);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] ProductToCreate productToCreate)
        {
            var product = Product.Create(productToCreate);
            new UpsertProduct().Execute(product);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}