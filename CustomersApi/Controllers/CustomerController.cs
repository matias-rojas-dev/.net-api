using CustomersApi.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using CustomersApi.Dtos;

namespace CustomersApi.Controllers

{
    [ApiController]
    [Route("api/[controller]")] // crea los endpoints
    //[Authorize] -> Autoriza el uso de algún método
    public class CustomerController : Controller
    {

        // api/customers
        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))] // mensaje de petición exitosa
        public async Task<IActionResult> GetCustomers()
        {
            throw new NotImplementedException();
        }

        // api/customer/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))] // mensaje de petición exitosa
        [ProducesResponseType(StatusCodes.Status404NotFound)] // mensaje de petición no encontrada
        // IActionResult: nos permite devolver además de un valor de un dat, el status code la petición
        public async Task<IActionResult> GetCustomer(long id)
        {
            var vacio = new CustomerDto();

            return new OkObjectResult(vacio); // 200

        }

        // api/customer/{id}
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))] // mensaje de petición exitosa
        public async Task <IActionResult> DeleteCustomer(long id)
        {
            throw new NotImplementedException();

        }

        // api/customer/{id}
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {
            var vacio = new CustomerDto();

            return new CreatedResult($"https://localhost:7090/api/customer/{vacio.Id}", null);

        }

        // api/customer
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))] // mensaje de petición exitosa
        [ProducesResponseType(StatusCodes.Status404NotFound)] // mensaje de petición no encontrada
        public async Task<IActionResult> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();

        }

    }
}
