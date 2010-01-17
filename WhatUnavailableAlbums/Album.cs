using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatUnavailableAlbums
{
    class Album
    {
        public Album(string artist, string album)
        {
            mArtist = artist;
            mAlbum = album;
        }

        string mAlbum;
        public string AlbumName
        {
            get { return mAlbum; }
        }

        string mArtist;
        public string ArtistName
        {
            get { return mArtist; }
        }

        public string StringRepresentation { get { return ArtistName + " - " + AlbumName; } }

        public override string ToString()
        {
            return StringRepresentation;
        }
    }
}
