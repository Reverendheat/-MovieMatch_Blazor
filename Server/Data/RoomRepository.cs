using MovieMatch_Blazor.Client.Services;
using Microsoft.EntityFrameworkCore;
using MovieMatch_Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Server.Data
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;

        public RoomRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Room>> CreateRoom(User user)
        {
            try
            {
                var room = new Room { Users = new List<User>() };
                room.RoomCode = Guid.NewGuid().ToString();
                room.Users.Add(user);
                await _context.Rooms.AddAsync(room);
                await _context.SaveChangesAsync();
                return new ServiceResponse<Room>
                {
                    Data = room,
                    Message = "Room created successfully",
                    Success = true,
                };
            } catch (Exception e)
            {
                return new ServiceResponse<Room>
                {
                    Message = e.Message,
                    Success = false,
                };
            }

        }
        public async Task<ServiceResponse<Room>> RegisterUser(IAppState state)
        {
            try
            {
                //Grab the room and if its not full add the user.
                var room = await _context.Rooms.Include(x=>x.Users).FirstOrDefaultAsync(x=>x.RoomCode == state.room.RoomCode);
                if (room.Users.Any(u=>u.UserCode == state.user.UserCode))
                {
                    //Welcome back
                    return new ServiceResponse<Room>
                    {
                        Data = room,
                        Message = "Welcome back",
                        Success = true
                    };
                } else if (room.Users.Count == 5)
                {
                    //Room is full
                    return new ServiceResponse<Room>
                    {
                        Message = "Room is currently full",
                        Success = false
                    };
                } else
                {
                    //Add to room
                    room.Users.Add(state.user);
                    _context.Update(room);
                    return new ServiceResponse<Room>
                    {
                        Data = room,
                        Message = "Welcome",
                        Success = true
                    };
                }
            }
            catch (Exception e)
            {
                return new ServiceResponse<Room>
                {
                    Message = e.Message,
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<Room>> JoinRoom(IAppState state)
        {
            try
            {
                var room = await _context.Rooms.Include(x => x.Users).FirstOrDefaultAsync(x => x.RoomCode == state.room.RoomCode);
                //Are you already in the room?
                if (room.Users.Any(u => u.UserCode == state.user.UserCode))
                {
                    //Welcome back
                    return new ServiceResponse<Room>
                    {
                        Data = room,
                        Message = "Welcome back",
                        Success = true
                    };
                }
                else if (room.Users.Count == 5)
                {
                    //Room is full
                    return new ServiceResponse<Room>
                    {
                        Message = "Room is currently full",
                        Success = false
                    };
                }
                else
                {
                    //Add to room
                    room.Users.Add(state.user);
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                    return new ServiceResponse<Room>
                    {
                        Data = room,
                        Message = "Welcome",
                        Success = true
                    };
                }
            } catch(Exception e)
            {
                return new ServiceResponse<Room>
                {
                    Message = e.Message,
                    Success = false
                };
            }
        }
    }
}
