using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServerCascadingDropdowns.Models;

namespace BlazorServerCascadingDropdowns.Services
{
    public interface IVideoGameService
    {
        Task<List<Platform>> GetPlataformAsync();
        Task<List<Genre>> GetGenresByPlatformAsync(int platformId);
        Task<List<VideoGame>> GetVideoGameByPlataformGenreAsync(int platformId, int genreId);
    }
}