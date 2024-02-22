// <auto-generated/>
using Jellyfin.Sdk.Generated.Users.Item.PlayedItems.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Users.Item.PlayedItems {
    /// <summary>
    /// Builds and executes requests for operations under \Users\{userId}\PlayedItems
    /// </summary>
    public class PlayedItemsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Users.item.PlayedItems.item collection</summary>
        /// <param name="position">Item id.</param>
        public WithItemItemRequestBuilder this[Guid position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("itemId", position);
            return new WithItemItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Users.item.PlayedItems.item collection</summary>
        /// <param name="position">Item id.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithItemItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("itemId", position);
            return new WithItemItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new PlayedItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlayedItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/{userId}/PlayedItems", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PlayedItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlayedItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/{userId}/PlayedItems", rawUrl) {
        }
    }
}