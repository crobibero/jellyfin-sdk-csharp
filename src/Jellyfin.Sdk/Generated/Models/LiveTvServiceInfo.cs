// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Sdk.Generated.Models
{
    /// <summary>
    /// Class ServiceInfo.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LiveTvServiceInfo : IParsable
    {
        /// <summary>Gets or sets a value indicating whether this instance has update available.</summary>
        public bool? HasUpdateAvailable { get; set; }
        /// <summary>Gets or sets the home page URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HomePageUrl { get; set; }
#nullable restore
#else
        public string HomePageUrl { get; set; }
#endif
        /// <summary>Gets or sets a value indicating whether this instance is visible.</summary>
        public bool? IsVisible { get; set; }
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the status.</summary>
        public global::Jellyfin.Sdk.Generated.Models.LiveTvServiceInfo_Status? Status { get; set; }
        /// <summary>Gets or sets the status message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusMessage { get; set; }
#nullable restore
#else
        public string StatusMessage { get; set; }
#endif
        /// <summary>The Tuners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tuners { get; set; }
#nullable restore
#else
        public List<string> Tuners { get; set; }
#endif
        /// <summary>Gets or sets the version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.LiveTvServiceInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.LiveTvServiceInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.LiveTvServiceInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "HasUpdateAvailable", n => { HasUpdateAvailable = n.GetBoolValue(); } },
                { "HomePageUrl", n => { HomePageUrl = n.GetStringValue(); } },
                { "IsVisible", n => { IsVisible = n.GetBoolValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "Status", n => { Status = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.LiveTvServiceInfo_Status>(); } },
                { "StatusMessage", n => { StatusMessage = n.GetStringValue(); } },
                { "Tuners", n => { Tuners = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "Version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("HasUpdateAvailable", HasUpdateAvailable);
            writer.WriteStringValue("HomePageUrl", HomePageUrl);
            writer.WriteBoolValue("IsVisible", IsVisible);
            writer.WriteStringValue("Name", Name);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.LiveTvServiceInfo_Status>("Status", Status);
            writer.WriteStringValue("StatusMessage", StatusMessage);
            writer.WriteCollectionOfPrimitiveValues<string>("Tuners", Tuners);
            writer.WriteStringValue("Version", Version);
        }
    }
}
#pragma warning restore CS0618
