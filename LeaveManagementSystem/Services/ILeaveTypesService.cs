using LeaveManagementSystem.Models.LeaveTypes;

namespace LeaveManagementSystem.Services
{
    public interface ILeaveTypesService
    {
        Task<bool> CheckIfLeaveTypeNameExists(string name);
        Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveType);
        Task Create(LeaveTypeCreateVM model);
        Task Delete(int id);
        Task Edit(LeaveTypeEditVM model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAll();
        bool LeaveTypeExists(int id);
    }
}