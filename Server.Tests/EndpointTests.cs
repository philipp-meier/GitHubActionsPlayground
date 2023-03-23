using System;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers;
using Server.Repositories;
using Xunit;

namespace Server.Tests;

public class EndpointTests
{
    private readonly CustomerController _controller;
    private readonly CustomerRepository _repository;

    public EndpointTests()
    {
        _repository = new CustomerRepository();
        _controller = new CustomerController(_repository);
    }

    [Fact]
    public void GetCustomerById_ReturnCustomer_WhenCustomerExists()
    {
        var result = _controller.GetById(Guid.Parse("61f57488-aa3d-41ff-b844-15824771d773"));
        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void GetCustomerById_ReturnNotFound_WhenCustomerDoesNotExist()
    {
        var result = _controller.GetById(System.Guid.Empty);
        Assert.IsType<NotFoundResult>(result);
    }
}