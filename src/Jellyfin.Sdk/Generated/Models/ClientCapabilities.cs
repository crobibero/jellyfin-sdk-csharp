// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    #pragma warning disable CS1591
    public class ClientCapabilities : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The AppStoreUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppStoreUrl { get; set; }
#nullable restore
#else
        public string AppStoreUrl { get; set; }
#endif
        /// <summary>A MediaBrowser.Model.Dlna.DeviceProfile represents a set of metadata which determines which content a certain device is able to play.&lt;br /&gt;Specifically, it defines the supported &lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.ContainerProfiles&quot;&gt;containers&lt;/see&gt; and&lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.CodecProfiles&quot;&gt;codecs&lt;/see&gt; (video and/or audio, including codec profiles and levels)the device is able to direct play (without transcoding or remuxing),as well as which &lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.TranscodingProfiles&quot;&gt;containers/codecs to transcode to&lt;/see&gt; in case it isn&apos;t.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Jellyfin.Sdk.Generated.Models.DeviceProfile? DeviceProfile { get; set; }
#nullable restore
#else
        public Jellyfin.Sdk.Generated.Models.DeviceProfile DeviceProfile { get; set; }
#endif
        /// <summary>The IconUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IconUrl { get; set; }
#nullable restore
#else
        public string IconUrl { get; set; }
#endif
        /// <summary>The PlayableMediaTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MediaType?>? PlayableMediaTypes { get; set; }
#nullable restore
#else
        public List<MediaType?> PlayableMediaTypes { get; set; }
#endif
        /// <summary>The SupportedCommands property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GeneralCommandType?>? SupportedCommands { get; set; }
#nullable restore
#else
        public List<GeneralCommandType?> SupportedCommands { get; set; }
#endif
        /// <summary>The SupportsContentUploading property</summary>
        [Obsolete("")]
        public bool? SupportsContentUploading { get; set; }
        /// <summary>The SupportsMediaControl property</summary>
        public bool? SupportsMediaControl { get; set; }
        /// <summary>The SupportsPersistentIdentifier property</summary>
        public bool? SupportsPersistentIdentifier { get; set; }
        /// <summary>The SupportsSync property</summary>
        [Obsolete("")]
        public bool? SupportsSync { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ClientCapabilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ClientCapabilities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClientCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"AppStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"DeviceProfile", n => { DeviceProfile = n.GetObjectValue<Jellyfin.Sdk.Generated.Models.DeviceProfile>(Jellyfin.Sdk.Generated.Models.DeviceProfile.CreateFromDiscriminatorValue); } },
                {"IconUrl", n => { IconUrl = n.GetStringValue(); } },
                {"PlayableMediaTypes", n => { PlayableMediaTypes = n.GetCollectionOfEnumValues<MediaType>()?.ToList(); } },
                {"SupportedCommands", n => { SupportedCommands = n.GetCollectionOfEnumValues<GeneralCommandType>()?.ToList(); } },
                {"SupportsContentUploading", n => { SupportsContentUploading = n.GetBoolValue(); } },
                {"SupportsMediaControl", n => { SupportsMediaControl = n.GetBoolValue(); } },
                {"SupportsPersistentIdentifier", n => { SupportsPersistentIdentifier = n.GetBoolValue(); } },
                {"SupportsSync", n => { SupportsSync = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AppStoreUrl", AppStoreUrl);
            writer.WriteObjectValue<Jellyfin.Sdk.Generated.Models.DeviceProfile>("DeviceProfile", DeviceProfile);
            writer.WriteStringValue("IconUrl", IconUrl);
            writer.WriteCollectionOfEnumValues<MediaType>("PlayableMediaTypes", PlayableMediaTypes);
            writer.WriteCollectionOfEnumValues<GeneralCommandType>("SupportedCommands", SupportedCommands);
            writer.WriteBoolValue("SupportsContentUploading", SupportsContentUploading);
            writer.WriteBoolValue("SupportsMediaControl", SupportsMediaControl);
            writer.WriteBoolValue("SupportsPersistentIdentifier", SupportsPersistentIdentifier);
            writer.WriteBoolValue("SupportsSync", SupportsSync);
        }
    }
}
