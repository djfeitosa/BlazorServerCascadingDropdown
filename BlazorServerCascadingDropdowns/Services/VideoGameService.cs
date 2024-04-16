using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServerCascadingDropdowns.Models;

namespace BlazorServerCascadingDropdowns.Services
{
    public class VideoGameService : IVideoGameService
    {
        private readonly List<Platform> platforms = new() {
            new Platform { Id = 1, Name = "PC",},
            new Platform { Id = 2, Name = "PlayStation 5",},
            new Platform { Id = 3, Name = "Xbox Series X",},
        };

        private readonly List<Genre> genres = new() {
            new Genre { Id = 1, Name = "Action", PlatformId = 1},
            new Genre { Id = 2, Name = "RPG", PlatformId = 1},
            new Genre { Id = 3, Name = "Sports", PlatformId = 2},
            new Genre { Id = 4, Name = "Adventure", PlatformId = 3},
        };

        private readonly List<VideoGame> videoGames = new() {
            new VideoGame { Id = 1, Title="Cyberpunk 2077", PlatformId = 1, genreId = 1},
            new VideoGame { Id = 2, Title="The Witcher 3: Wild Hunt", PlatformId = 1, genreId = 1},
            new VideoGame { Id = 3, Title="NHL 24", PlatformId = 2, genreId = 2},
            new VideoGame { Id = 4, Title="Gran Turismo 7", PlatformId = 2, genreId = 2},
            new VideoGame { Id = 5, Title="Return to Monkey Island", PlatformId = 3, genreId = 3},
            new VideoGame { Id = 6, Title="It Take Two", PlatformId = 3, genreId = 3},
        };


        public Task<List<Genre>> GetGenresByPlatformAsync(int platformId)
        {
            var filteredGenres = genres.Where(x => x.PlatformId == platformId).ToList();
            return Task.FromResult(filteredGenres);
        }

        public Task<List<Platform>> GetPlataformAsync()
        {
            return Task.FromResult(platforms);
        }

        public Task<List<VideoGame>> GetVideoGameByPlataformGenreAsync(int platformId, int genreId)
        {
            var filteredVideoGames = videoGames.Where(x => x.PlatformId == platformId && x.genreId == genreId).ToList();
            return Task.FromResult(filteredVideoGames);
        }
    }
}