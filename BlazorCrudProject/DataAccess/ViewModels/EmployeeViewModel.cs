using System.ComponentModel.DataAnnotations;

namespace BlazorCrudProject.DataAccess.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        public string EmployeeIdView
        {
            get { return "EMPL" + EmployeeId.ToString().PadLeft(3, '0'); }
        }

        [Required] 
        public string FullName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
    }
}
