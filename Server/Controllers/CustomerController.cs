using Microsoft.AspNetCore.Mvc;
using Server.Repositories;

namespace Server.Controllers;

[ApiController]
[Route("/")]
public class CustomerController : ControllerBase
{
    private readonly CustomerRepository _repository;

    public CustomerController(CustomerRepository repo)
    {
        _repository = repo;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var customer = _repository.GetById(id);
        return customer is not null ? Ok(customer) : NotFound();
    }
}
