﻿using NzbDrone.Core.Datastore;
using NzbDrone.Core.MediaFiles;
using Marr.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NzbDrone.Common.Extensions;

namespace NzbDrone.Core.Music
{
    public class Track : ModelBase
    {
        public Track()
        {
        }

        public const string RELEASE_DATE_FORMAT = "yyyy-MM-dd";

        public int SpotifyTrackId { get; set; }
        public string AlbumId { get; set; }
        public LazyLoaded<Artist> Artist { get; set; }
        public string ArtistId { get; set; }
        public int CompilationId { get; set; }
        public bool Compilation { get; set; }
        public int TrackNumber { get; set; }
        public string Title { get; set; }
        public bool Ignored { get; set; }
        public bool Explict { get; set; }
        public string TrackExplicitName { get; set; }
        public string TrackCensoredName { get; set; }
        public bool Monitored { get; set; }
        public int TrackFileId { get; set; } 
        public DateTime? ReleaseDate { get; set; }
        /*
        public Ratings Ratings { get; set; } // This might be aplicable as can be pulled from IDv3 tags
        public List<MediaCover.MediaCover> Images { get; set; }*/

        //public string SeriesTitle { get; private set; }

        public LazyLoaded<TrackFile> TrackFile { get; set; }

        public Album Album { get; set; }

        public bool HasFile => TrackFileId > 0;

        public override string ToString()
        {
            return string.Format("[{0}]{1}", SpotifyTrackId, Title.NullSafe());
        }
    }
}
