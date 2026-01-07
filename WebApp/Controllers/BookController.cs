using Domain.Dto;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class BookController(IBookService service) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllBook()
    {
        var res = service.GetAllBook();
        return Ok(res);
    }

    [HttpGet("{id}")]
    public IActionResult GetBookById(int id)
    {
        var res = service.GetBookById(id);
        return Ok(res);
    }

    [HttpPost]
    public IActionResult CreateBook(CreateBookDto dto)
    {
        var res = service.CreateBook(dto);
        return Ok(res);
    }

    [HttpPut]
    public IActionResult UpdateBook(int id, UpdateBookDto dto)
    {
        var er = service.UpdateBook(id, dto);
        return Ok(er);
    }

    [HttpDelete]
    public IActionResult DeleteBook(int id)
    {
        var res = service.DeleteBook(id);
        return Ok(res);
    }
    
    
    
}