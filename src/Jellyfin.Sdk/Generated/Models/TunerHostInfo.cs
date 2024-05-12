// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    #pragma warning disable CS1591
    public class TunerHostInfo : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The AllowHWTranscoding property</summary>
        public bool? AllowHWTranscoding { get; set; }
        /// <summary>The DeviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>The EnableStreamLooping property</summary>
        public bool? EnableStreamLooping { get; set; }
        /// <summary>The FriendlyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FriendlyName { get; set; }
#nullable restore
#else
        public string FriendlyName { get; set; }
#endif
        /// <summary>The Id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The IgnoreDts property</summary>
        public bool? IgnoreDts { get; set; }
        /// <summary>The ImportFavoritesOnly property</summary>
        public bool? ImportFavoritesOnly { get; set; }
        /// <summary>The Source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The TunerCount property</summary>
        public int? TunerCount { get; set; }
        /// <summary>The Type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The Url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The UserAgent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserAgent { get; set; }
#nullable restore
#else
        public string UserAgent { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TunerHostInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TunerHostInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TunerHostInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"AllowHWTranscoding", n => { AllowHWTranscoding = n.GetBoolValue(); } },
                {"DeviceId", n => { DeviceId = n.GetStringValue(); } },
                {"EnableStreamLooping", n => { EnableStreamLooping = n.GetBoolValue(); } },
                {"FriendlyName", n => { FriendlyName = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"IgnoreDts", n => { IgnoreDts = n.GetBoolValue(); } },
                {"ImportFavoritesOnly", n => { ImportFavoritesOnly = n.GetBoolValue(); } },
                {"Source", n => { Source = n.GetStringValue(); } },
                {"TunerCount", n => { TunerCount = n.GetIntValue(); } },
                {"Type", n => { Type = n.GetStringValue(); } },
                {"Url", n => { Url = n.GetStringValue(); } },
                {"UserAgent", n => { UserAgent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("AllowHWTranscoding", AllowHWTranscoding);
            writer.WriteStringValue("DeviceId", DeviceId);
            writer.WriteBoolValue("EnableStreamLooping", EnableStreamLooping);
            writer.WriteStringValue("FriendlyName", FriendlyName);
            writer.WriteStringValue("Id", Id);
            writer.WriteBoolValue("IgnoreDts", IgnoreDts);
            writer.WriteBoolValue("ImportFavoritesOnly", ImportFavoritesOnly);
            writer.WriteStringValue("Source", Source);
            writer.WriteIntValue("TunerCount", TunerCount);
            writer.WriteStringValue("Type", Type);
            writer.WriteStringValue("Url", Url);
            writer.WriteStringValue("UserAgent", UserAgent);
        }
    }
}
