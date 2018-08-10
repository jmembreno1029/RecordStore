using System;
using System.Collections.Generic;

namespace SWD104Final.Models
{
    public partial class artists
    {
        public artists()
        {
            albums = new HashSet<albums>();
        }

        public long ArtistId { get; set; }
        public string Name { get; set; }

        public ICollection<albums> albums { get; set; }
    }
}
