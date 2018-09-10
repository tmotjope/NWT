using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NWT.Application.Customers.Commands.CreateCustomer;
using NWT.Application.Customers.Commands.DeleteCustomer;
using NWT.Application.Customers.Commands.UpdateCustomer;
using NWT.Application.Customers.Queries.GetCustomerDetail;
using NWT.Application.Customers.Queries.GetCustomerList;
using NWT.Data;
using NWT.Domain;

namespace NWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private readonly IGetCustomerListQuery _customerContext;
        private readonly IGetCustomerDetailQuery _customerDetailContext;
        private readonly ICreateCustomerCommand _customerCreateContext;
        private readonly IUpdateCustomerCommand _customerUpdateContext;
        private readonly IDeleteCustomerCommand _customerDeleteContext;
        public CustomersController(IGetCustomerListQuery customerContext, IGetCustomerDetailQuery customerDetailContext,
            ICreateCustomerCommand customerCreateContext, IUpdateCustomerCommand customerUpdateContext, IDeleteCustomerCommand customerDeleteContext)
        {
            _customerContext = customerContext;
            _customerDetailContext = customerDetailContext;
            _customerCreateContext = customerCreateContext;
            _customerUpdateContext = customerUpdateContext;
            _customerDeleteContext = customerDeleteContext;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListModel>> Get()
        {
            return await _customerContext.Execute();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var customer = await _customerDetailContext.Execute(id);
            if(customer.Id == null)
            {
                return NotFound();
            }
            return new ObjectResult(customer);       
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCustomerModel model)
        {
            if(model == null)
            {
                return BadRequest();
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _customerCreateContext.Execute(model);

            return CreatedAtRoute("Create", new { model.Id }, model);

        }

        // POST api/values
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(string id, [FromBody] UpdateCustomerModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _customerUpdateContext.Execute(model);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            await _customerDeleteContext.Execute(id);
            return new NoContentResult();
        }

    }
}