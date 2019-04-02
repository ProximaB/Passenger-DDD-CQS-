using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public interface IDriverService : IService
    {
        Task<DriverDetailsDto> GetAsync(Guid userId);
        Task<IEnumerable<DriverDto>> BrowseAsync();
        Task CreateAsync(Guid userId);
        Task SetVehicle(Guid userId, string brand, string name);
        Task DeleteAsync(Guid userId);
    }
}