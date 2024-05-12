// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    #pragma warning disable CS1591
    public class ConfigImageTypes : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The BackdropSizes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BackdropSizes { get; set; }
#nullable restore
#else
        public List<string> BackdropSizes { get; set; }
#endif
        /// <summary>The BaseUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseUrl { get; set; }
#nullable restore
#else
        public string BaseUrl { get; set; }
#endif
        /// <summary>The LogoSizes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LogoSizes { get; set; }
#nullable restore
#else
        public List<string> LogoSizes { get; set; }
#endif
        /// <summary>The PosterSizes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PosterSizes { get; set; }
#nullable restore
#else
        public List<string> PosterSizes { get; set; }
#endif
        /// <summary>The ProfileSizes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProfileSizes { get; set; }
#nullable restore
#else
        public List<string> ProfileSizes { get; set; }
#endif
        /// <summary>The SecureBaseUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecureBaseUrl { get; set; }
#nullable restore
#else
        public string SecureBaseUrl { get; set; }
#endif
        /// <summary>The StillSizes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StillSizes { get; set; }
#nullable restore
#else
        public List<string> StillSizes { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConfigImageTypes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConfigImageTypes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigImageTypes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"BackdropSizes", n => { BackdropSizes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"BaseUrl", n => { BaseUrl = n.GetStringValue(); } },
                {"LogoSizes", n => { LogoSizes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"PosterSizes", n => { PosterSizes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"ProfileSizes", n => { ProfileSizes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"SecureBaseUrl", n => { SecureBaseUrl = n.GetStringValue(); } },
                {"StillSizes", n => { StillSizes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("BackdropSizes", BackdropSizes);
            writer.WriteStringValue("BaseUrl", BaseUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("LogoSizes", LogoSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("PosterSizes", PosterSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("ProfileSizes", ProfileSizes);
            writer.WriteStringValue("SecureBaseUrl", SecureBaseUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("StillSizes", StillSizes);
        }
    }
}
