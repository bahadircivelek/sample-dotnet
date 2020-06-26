using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    [Route("api/product")]
    public class ProductController : BaseController
    {
        /// <summary>
        /// Get Users
        /// </summary>  
        ///<response code="200">Successful operation</response>
        ///<response code="400">Invalid request</response>
        ///<returns>List of Users</returns>
        [HttpPost, Route("stock")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Stock([FromBody]Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productData = new Product
            {
                Id = product.Id,
                Stock = 10
            };

            return Ok(productData);
        }
    }
}