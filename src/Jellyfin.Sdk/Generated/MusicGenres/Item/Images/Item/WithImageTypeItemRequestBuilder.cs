// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.MusicGenres.Item.Images.Item.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.MusicGenres.Item.Images.Item {
    /// <summary>
    /// Builds and executes requests for operations under \MusicGenres\{name}\Images\{imageType}
    /// </summary>
    public class WithImageTypeItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.MusicGenres.item.Images.item.item collection</summary>
        /// <param name="position">Image index.</param>
        public WithImageIndexItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("imageIndex", position);
            return new WithImageIndexItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.MusicGenres.item.Images.item.item collection</summary>
        /// <param name="position">Image index.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithImageIndexItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("imageIndex", position);
            return new WithImageIndexItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithImageTypeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithImageTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/MusicGenres/{name}/Images/{imageType}{?addPlayedIndicator*,backgroundColor*,blur*,cropWhitespace*,fillHeight*,fillWidth*,foregroundLayer*,format*,height*,imageIndex*,maxHeight*,maxWidth*,percentPlayed*,quality*,tag*,unplayedCount*,width*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithImageTypeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithImageTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/MusicGenres/{name}/Images/{imageType}{?addPlayedIndicator*,backgroundColor*,blur*,cropWhitespace*,fillHeight*,fillWidth*,foregroundLayer*,format*,height*,imageIndex*,maxHeight*,maxWidth*,percentPlayed*,quality*,tag*,unplayedCount*,width*}", rawUrl) {
        }
        /// <summary>
        /// Get music genre image by name.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<WithImageTypeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<WithImageTypeItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", ProblemDetails.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get music genre image by name.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> HeadAsync(Action<RequestConfiguration<WithImageTypeItemRequestBuilderHeadQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> HeadAsync(Action<RequestConfiguration<WithImageTypeItemRequestBuilderHeadQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToHeadRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", ProblemDetails.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get music genre image by name.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithImageTypeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithImageTypeItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "image/*, application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Get music genre image by name.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToHeadRequestInformation(Action<RequestConfiguration<WithImageTypeItemRequestBuilderHeadQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToHeadRequestInformation(Action<RequestConfiguration<WithImageTypeItemRequestBuilderHeadQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.HEAD, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "image/*, application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithImageTypeItemRequestBuilder WithUrl(string rawUrl) {
            return new WithImageTypeItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get music genre image by name.
        /// </summary>
        public class WithImageTypeItemRequestBuilderGetQueryParameters {
            /// <summary>Optional. Add a played indicator.</summary>
            [QueryParameter("addPlayedIndicator")]
            public bool? AddPlayedIndicator { get; set; }
            /// <summary>Optional. Apply a background color for transparent images.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("backgroundColor")]
            public string? BackgroundColor { get; set; }
#nullable restore
#else
            [QueryParameter("backgroundColor")]
            public string BackgroundColor { get; set; }
#endif
            /// <summary>Optional. Blur image.</summary>
            [QueryParameter("blur")]
            public int? Blur { get; set; }
            /// <summary>Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art.</summary>
            [Obsolete("")]
            [QueryParameter("cropWhitespace")]
            public bool? CropWhitespace { get; set; }
            /// <summary>Height of box to fill.</summary>
            [QueryParameter("fillHeight")]
            public int? FillHeight { get; set; }
            /// <summary>Width of box to fill.</summary>
            [QueryParameter("fillWidth")]
            public int? FillWidth { get; set; }
            /// <summary>Optional. Apply a foreground layer on top of the image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("foregroundLayer")]
            public string? ForegroundLayer { get; set; }
#nullable restore
#else
            [QueryParameter("foregroundLayer")]
            public string ForegroundLayer { get; set; }
#endif
            /// <summary>Determines the output format of the image - original,gif,jpg,png.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("format")]
            public string Format { get; set; }
#endif
            /// <summary>The fixed image height to return.</summary>
            [QueryParameter("height")]
            public int? Height { get; set; }
            /// <summary>Image index.</summary>
            [QueryParameter("imageIndex")]
            public int? ImageIndex { get; set; }
            /// <summary>The maximum image height to return.</summary>
            [QueryParameter("maxHeight")]
            public int? MaxHeight { get; set; }
            /// <summary>The maximum image width to return.</summary>
            [QueryParameter("maxWidth")]
            public int? MaxWidth { get; set; }
            /// <summary>Optional. Percent to render for the percent played overlay.</summary>
            [QueryParameter("percentPlayed")]
            public double? PercentPlayed { get; set; }
            /// <summary>Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases.</summary>
            [QueryParameter("quality")]
            public int? Quality { get; set; }
            /// <summary>Optional. Supply the cache tag from the item object to receive strong caching headers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tag")]
            public string? Tag { get; set; }
#nullable restore
#else
            [QueryParameter("tag")]
            public string Tag { get; set; }
#endif
            /// <summary>Optional. Unplayed count overlay to render.</summary>
            [QueryParameter("unplayedCount")]
            public int? UnplayedCount { get; set; }
            /// <summary>The fixed image width to return.</summary>
            [QueryParameter("width")]
            public int? Width { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithImageTypeItemRequestBuilderGetRequestConfiguration : RequestConfiguration<WithImageTypeItemRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Get music genre image by name.
        /// </summary>
        public class WithImageTypeItemRequestBuilderHeadQueryParameters {
            /// <summary>Optional. Add a played indicator.</summary>
            [QueryParameter("addPlayedIndicator")]
            public bool? AddPlayedIndicator { get; set; }
            /// <summary>Optional. Apply a background color for transparent images.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("backgroundColor")]
            public string? BackgroundColor { get; set; }
#nullable restore
#else
            [QueryParameter("backgroundColor")]
            public string BackgroundColor { get; set; }
#endif
            /// <summary>Optional. Blur image.</summary>
            [QueryParameter("blur")]
            public int? Blur { get; set; }
            /// <summary>Optional. Specify if whitespace should be cropped out of the image. True/False. If unspecified, whitespace will be cropped from logos and clear art.</summary>
            [Obsolete("")]
            [QueryParameter("cropWhitespace")]
            public bool? CropWhitespace { get; set; }
            /// <summary>Height of box to fill.</summary>
            [QueryParameter("fillHeight")]
            public int? FillHeight { get; set; }
            /// <summary>Width of box to fill.</summary>
            [QueryParameter("fillWidth")]
            public int? FillWidth { get; set; }
            /// <summary>Optional. Apply a foreground layer on top of the image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("foregroundLayer")]
            public string? ForegroundLayer { get; set; }
#nullable restore
#else
            [QueryParameter("foregroundLayer")]
            public string ForegroundLayer { get; set; }
#endif
            /// <summary>Determines the output format of the image - original,gif,jpg,png.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("format")]
            public string Format { get; set; }
#endif
            /// <summary>The fixed image height to return.</summary>
            [QueryParameter("height")]
            public int? Height { get; set; }
            /// <summary>Image index.</summary>
            [QueryParameter("imageIndex")]
            public int? ImageIndex { get; set; }
            /// <summary>The maximum image height to return.</summary>
            [QueryParameter("maxHeight")]
            public int? MaxHeight { get; set; }
            /// <summary>The maximum image width to return.</summary>
            [QueryParameter("maxWidth")]
            public int? MaxWidth { get; set; }
            /// <summary>Optional. Percent to render for the percent played overlay.</summary>
            [QueryParameter("percentPlayed")]
            public double? PercentPlayed { get; set; }
            /// <summary>Optional. Quality setting, from 0-100. Defaults to 90 and should suffice in most cases.</summary>
            [QueryParameter("quality")]
            public int? Quality { get; set; }
            /// <summary>Optional. Supply the cache tag from the item object to receive strong caching headers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tag")]
            public string? Tag { get; set; }
#nullable restore
#else
            [QueryParameter("tag")]
            public string Tag { get; set; }
#endif
            /// <summary>Optional. Unplayed count overlay to render.</summary>
            [QueryParameter("unplayedCount")]
            public int? UnplayedCount { get; set; }
            /// <summary>The fixed image width to return.</summary>
            [QueryParameter("width")]
            public int? Width { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithImageTypeItemRequestBuilderHeadRequestConfiguration : RequestConfiguration<WithImageTypeItemRequestBuilderHeadQueryParameters> {
        }
    }
}