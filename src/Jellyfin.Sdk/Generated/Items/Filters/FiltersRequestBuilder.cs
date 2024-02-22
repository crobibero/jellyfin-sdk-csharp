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
namespace Jellyfin.Sdk.Generated.Items.Filters {
    /// <summary>
    /// Builds and executes requests for operations under \Items\Filters
    /// </summary>
    public class FiltersRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new FiltersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FiltersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/Filters{?includeItemTypes*,mediaTypes*,parentId*,userId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new FiltersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FiltersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/Filters{?includeItemTypes*,mediaTypes*,parentId*,userId*}", rawUrl) {
        }
        /// <summary>
        /// Gets legacy query filters.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<QueryFiltersLegacy?> GetAsync(Action<RequestConfiguration<FiltersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<QueryFiltersLegacy> GetAsync(Action<RequestConfiguration<FiltersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<QueryFiltersLegacy>(requestInfo, QueryFiltersLegacy.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets legacy query filters.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<FiltersRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<FiltersRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public FiltersRequestBuilder WithUrl(string rawUrl) {
            return new FiltersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets legacy query filters.
        /// </summary>
        public class FiltersRequestBuilderGetQueryParameters {
            /// <summary>Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("includeItemTypes")]
            public string[]? IncludeItemTypes { get; set; }
#nullable restore
#else
            [QueryParameter("includeItemTypes")]
            public string[] IncludeItemTypes { get; set; }
#endif
            /// <summary>Optional. Filter by MediaType. Allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("mediaTypes")]
            public string[]? MediaTypes { get; set; }
#nullable restore
#else
            [QueryParameter("mediaTypes")]
            public string[] MediaTypes { get; set; }
#endif
            /// <summary>Optional. Parent id.</summary>
            [QueryParameter("parentId")]
            public Guid? ParentId { get; set; }
            /// <summary>Optional. User id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class FiltersRequestBuilderGetRequestConfiguration : RequestConfiguration<FiltersRequestBuilderGetQueryParameters> {
        }
    }
}