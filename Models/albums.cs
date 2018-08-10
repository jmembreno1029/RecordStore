using System;
using System.Collections.Generic;

namespace SWD104Final.Models
{
    public partial class albums
    {
        public albums()
        {
            tracks = new HashSet<tracks>();
        }

        public long AlbumId { get; set; }
        public string Title { get; set; }
        public long ArtistId { get; set; }

        public artists Artist { get; set; }
        public ICollection<tracks> tracks { get; set; }
    }
}
