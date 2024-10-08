using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        public string Name { get; set; }

        [Display(Name = "Maximum number of days")]
        public int NumberOfDays { get; set; }
    }
}
