using System;

namespace DependencyInjectionExample
{
    public interface ICustomerRepository
    {
        string FindCustomerById(int id);
    }

    public class CustomerRepositoryImpl : ICustomerRepository
    {
        public string FindCustomerById(int id)
        {
            return $"Customer #{id}: John Doe";
        }
    }

    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void GetCustomer(int id)
        {
            string customer = _repository.FindCustomerById(id);
            Console.WriteLine(customer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository repo = new CustomerRepositoryImpl();
            CustomerService service = new CustomerService(repo);

            service.GetCustomer(101);
        }
    }
}
