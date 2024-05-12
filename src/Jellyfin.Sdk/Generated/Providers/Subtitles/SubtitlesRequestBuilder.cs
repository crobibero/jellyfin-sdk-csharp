// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Providers.Subtitles {
    /// <summary>
    /// Builds and executes requests for operations under \Providers\Subtitles
    /// </summary>
    public class SubtitlesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The Subtitles property</summary>
        public SubtitlesRequestBuilder Subtitles
        {
            get => new SubtitlesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SubtitlesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Providers/Subtitles", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SubtitlesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Providers/Subtitles", rawUrl)
        {
        }
    }
}
