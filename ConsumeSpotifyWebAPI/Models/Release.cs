using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSpotifyWebAPI.Models
{
    public class Release
    {
        public string Name { get; set; }
        public string Artists { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }
    }
}
