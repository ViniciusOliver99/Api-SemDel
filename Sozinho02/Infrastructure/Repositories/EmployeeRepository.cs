using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using Sozinho02.Domain.Model;

namespace Sozinho02.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public void DeleteActive(Employee employee)
        {
            var employeeId = _context.Employees.Find(employee.id);

            employeeId.DelActv(employee.activen);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.Where(e => e.activen).ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public List<Employee> GetFalseAndTre()
        {
            return _context.Employees.ToList();
        }

        public void Update(Employee employee)
        {
            var EmployeeId = _context.Employees.Find(employee.id);

            EmployeeId.Up(employee.name, employee.age, employee.photo, employee.activen);
            _context.SaveChanges();
        }
    }
}
