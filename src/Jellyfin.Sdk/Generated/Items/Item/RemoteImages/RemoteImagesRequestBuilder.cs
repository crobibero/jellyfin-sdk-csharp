// <auto-generated/>
using Jellyfin.Sdk.Generated.Items.Item.RemoteImages.Download;
using Jellyfin.Sdk.Generated.Items.Item.RemoteImages.Providers;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Items.Item.RemoteImages {
    /// <summary>
    /// Builds and executes requests for operations under \Items\{itemId}\RemoteImages
    /// </summary>
    public class RemoteImagesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The Download property</summary>
        public DownloadRequestBuilder Download
        {
            get => new DownloadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Providers property</summary>
        public ProvidersRequestBuilder Providers
        {
            get => new ProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="RemoteImagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RemoteImagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/RemoteImages{?includeAllLanguages*,limit*,providerName*,startIndex*,type*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RemoteImagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RemoteImagesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/RemoteImages{?includeAllLanguages*,limit*,providerName*,startIndex*,type*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets available remote images for an item.
        /// </summary>
        /// <returns>A <see cref="RemoteImageResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ProblemDetails">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RemoteImageResult?> GetAsync(Action<RequestConfiguration<RemoteImagesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<RemoteImageResult> GetAsync(Action<RequestConfiguration<RemoteImagesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", ProblemDetails.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RemoteImageResult>(requestInfo, RemoteImageResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets available remote images for an item.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RemoteImagesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RemoteImagesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="RemoteImagesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RemoteImagesRequestBuilder WithUrl(string rawUrl)
        {
            return new RemoteImagesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets available remote images for an item.
        /// </summary>
        public class RemoteImagesRequestBuilderGetQueryParameters 
        {
            /// <summary>Optional. Include all languages.</summary>
            [QueryParameter("includeAllLanguages")]
            public bool? IncludeAllLanguages { get; set; }
            /// <summary>Optional. The maximum number of records to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Optional. The image provider to use.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("providerName")]
            public string? ProviderName { get; set; }
#nullable restore
#else
            [QueryParameter("providerName")]
            public string ProviderName { get; set; }
#endif
            /// <summary>Optional. The record index to start at. All items with a lower index will be dropped from the results.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
            /// <summary>The image type.</summary>
            [QueryParameter("type")]
            public GetTypeQueryParameterType? Type { get; set; }
        }
    }
}
