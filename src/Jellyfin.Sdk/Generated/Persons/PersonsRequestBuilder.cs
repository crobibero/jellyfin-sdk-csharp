// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.Persons.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Persons {
    /// <summary>
    /// Builds and executes requests for operations under \Persons
    /// </summary>
    public class PersonsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Persons.item collection</summary>
        /// <param name="position">Person name.</param>
        public WithNameItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("name", position);
            return new WithNameItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new PersonsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PersonsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Persons{?appearsInItemId*,enableImages*,enableImageTypes*,enableUserData*,excludePersonTypes*,fields*,filters*,imageTypeLimit*,isFavorite*,limit*,personTypes*,searchTerm*,userId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PersonsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PersonsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Persons{?appearsInItemId*,enableImages*,enableImageTypes*,enableUserData*,excludePersonTypes*,fields*,filters*,imageTypeLimit*,isFavorite*,limit*,personTypes*,searchTerm*,userId*}", rawUrl) {
        }
        /// <summary>
        /// Gets all persons.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<PersonsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<PersonsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets all persons.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PersonsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PersonsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public PersonsRequestBuilder WithUrl(string rawUrl) {
            return new PersonsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets all persons.
        /// </summary>
        public class PersonsRequestBuilderGetQueryParameters {
            /// <summary>Optional. If specified, person results will be filtered on items related to said persons.</summary>
            [QueryParameter("appearsInItemId")]
            public Guid? AppearsInItemId { get; set; }
            /// <summary>Optional, include image information in output.</summary>
            [QueryParameter("enableImages")]
            public bool? EnableImages { get; set; }
            /// <summary>Optional. The image types to include in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("enableImageTypes")]
            public string[]? EnableImageTypes { get; set; }
#nullable restore
#else
            [QueryParameter("enableImageTypes")]
            public string[] EnableImageTypes { get; set; }
#endif
            /// <summary>Optional, include user data.</summary>
            [QueryParameter("enableUserData")]
            public bool? EnableUserData { get; set; }
            /// <summary>Optional. If specified results will be filtered to exclude those containing the specified PersonType. Allows multiple, comma-delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("excludePersonTypes")]
            public string[]? ExcludePersonTypes { get; set; }
#nullable restore
#else
            [QueryParameter("excludePersonTypes")]
            public string[] ExcludePersonTypes { get; set; }
#endif
            /// <summary>Optional. Specify additional fields of information to return in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string[] Fields { get; set; }
#endif
            /// <summary>Optional. Specify additional filters to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filters")]
            public string[]? Filters { get; set; }
#nullable restore
#else
            [QueryParameter("filters")]
            public string[] Filters { get; set; }
#endif
            /// <summary>Optional, the max number of images to return, per image type.</summary>
            [QueryParameter("imageTypeLimit")]
            public int? ImageTypeLimit { get; set; }
            /// <summary>Optional filter by items that are marked as favorite, or not. userId is required.</summary>
            [QueryParameter("isFavorite")]
            public bool? IsFavorite { get; set; }
            /// <summary>Optional. The maximum number of records to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Optional. If specified results will be filtered to include only those containing the specified PersonType. Allows multiple, comma-delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("personTypes")]
            public string[]? PersonTypes { get; set; }
#nullable restore
#else
            [QueryParameter("personTypes")]
            public string[] PersonTypes { get; set; }
#endif
            /// <summary>The search term.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("searchTerm")]
            public string? SearchTerm { get; set; }
#nullable restore
#else
            [QueryParameter("searchTerm")]
            public string SearchTerm { get; set; }
#endif
            /// <summary>User id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class PersonsRequestBuilderGetRequestConfiguration : RequestConfiguration<PersonsRequestBuilderGetQueryParameters> {
        }
    }
}