using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {
        [Required]
        [Length(4, 30, ErrorMessage = "Length must be 4 - 30 characters")]
        public string Name { get; set; }

        [Range(1, 90, ErrorMessage = "Number must be between 1 - 90")]
        [Display(Name = "Maximum number of days")]
        public int NumberOfDays { get; set; }
    }
}
