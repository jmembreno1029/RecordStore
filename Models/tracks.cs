﻿using System;
using System.Collections.Generic;

namespace SWD104Final.Models
{
    public partial class tracks
    {
        public long TrackId { get; set; }
        public string Name { get; set; }
        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public string UnitPrice { get; set; }

        public albums Album { get; set; }
    }
}
