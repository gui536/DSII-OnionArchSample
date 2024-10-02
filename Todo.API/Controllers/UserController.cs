using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Todo.API.Adapter;
using Todo.API.Models;

namespace Todo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserAdapter _userAdapter;
        
        public UserController() {
            _userAdapter = new UserAdapter();
        }

        [HttpPost("batch")]
        public async Task<IActionResult> Add(List<UserModel> model)
        {
            var user = _userAdapter.Map(model);
            return Ok(user);
        }


        [HttpPost]
        public async Task<IActionResult> Add(UserModel model)
        {
            var user = _userAdapter.Map(model);
            return Ok(user);
        }

public async Task<IActionResult> Get()
        {
            var user = new User();
            var model = _userAdapter.Map(user);
            return Ok(model);
        }

    }
}
