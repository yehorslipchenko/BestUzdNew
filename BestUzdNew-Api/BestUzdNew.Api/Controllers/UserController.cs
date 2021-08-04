using AutoMapper;
using BestUzdNew.Api.Dtos.Input;
using BestUzdNew.Domain.Entities;
using BestUzdNew.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestUzdNew.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserInDto userInDto)
        {
            var user = _mapper.Map<UserInDto, User>(userInDto);
            await _userService.CreateUserAsync(user);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsersAsync();
            var usersDto = _mapper.Map<IEnumerable<User>, IEnumerable<UserInDto>>(users);

            return Ok(usersDto);
        }
    }
}
