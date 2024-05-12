// <auto-generated/>
using Jellyfin.Sdk.Generated.Videos.Item.Trickplay.Item.TilesM3u8;
using Jellyfin.Sdk.Generated.Videos.Item.Trickplay.Item.WithIndexJpg;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.Trickplay.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{item-id}\Trickplay\{width}
    /// </summary>
    public class WithWidthItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The tilesM3u8 property</summary>
        public TilesM3u8RequestBuilder TilesM3u8
        {
            get => new TilesM3u8RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithWidthItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWidthItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/Trickplay/{width}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithWidthItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWidthItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/Trickplay/{width}", rawUrl)
        {
        }
        /// <summary>
        /// Builds and executes requests for operations under \Videos\{item-id}\Trickplay\{width}\{index}.jpg
        /// </summary>
        /// <returns>A <see cref="WithIndexJpgRequestBuilder"/></returns>
        /// <param name="index">The index of the desired tile.</param>
        public WithIndexJpgRequestBuilder WithIndexJpg(int? index)
        {
            _ = index ?? throw new ArgumentNullException(nameof(index));
            return new WithIndexJpgRequestBuilder(PathParameters, RequestAdapter, index);
        }
    }
}
