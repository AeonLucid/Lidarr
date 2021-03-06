﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NzbDrone.Core.MetadataSource.SkyHook.Resource
{
    public class TrackInfoResource
    {
        public TrackInfoResource()
        {

        }

        public int DiscNumber { get; set; }
        public int DurationMs { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int TrackNumber { get; set; }
        public bool Explicit { get; set; }
        public List<ArtistInfoResource> Artists { get; set; }

    }
}
