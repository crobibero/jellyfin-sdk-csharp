// <auto-generated/>
using Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Items\{itemId}\Images\{imageType}\{imageIndex}\{tag}\{format}\{maxWidth}\{maxHeight}\{percentPlayed}
    /// </summary>
    public class WithPercentPlayedItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Items.item.Images.item.item.item.item.item.item.item.item collection</summary>
        /// <param name="position">Optional. Unplayed count overlay to render.</param>
        public WithUnplayedCountItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("unplayedCount", position);
            return new WithUnplayedCountItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Items.item.Images.item.item.item.item.item.item.item.item collection</summary>
        /// <param name="position">Optional. Unplayed count overlay to render.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithUnplayedCountItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("unplayedCount", position);
            return new WithUnplayedCountItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithPercentPlayedItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPercentPlayedItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}/{format}/{maxWidth}/{maxHeight}/{percentPlayed}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithPercentPlayedItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPercentPlayedItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}/{format}/{maxWidth}/{maxHeight}/{percentPlayed}", rawUrl) {
        }
    }
}