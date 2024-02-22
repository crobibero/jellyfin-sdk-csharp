// <auto-generated/>
using Jellyfin.Sdk.Generated.Shows.Item;
using Jellyfin.Sdk.Generated.Shows.NextUp;
using Jellyfin.Sdk.Generated.Shows.Upcoming;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Shows {
    /// <summary>
    /// Builds and executes requests for operations under \Shows
    /// </summary>
    public class ShowsRequestBuilder : BaseRequestBuilder {
        /// <summary>The NextUp property</summary>
        public NextUpRequestBuilder NextUp { get =>
            new NextUpRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Upcoming property</summary>
        public UpcomingRequestBuilder Upcoming { get =>
            new UpcomingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Shows.item collection</summary>
        /// <param name="position">The item id.</param>
        public ShowsItemRequestBuilder this[Guid position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("Shows%2Did", position);
            return new ShowsItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Shows.item collection</summary>
        /// <param name="position">The item id.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public ShowsItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("Shows%2Did", position);
            return new ShowsItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ShowsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ShowsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Shows", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ShowsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ShowsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Shows", rawUrl) {
        }
    }
}