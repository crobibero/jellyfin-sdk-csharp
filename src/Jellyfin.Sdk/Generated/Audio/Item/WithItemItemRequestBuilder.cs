// <auto-generated/>
using Jellyfin.Sdk.Generated.Audio.Item.Hls1;
using Jellyfin.Sdk.Generated.Audio.Item.Hls;
using Jellyfin.Sdk.Generated.Audio.Item.Lyrics;
using Jellyfin.Sdk.Generated.Audio.Item.MainM3u8;
using Jellyfin.Sdk.Generated.Audio.Item.MasterM3u8;
using Jellyfin.Sdk.Generated.Audio.Item.RemoteSearch;
using Jellyfin.Sdk.Generated.Audio.Item.StreamNamespace;
using Jellyfin.Sdk.Generated.Audio.Item.StreamWithContainer;
using Jellyfin.Sdk.Generated.Audio.Item.Universal;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Audio.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Audio\{itemId}
    /// </summary>
    public class WithItemItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The hls property</summary>
        public HlsRequestBuilder Hls
        {
            get => new HlsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hls1 property</summary>
        public Hls1RequestBuilder Hls1
        {
            get => new Hls1RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Lyrics property</summary>
        public LyricsRequestBuilder Lyrics
        {
            get => new LyricsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mainM3u8 property</summary>
        public MainM3u8RequestBuilder MainM3u8
        {
            get => new MainM3u8RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The masterM3u8 property</summary>
        public MasterM3u8RequestBuilder MasterM3u8
        {
            get => new MasterM3u8RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The RemoteSearch property</summary>
        public RemoteSearchRequestBuilder RemoteSearch
        {
            get => new RemoteSearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stream property</summary>
        public StreamRequestBuilder Stream
        {
            get => new StreamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The universal property</summary>
        public UniversalRequestBuilder Universal
        {
            get => new UniversalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Audio/{itemId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithItemItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Audio/{itemId}", rawUrl)
        {
        }
        /// <summary>
        /// Builds and executes requests for operations under \Audio\{itemId}\stream.{container}
        /// </summary>
        /// <returns>A <see cref="StreamWithContainerRequestBuilder"/></returns>
        /// <param name="container">The audio container.</param>
        public StreamWithContainerRequestBuilder StreamWithContainer(string container)
        {
            if(string.IsNullOrEmpty(container)) throw new ArgumentNullException(nameof(container));
            return new StreamWithContainerRequestBuilder(PathParameters, RequestAdapter, container);
        }
    }
}
