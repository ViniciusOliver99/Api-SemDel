namespace Sozinho02.Domain.Model
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
        List<Employee> GetAll();
        List<Employee> GetFalseAndTre();
        void Add(Employee employee);
        void Update(Employee employee);
        void DeleteActive(Employee employee);
        void Delete(int id);
    }
}
