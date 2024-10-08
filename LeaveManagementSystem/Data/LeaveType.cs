using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Data
{
    public class LeaveType : BaseEntity
    {
        [Column(TypeName = "nvarchar(150)")]//note-3
        //[MaxLength(150)] 
        public string Name { get; set; }

        [Display(Name = "Maximum number of days")]
        public int NumberOfDays { get; set; }
    }
}
