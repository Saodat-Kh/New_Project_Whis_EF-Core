using Domain.Dto.CustomerDto;
using Domain.Entities;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CustomerController(ICustomerService service) : ControllerBase
{
    [HttpPost]
    public IActionResult CreateCustomer(CreateCustomerDto dto)
    {
        var res = service.CreateCustomer(dto);
        return Ok(res);
    }

    [HttpGet]
    public IActionResult GetAllCustomers()
    {
        var res = service.GetAllCustomer();
        return Ok(res);
    }

    [HttpGet("id")]
    public IActionResult GetCustomerById(int id)
    {
        var res = service.GetCustomerById(id);
        return Ok(res);
    }

    [HttpPut]
    public IActionResult UpdateCustomer(int id, UpdateCustomerDto dto)
    {
        var res = service.UpdateCustomer(id, dto);
        return Ok(res);
    }

    [HttpDelete]
    public IActionResult DeleteCustomer(int id)
    {
        var res = service.DeleteCustomer(id);
        return Ok(res);
    }
    
}
 
