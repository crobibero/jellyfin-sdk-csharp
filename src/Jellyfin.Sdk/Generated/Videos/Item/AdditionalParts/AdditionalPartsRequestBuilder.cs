// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.AdditionalParts {
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{item-id}\AdditionalParts
    /// </summary>
    public class AdditionalPartsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="AdditionalPartsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdditionalPartsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/AdditionalParts{?userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AdditionalPartsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdditionalPartsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/AdditionalParts{?userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets additional parts for a video.
        /// </summary>
        /// <returns>A <see cref="BaseItemDtoQueryResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<AdditionalPartsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<AdditionalPartsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets additional parts for a video.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AdditionalPartsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AdditionalPartsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="AdditionalPartsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AdditionalPartsRequestBuilder WithUrl(string rawUrl)
        {
            return new AdditionalPartsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets additional parts for a video.
        /// </summary>
        public class AdditionalPartsRequestBuilderGetQueryParameters 
        {
            /// <summary>Optional. Filter by user id, and attach user data.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
