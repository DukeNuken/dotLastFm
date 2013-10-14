//-----------------------------------------------------------------------
// <copyright file="IArtistApi.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api
{
    using System.Collections.Generic;

    using Models;

    /// <summary>
    /// Last.fm artist API
    /// </summary>
    public interface IArtistApi
    {
        /// <summary>
        /// Get the top tags for an artist on Last.fm, ordered by popularity.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param>
        /// <returns>List of TopTags objects.</returns>
        IEnumerable<TopTag> GetTopTags(string artist, bool autocorrect);

        /// <summary>
        /// Get the top tags for an artist on Last.fm, ordered by popularity.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <returns>List of TopTags objects.</returns>
        IEnumerable<TopTag> GetTopTags(string artist);

        /// <summary>
        /// Get the metadata for an artist. Includes biography.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="autocorrect">Transform misspelled artist names into correct artis name, returning the correct version instead.</param>
        /// <param name="username">The username for the context of the request. If supplied, the user's playcount for this track and whether they have loved the track is included in the response.</param>
        /// <returns>The Artist object with metadata.</returns>
        ArtistWithDetails GetInfo(string artist, bool autocorrect, string username);

        /// <summary>
        /// Get the metadata for an artist. Includes biography.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <returns>The Artist object with metadata.</returns>
        ArtistWithDetails GetInfo(string artist);

        /// <summary>
        /// Get the metadata for an artist. Includes biography.
        /// </summary>
        /// <param name="mbid">The artist key.</param>
        /// <returns>The Artist object with metadata.</returns>
        ArtistWithDetails GetInfo(string mbid, string lang = "");

        /// <summary>
        /// Get top albums for an artist.
        /// </summary>
        /// <param name="mbid">The musicbrainz id for the artist</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <returns>List of albums.</returns>
        IEnumerable<TagTopAlbum> GetTopAlbums(string mbid, int limit);

        /// <summary>
        /// Get top albums for an artist.
        /// </summary>
        /// <param name="name">The artist name.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <param name="autocorrect">Transform misspelled artist names into correct artist names, returning the correct version instead. The corrected artist name will be returned in the response.s</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <returns>List of albums.</returns>
        IEnumerable<TagTopAlbum> GetTopAlbums(string name, int page, bool autocorrect, int limit);


        /// <summary>
        /// Get top tracks for an artist.
        /// </summary>
        /// <param name="mbid">The artist name.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <returns>List of tracks.</returns>
        IEnumerable<TagTopTrack> GetTopTracks(string mbid, int page, int limit);

        /// <summary>
        /// Get top tracks for an artist.
        /// </summary>
        /// <param name="name">The artist name.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <param name="autocorrect">Transform misspelled artist names into correct artist names, returning the correct version instead. The corrected artist name will be returned in the response.s</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <returns>List of tracks.</returns>
        IEnumerable<TagTopTrack> GetTopTracks(string name, int page, bool autocorrect, int limit);
    }
}
