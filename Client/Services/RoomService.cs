using MovieMatch_Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Client.Services
{
    public class RoomService : IRoomService
    {
        private readonly HttpClient _httpClient;

        public RoomService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ServiceResponse<Room>> CreateRoom(User user)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("/api/room/create", user);
                return await result.Content.ReadFromJsonAsync<ServiceResponse<Room>>();
            } catch(Exception e)
            {
                return new ServiceResponse<Room>
                {
                    Message = e.Message,
                    Success = false,
                };
            }

        }
        public async Task<ServiceResponse<Room>> JoinRoom(IAppState state)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("/api/room/join", state);
                return await result.Content.ReadFromJsonAsync<ServiceResponse<Room>>();
            }
            catch (Exception e)
            {
                return new ServiceResponse<Room>
                {
                    Message = e.Message,
                    Success = false,
                };
            }

        }
    }
}
