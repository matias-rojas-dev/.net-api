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
        public async Task<List<CustomerDto>> GetCustomer()
        {
            throw new NotImplementedException();
        }

        // api/customer/{id}
        [HttpGet("{id}")]
        public async Task<CustomerDto> GetCustomers(long id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task <bool> DeleteCustomer(long id)
        {
            throw new NotImplementedException();

        }

        [HttpPost]
        public async Task<CustomerDto> CreateCustomer(CreateCustomerDto customer)
        {
            throw new NotImplementedException();

        }


        [HttpPut]
        public async Task<CustomerDto> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();

        }

    }
}
