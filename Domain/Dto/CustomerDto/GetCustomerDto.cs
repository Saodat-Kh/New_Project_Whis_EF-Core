namespace Domain.Dto.CustomerDto;

public class GetCustomerDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int BirthDate { get; set; }  
    public string City { get; set; }
    public DateTime RegisteredDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; }
}