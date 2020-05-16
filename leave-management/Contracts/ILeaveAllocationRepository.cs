using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface ILeaveAllocationRepository :IRepositoryBase<LeaveAllocation>
    {
        Task<bool> CheckAllocation(int leaveTypeid, string employeeid);
        Task<ICollection<LeaveAllocation>> LeaveAllocationsByEmployee(string id);
        Task<LeaveAllocation> LeaveAllocationsByEmployeeAndType(string id, int leaveTypeId);





    }
}
