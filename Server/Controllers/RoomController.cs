using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMatch_Blazor.Shared.Services;
using MovieMatch_Blazor.Server.Data;
using MovieMatch_Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepository _roomRepo;

        public RoomController(IRoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateRoom(AppState state)
        {
            var response = await _roomRepo.CreateRoom(state);
            return response.Success ? Ok(response) : BadRequest(response);
        }
        [HttpPost("join")]
        public async Task<IActionResult> JoinRoom(AppState state)
        {
            var response = await _roomRepo.JoinRoom(state);
            return response.Success ? Ok(response) : BadRequest(response);
        }
    }
}
