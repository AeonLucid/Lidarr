﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NzbDrone.Core.MetadataSource.SkyHook.Resource
{
    public class AlbumInfoResource
    {
        public AlbumInfoResource()
        {

        }
        public string AlbumType { get; set; } // Might need to make this a separate class
        public List<ArtistInfoResource> Artists { get; set; } // Will always be length of 1 unless a compilation
        public string Url { get; set; } // Link to the endpoint api to give full info for this object
        public string Id { get; set; } // This is a unique Album ID. Needed for all future API calls
        public List<ImageResource> Images { get; set; }
        public string Name { get; set; } // In case of a takedown, this may be empty
    }

    
}
