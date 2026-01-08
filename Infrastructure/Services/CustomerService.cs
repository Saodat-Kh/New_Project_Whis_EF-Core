using Domain.Dto.CustomerDto;
using Domain.Entities;
using Infrastructure.Interfaces;
using Infrastructure.Interfaces.Data;

namespace Infrastructure.Services;

public class CustomerService(DataContext context) : ICustomerService
{
    #region GetAllCustomer
    public List<GetCustomerDto> GetAllCustomer()
    {
        var res = context.Customers.ToList();
        var dto = res.Select(x=> new GetCustomerDto()
        {
            Id =x.Id,
            BirthDate = x.BirthDate,
            City = x.City,
            Email = x.Email,
            FullName = x.FullName,
            IsActive = x.IsActive,
            Phone = x.Phone,
            RegisteredDate = x.RegisteredDate
        }).ToList();
        return dto;
    }
    #endregion

    #region GetCustomerById
    public GetCustomerDto GetCustomerById(int id)
    {
        var res = context.Customers.FirstOrDefault(x => x.Id == id);
        var dto = new GetCustomerDto()
        {
            Id = res.Id,
            BirthDate = res.BirthDate,
            City = res.City,
            Email = res.Email,
            FullName = res.FullName,
            IsActive = res.IsActive,
            Phone = res.Phone,
            RegisteredDate = res.RegisteredDate,
        };
        return dto;
    }
    #endregion

    #region CreateCustomer
    public bool CreateCustomer(CreateCustomerDto dto)
    {
        var res = new Customer()
        {
            BirthDate = dto.BirthDate,
            City = dto.City,
            Email = dto.Email,
            FullName = dto.FullName,
            IsActive = dto.IsActive,
            Phone = dto.Phone,
        };
        context.Customers.Add(res);
        var res2 = context.SaveChanges();
        return res2 > 0;
    }
    #endregion

    #region UpdateCustomer
    public bool UpdateCustomer(int id, UpdateCustomerDto dto)
    {
         var res = context.Customers.FirstOrDefault(x => x.Id == id);
         if(res == null) return false;
         res.BirthDate = dto.BirthDate;
         res.City = dto.City;
         res.Email = dto.Email;
         res.FullName = dto.FullName;
         res.IsActive = dto.IsActive;
         res.Phone = dto.Phone;
         var res2 = context.SaveChanges();
         return res2 > 0;
    }
    #endregion

    #region DeleteCustomer
    public bool DeleteCustomer(int id)
    {
        var res = context.Customers.FirstOrDefault(x => x.Id == id);
        if(res != null) return false;
        context.Customers.Remove(res);
        var res2 = context.SaveChanges();
        return res2 > 0;
    }
    #endregion
}