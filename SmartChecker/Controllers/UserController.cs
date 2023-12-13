using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using SmartChecker.Brokers.Storages;
using SmartChecker.Models.Users;

namespace SmartChecker.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UserController : RESTFulController
{
    private readonly IStorageBroker storageBroker;

    public UserController(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }
[HttpPost]
    public async ValueTask<ActionResult<User>> AddUser(User user)
    {
        var persistedUser = this.storageBroker.InsertUserAsync(user);
        return Created(persistedUser);
    }
}