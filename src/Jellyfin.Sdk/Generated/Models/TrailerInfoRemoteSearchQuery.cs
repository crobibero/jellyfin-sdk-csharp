// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    public class TrailerInfoRemoteSearchQuery : IParsable {
        /// <summary>Gets or sets a value indicating whether disabled providers should be included.</summary>
        public bool? IncludeDisabledProviders { get; set; }
        /// <summary>The ItemId property</summary>
        public Guid? ItemId { get; set; }
        /// <summary>The SearchInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TrailerInfo? SearchInfo { get; set; }
#nullable restore
#else
        public TrailerInfo SearchInfo { get; set; }
#endif
        /// <summary>Gets or sets the provider name to search within if set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SearchProviderName { get; set; }
#nullable restore
#else
        public string SearchProviderName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TrailerInfoRemoteSearchQuery CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrailerInfoRemoteSearchQuery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"IncludeDisabledProviders", n => { IncludeDisabledProviders = n.GetBoolValue(); } },
                {"ItemId", n => { ItemId = n.GetGuidValue(); } },
                {"SearchInfo", n => { SearchInfo = n.GetObjectValue<TrailerInfo>(TrailerInfo.CreateFromDiscriminatorValue); } },
                {"SearchProviderName", n => { SearchProviderName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("IncludeDisabledProviders", IncludeDisabledProviders);
            writer.WriteGuidValue("ItemId", ItemId);
            writer.WriteObjectValue<TrailerInfo>("SearchInfo", SearchInfo);
            writer.WriteStringValue("SearchProviderName", SearchProviderName);
        }
    }
}