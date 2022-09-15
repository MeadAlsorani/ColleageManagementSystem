using CMS_BackEnd.Domain.Common;

namespace CMS_BackEnd.Domain
{
    public class Staff : BaseModelClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string Username { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public UserRole Role { get; set; }
        public int Salary { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }

    public enum UserRole
    {
        Teacher=1,
        Admin,
        Employee
    }
}