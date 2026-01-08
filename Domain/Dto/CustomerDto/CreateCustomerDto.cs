namespace Domain.Dto.CustomerDto;

public class CreateCustomerDto
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int BirthDate { get; set; }  
    public string City { get; set; }
    public bool IsActive { get; set; }
    
}