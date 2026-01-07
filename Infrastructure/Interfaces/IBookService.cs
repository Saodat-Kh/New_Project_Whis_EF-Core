using Domain.Dto;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IBookService
{
    List<GetBookDto> GetAllBook();
    GetBookDto GetBookById(int id);
    bool UpdateBook(int id , UpdateBookDto dto);
    bool CreateBook(CreateBookDto dto);
    bool DeleteBook(int id);
    
}