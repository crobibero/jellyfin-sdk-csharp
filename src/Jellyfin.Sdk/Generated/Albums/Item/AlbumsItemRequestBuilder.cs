// <auto-generated/>
using Jellyfin.Sdk.Generated.Albums.Item.InstantMix;
using Jellyfin.Sdk.Generated.Albums.Item.Similar;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Albums.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Albums\{Albums-id}
    /// </summary>
    public class AlbumsItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The InstantMix property</summary>
        public InstantMixRequestBuilder InstantMix { get =>
            new InstantMixRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Similar property</summary>
        public SimilarRequestBuilder Similar { get =>
            new SimilarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AlbumsItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlbumsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Albums/{Albums%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AlbumsItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlbumsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Albums/{Albums%2Did}", rawUrl) {
        }
    }
}