// <auto-generated/>
using Jellyfin.Sdk.Generated.Sessions.Item.Command;
using Jellyfin.Sdk.Generated.Sessions.Item.Message;
using Jellyfin.Sdk.Generated.Sessions.Item.Playing;
using Jellyfin.Sdk.Generated.Sessions.Item.System;
using Jellyfin.Sdk.Generated.Sessions.Item.User;
using Jellyfin.Sdk.Generated.Sessions.Item.Viewing;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Sessions.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Sessions\{sessionId}
    /// </summary>
    public class WithSessionItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The Command property</summary>
        public CommandRequestBuilder Command
        {
            get => new CommandRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Message property</summary>
        public MessageRequestBuilder Message
        {
            get => new MessageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Playing property</summary>
        public PlayingRequestBuilder Playing
        {
            get => new PlayingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The System property</summary>
        public SystemRequestBuilder System
        {
            get => new SystemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The User property</summary>
        public UserRequestBuilder User
        {
            get => new UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Viewing property</summary>
        public ViewingRequestBuilder Viewing
        {
            get => new ViewingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithSessionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSessionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sessions/{sessionId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithSessionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSessionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sessions/{sessionId}", rawUrl)
        {
        }
    }
}
