using MovieMatch_Blazor.Shared;
using MovieMatch_Blazor.Shared.Services;
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

        public async Task<ServiceResponse<AppState>> CreateRoom(IAppState state)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("/api/room/create", state);
                return await result.Content.ReadFromJsonAsync<ServiceResponse<AppState>>();
            } catch(Exception e)
            {
                return new ServiceResponse<AppState>
                {
                    Message = e.Message,
                    Success = false,
                };
            }
        }

        public async Task<ServiceResponse<AppState>> JoinRoom(IAppState state)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("/api/room/join", state);
                return await result.Content.ReadFromJsonAsync<ServiceResponse<AppState>>();
            }
            catch (Exception e)
            {
                return new ServiceResponse<AppState>
                {
                    Message = e.Message,
                    Success = false,
                };
            }

        }
    }
}
