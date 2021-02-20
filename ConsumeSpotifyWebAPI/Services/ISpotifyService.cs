using ConsumeSpotifyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSpotifyWebAPI.Services
{
    public interface ISpotifyService
    {
        Task<IEnumerable<Release>> GetNewReleases(string countryCode, int limit, string accessToken);
    }
}
