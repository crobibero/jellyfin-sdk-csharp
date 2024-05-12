// <auto-generated/>
using Jellyfin.Sdk.Generated.Videos.Item.Hls1.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.Hls1 {
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{item-id}\hls1
    /// </summary>
    public class Hls1RequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Videos.item.hls1.item collection</summary>
        /// <param name="position">The playlist id.</param>
        /// <returns>A <see cref="WithPlaylistItemRequestBuilder"/></returns>
        public WithPlaylistItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("playlistId", position);
                return new WithPlaylistItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Hls1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Hls1RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/hls1", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Hls1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Hls1RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/hls1", rawUrl)
        {
        }
    }
}
