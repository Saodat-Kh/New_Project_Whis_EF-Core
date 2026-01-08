using Domain.Dto;
using Domain.Entities;
using Infrastructure.Interfaces;
using Infrastructure.Interfaces.Data;

namespace Infrastructure.Services;

public class BookService(DataContext context) : IBookService
{
    #region GetAllBook
    public List<GetBookDto> GetAllBook()
    {
        var res = context.Books.ToList();
        var dto = res.Select(x => new GetBookDto()
        {
            Id = x.Id,
            Title = x.Title,
            Author = x.Author,
            Genre = x.Genre,
            Price = x.Price,
            Language = x.Language,
            Pages = x.Pages,
            PublishDate = x.PublishDate,
            PublishedYear = x.PublishedYear
        }).ToList();
        return dto;
    }
    #endregion

    #region GetBookById
    public GetBookDto GetBookById(int id)
    {
        var res = context.Books.FirstOrDefault(x => x.Id == id);
        var dto = new GetBookDto()
        {
            Id = res.Id,
            Title = res.Title,
            Author = res.Author,
            Genre = res.Genre,
            Language = res.Language,
            Pages = res.Pages,
            Price = res.Price,
            PublishDate = res.PublishDate,
            PublishedYear = res.PublishedYear
        };
        return dto;
    }
    #endregion

    #region UpdateBook
    public bool UpdateBook(int id, UpdateBookDto dto)
    {
        var res =   context.Books.FirstOrDefault(x => x.Id == id);
        if(res == null) return false;
        res.Title = dto.Title;
        res.Author = dto.Author;
        res.Genre = dto.Genre;
        res.Price = dto.Price;
        res.Language = dto.Language;
        res.Pages = dto.Pages;
        res.PublishedYear = dto.PublishedYear;
        var res2 = context.SaveChanges();
        return res2 > 0;
        
    }
    #endregion

    #region CreateBook
    public bool CreateBook(CreateBookDto dto)
    {
        var res = new Book()
        {
            Title = dto.Title,
            Author = dto.Author,
            Genre = dto.Genre,
            Price = dto.Price,
            Language = dto.Language,
            Pages = dto.Pages,
             
             
        };
        context.Books.Add(res);
        var rew2 = context.SaveChanges();
        return rew2 > 0;
    }
    #endregion

    #region DeleteBook  
    public bool DeleteBook(int id)
    {
        var res = context.Books.FirstOrDefault(x => x.Id == id);
        if(res != null) return false;
        context.Books.Remove(res);
        var res2 = context.SaveChanges();
        return true;
    }
    #endregion
}