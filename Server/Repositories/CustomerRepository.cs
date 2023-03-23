using Server.Models;

namespace Server.Repositories;

public class CustomerRepository {
    private List<Customer> _customers;

    public CustomerRepository() {
        _customers = new List<Customer> {
            new Customer { Id = Guid.Parse("61f57488-aa3d-41ff-b844-15824771d773"), FullName = "Customer 1" },
            new Customer { Id = Guid.Parse("391b273f-07a3-4d10-a0c1-be78502e811d"), FullName = "Customer 2" },
            new Customer { Id = Guid.Parse("ddde6181-5349-47ba-b797-6411fe02d255"), FullName = "Customer 3" }
        };
    }

    public Customer GetById(Guid id)
        => _customers.Find(x => x.Id == id);
}