using Domain.Dto.CustomerDto;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ICustomerService
{
    List<GetCustomerDto> GetAllCustomer();
    GetCustomerDto GetCustomerById(int id);
    bool CreateCustomer(CreateCustomerDto dto);
    bool UpdateCustomer(int id, UpdateCustomerDto dto);
    bool DeleteCustomer(int id);
}