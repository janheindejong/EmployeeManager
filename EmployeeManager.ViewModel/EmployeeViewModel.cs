using EmployeeManager.Common.Model;

namespace EmployeeManager.ViewModel
{
    public class EmployeeViewModel
    {
        private readonly Employee _employee;    
        public EmployeeViewModel(Employee employee)
        {
            _employee = employee;
        }

    }
}
